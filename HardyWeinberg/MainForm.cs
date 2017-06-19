using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Genetics;

namespace HardyWeinberg {

    public partial class MainForm : Form {

        // HIDDEN FIELDS
        private BindingSource _speedBS;
        private Allele[] _dominantAlleles;
        private Allele[] _recessiveAlleles;
        private GenotypeCount[] _homoCounts;
        private GenotypeCount[,] _heteroCounts;
        private Simulator _sim;
        private int _iteration;
        private Dictionary<Allele, Series> _series;
        private Dictionary<Allele, DataGridViewColumn> _dgvColumns;

        private static int s_defaultCount = 100;
        private const int s_numDefaultAlleles = 5;
        private MarkerStyle[] _markerStyles;

        // CONSTRUCTORS
        public MainForm() {
            InitializeComponent();

            defineConstants();

            // Select default Alleles
            DominantCombo.SelectedIndex = 0;
            RecessiveCombo.SelectedIndex = 0;

            // Set playback speed data bindings
            _speedBS = new BindingSource(5, null);
            var speedTrackBinding = new Binding("Value", _speedBS, null, false, DataSourceUpdateMode.OnPropertyChanged);
            SpeedTrackBar.DataBindings.Add(speedTrackBinding);
            var speedLblBinding = new Binding("Text", _speedBS, null, true, DataSourceUpdateMode.Never);
            speedLblBinding.Format += SpeedBinding_Format;
            SpeedLbl.DataBindings.Add(speedLblBinding);
            
            resetSimulation();
        }

        // EVENT HANDLERS
        private void SpeedBinding_Format(object sender, ConvertEventArgs e) {
            int speed = (int)e.Value;
            e.Value = $"{speed} steps/sec";
        }
        private void DominantCombo_SelectedIndexChanged(object sender, EventArgs e) {
            int numDominant = Convert.ToInt32(DominantCombo.SelectedItem);
            int numRecessive = Convert.ToInt32(RecessiveCombo.SelectedItem);
            
            redrawAlleleAndGenotypeControls(numDominant, numRecessive);
        }
        private void RecessiveCombo_SelectedIndexChanged(object sender, EventArgs e) {
            int numDominant = Convert.ToInt32(DominantCombo.SelectedItem);
            int numRecessive = Convert.ToInt32(RecessiveCombo.SelectedItem);

            redrawAlleleAndGenotypeControls(numDominant, numRecessive);
        }
        private void StepBtn_Click(object sender, EventArgs e) {
            // Make sure the Simulator has been initialized with user's parameters
            if (_sim == null)
                setupSimulation();

            // Do a single iteration
            doIteration(_sim);

            // Simulator's state has changed, so allow resetting
            ResetBtn.Enabled = true;
        }
        private void PlayPauseBtn_Click(object sender, EventArgs e) {
            // Make sure the Simulator has been initialized with user's parameters
            if (_sim == null)
                setupSimulation();

            // If Simulation is already running, then pause, otherwise play
            if (SimulationWorker.IsBusy)
                SimulationWorker.CancelAsync();
            else {
                SimulationWorker.RunWorkerAsync(_sim);
                togglePlayState(true);
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e) {
            resetSimulation();
        }
        private void SimulationWorker_DoWork(object sender, DoWorkEventArgs e) {
            // Define these variables once outside the loop
            int frameDur = 0;
            DateTime start, end;
            TimeSpan elapsedTime;
            int sleepTime;

            // Run the Simulator until cancelled (paused)
            var sim = e.Argument as Simulator;
            while (!SimulationWorker.CancellationPending) {
                // Do an iteration
                start = DateTime.Now;
                doIteration(sim);

                // Sleep so that the framerate is (somewhat) constant and user-configurable
                end = DateTime.Now;
                elapsedTime = end - start;
                SpeedTrackBar.InvokeIfRequired(() => {
                    frameDur = 1000 / (int)SpeedTrackBar.Value;     // In milliseconds
                });
                sleepTime = Math.Max(frameDur - elapsedTime.Milliseconds, 0);
                Thread.Sleep(sleepTime);
            }

            e.Cancel = true;
        }
        private void SimulationWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled)
                togglePlayState(false);
        }

        // HELPER FUNCTIONS
        private void defineConstants() {
            // Define default Alleles
            _dominantAlleles = new Allele[s_numDefaultAlleles] {
                new Allele() { Symbol="A", IsRecessive=false },
                new Allele() { Symbol="B", IsRecessive=false },
                new Allele() { Symbol="C", IsRecessive=false },
                new Allele() { Symbol="D", IsRecessive=false },
                new Allele() { Symbol="E", IsRecessive=false },
            };
            _recessiveAlleles = new Allele[s_numDefaultAlleles] {
                new Allele() { Symbol="a", IsRecessive=true },
                new Allele() { Symbol="b", IsRecessive=true },
                new Allele() { Symbol="c", IsRecessive=true },
                new Allele() { Symbol="d", IsRecessive=true },
                new Allele() { Symbol="e", IsRecessive=true },
            };

            // Define MarkerStyles to be used in later plotting
            _markerStyles = new MarkerStyle[s_numDefaultAlleles] {
                MarkerStyle.Diamond,
                MarkerStyle.Square,
                MarkerStyle.Circle,
                MarkerStyle.Triangle,
                MarkerStyle.Cross,
            };
        }
        private void resetSimulation() {
            _sim = null;
            _iteration = 0;

            IterationLbl.Text = $"Iteration: {0}";

            // Adjust Controls
            ConfigTblLayout.Enabled = true;
            ResetBtn.Enabled = false;
            foreach (Series s in _series.Values)
                s.Points.Clear();
            OutputDgv.Rows.Clear();
        }
        private void redrawAlleleAndGenotypeControls(int numDominant, int numRecessive) {
            StringBuilder sb;

            // Build a string out of the dominant allele symbols and display it
            sb = new StringBuilder($"{{ {_dominantAlleles[0].Symbol}");
            for (int a = 1; a < numDominant; ++a)
                sb.Append($", {_dominantAlleles[a].Symbol}");
            sb.Append(" }");
            DominantSetLbl.Text = sb.ToString();

            // Build a string out of the recessive allele symbols and display it
            sb = new StringBuilder($"{{ {_recessiveAlleles[0].Symbol}");
            for (int a = 1; a < numRecessive; ++a)
                sb.Append($", {_recessiveAlleles[a].Symbol}");
            sb.Append(" }");
            RecessiveSetLbl.Text = sb.ToString();

            // Clear old count controls
            HeteroGrpbox.Controls.Clear();
            HomoGrpbox.Controls.Clear();
            AlleleCheckPanel.Controls.Clear();
            OutputChart.Series.Clear();
            OutputDgv.Columns.Clear();

            // Get all possible Alleles and associate them with Controls
            int numAlleles = numDominant + numRecessive;
            Allele[] everyAllele = _dominantAlleles.Take(numDominant).Union(_recessiveAlleles.Take(numRecessive)).ToArray();
            ChartArea _alleleArea = OutputChart.ChartAreas[0];
            _series = new Dictionary<Allele, Series>(numAlleles);
            _dgvColumns = new Dictionary<Allele, DataGridViewColumn>(numAlleles);
            OutputDgv.Columns.Add(IterationCol);
            for (int a = 0; a < numAlleles; ++a) {
                Allele allele = everyAllele[a];

                // Chart series
                var s = new Series(allele.Symbol) {
                    ChartArea = _alleleArea.Name,
                    ChartType = SeriesChartType.Line,
                    //MarkerStyle = MARKER_STYLES[a],
                };
                _series.Add(allele, s);
                OutputChart.Series.Add(s);

                // DataGridViewColumns
                var col = new DataGridViewTextBoxColumn() {
                    Name = $"AlleleFreqCol{a}",
                    HeaderText = allele.Symbol,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                };
                _dgvColumns.Add(everyAllele[a], col);
                OutputDgv.Columns.Add(col);

                // Checkboxes
                var prefab = new AlleleCheckPrefab(allele, _series[allele], _dgvColumns[allele], a);
                prefab.AddToContainer(AlleleCheckPanel);
            }

            // Define all possible Genotypes and give them a default initial count in the population
            _homoCounts = new GenotypeCount[numAlleles];
            _heteroCounts = new GenotypeCount[numAlleles, numAlleles];
            for (int ca = 0; ca < numAlleles; ++ca) {   // ca = col allele
                // Homozygotes
                var homoGenotype = new Genotype(everyAllele[ca]);
                var homo = new GenotypeCount() { Genotype = homoGenotype, Count = s_defaultCount };
                _homoCounts[ca] = homo;
                var homoPrefab = new GenotypeCountPrefab(homo, ca, 0);
                homoPrefab.AddToContainer(HomoGrpbox);

                // Heterozygotes
                for (int ra = ca + 1; ra < numAlleles; ++ra) {  // ra = row allele
                    var heteroGenotype = new Genotype(everyAllele[ca], everyAllele[ra]);
                    var hetero = new GenotypeCount() { Genotype = heteroGenotype, Count = s_defaultCount };
                    _heteroCounts[ra, ca] = hetero;
                    var heteroPrefab = new GenotypeCountPrefab(hetero, ra, ca);
                    heteroPrefab.AddToContainer(HeteroGrpbox);
                }
            }

        }
        private void setupSimulation() {
            // Use provided parameters to define a Simulator
            _sim = defineSimulator();

            // Get allele frequencies from genotype frequencies and add them to the Chart
            Dictionary<Allele, double> alleleFreqs = getAlleleFreqs(_sim.Counts);
            int rowIndex = OutputDgv.Rows.Add(1);
            OutputDgv.Rows[rowIndex].Cells[IterationCol.Index].Value = 0;
            foreach (Allele a in alleleFreqs.Keys) {
                _series[a].Points.AddXY(0, alleleFreqs[a]);
                OutputDgv.Rows[rowIndex].Cells[_dgvColumns[a].Index].Value = alleleFreqs[a].ToString("N3");
            }

            // Prevent user reconfiguring things while Simulator is running
            ConfigTblLayout.Enabled = false;
        }
        private Dictionary<Allele, double> getAlleleFreqs(IDictionary<Genotype, int> genotypeCounts) {
            // Get the total count of Alleles
            long totalPop = genotypeCounts.Sum(pair => (long)pair.Value);
            long totalAlleles = 2 * totalPop;

            // Get the count of each Allele (twice in homozygotes, once in heterozygotes)
            var alleleCounts = new Dictionary<Allele, long>();
            Genotype[] genotypes = genotypeCounts.Keys.ToArray();
            foreach (Genotype g in genotypes) {
                int count = genotypeCounts[g];

                // Increment the first Allele's count
                Allele a1 = g.Alleles[0];
                if (alleleCounts.ContainsKey(a1))
                    alleleCounts[a1] += count;
                else
                    alleleCounts.Add(a1, count);
               
                // Increment the third Allele's count
                Allele a2 = g.Alleles[1];
                if (alleleCounts.ContainsKey(a2))
                    alleleCounts[a2] += count;
                else
                    alleleCounts.Add(a2, count);
            }

            // Divide by total to get Allele frequencies
            var alleleFreqs = alleleCounts.ToDictionary(
                pair => pair.Key,
                pair => (double)pair.Value / (double)totalAlleles
            );
            return alleleFreqs;
        }
        private Simulator defineSimulator() {
            // Get the number of dominant/recessive alleles
            int numDominant = Convert.ToInt32(DominantCombo.SelectedItem);
            int numRecessive = Convert.ToInt32(RecessiveCombo.SelectedItem);

            // Get the initial number of individuals with each genotype
            var counts = new Dictionary<Genotype, int>();
            foreach (GenotypeCount data in _homoCounts)
                counts.Add(data.Genotype, data.Count);
            foreach (GenotypeCount data in _heteroCounts) {
                if (data != null)
                    counts.Add(data.Genotype, data.Count);
            }

            // Return a Simulator with these initial counts
            var sim = new Simulator(counts);
            return sim;
        }
        private void togglePlayState(bool playing) {
            StepBtn.Enabled = !playing;
            ResetBtn.Enabled = !playing;
            PlayPauseBtn.Text = (playing ? "Pause" : "Play");
        }
        private void doIteration(Simulator sim) {
            ++_iteration;

            // Do an iteration of the Simulator
            sim.Iterate();

            // Get allele frequencies from genotype frequencies and add these values to the output Controls
            Dictionary<Allele, double> alleleFreqs = getAlleleFreqs(sim.Counts);
            int rowIndex = 0;
            OutputDgv.InvokeIfRequired(() => {
                rowIndex = OutputDgv.Rows.Add(1);
                OutputDgv.Rows[rowIndex].Cells[IterationCol.Index].Value = _iteration;
                OutputDgv.FirstDisplayedScrollingRowIndex = rowIndex;
            });
            foreach (Allele a in alleleFreqs.Keys) {
                OutputChart.InvokeIfRequired(() => {
                    _series[a].Points.AddXY(_iteration, alleleFreqs[a]);
                });
                OutputDgv.InvokeIfRequired(() => {
                    OutputDgv.Rows[rowIndex].Cells[_dgvColumns[a].Index].Value = alleleFreqs[a].ToString("N3");
                });
            }

            // Adjust controls
            IterationLbl.InvokeIfRequired(() => {
                IterationLbl.Text = $"Iteration: {_iteration}";
            });
        }

    }

    public class GenotypeCount {
        public Genotype Genotype { get; set; }
        public int Count { get; set; }
    }

}
