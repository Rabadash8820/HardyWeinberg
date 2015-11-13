using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using HardyWeinberg.Kernel;
using HardyWeinberg.Util;

namespace HardyWeinberg.Shell {

    public partial class MainForm : Form {

        // HIDDEN FIELDS
        private BindingSource _speedBS;
        private Allele[] _dominantAlleles;
        private Allele[] _recessiveAlleles;
        private Simulator _sim;
        private int _iteration;

        // CONSTRUCTORS
        public MainForm() {
            InitializeComponent();

            // Set allele symbols
            _dominantAlleles = new Allele[5] {
                new Allele() { Symbol="A",IsRecessive=false },
                new Allele() { Symbol="B",IsRecessive=false },
                new Allele() { Symbol="C",IsRecessive=false },
                new Allele() { Symbol="D",IsRecessive=false },
                new Allele() { Symbol="E",IsRecessive=false },
            };
            _recessiveAlleles = new Allele[5] {
                new Allele() { Symbol="a",IsRecessive=true },
                new Allele() { Symbol="b",IsRecessive=true },
                new Allele() { Symbol="c",IsRecessive=true },
                new Allele() { Symbol="d",IsRecessive=true },
                new Allele() { Symbol="e",IsRecessive=true },
            };

            // Set allele data bindings
            DominantCombo.SelectedIndex = 0;
            RecessiveCombo.SelectedIndex = 0;

            // Set playback speed data bindings
            _speedBS = new BindingSource(5, null);
            Binding speedTrackBinding = new Binding("Value", _speedBS, null, false, DataSourceUpdateMode.OnPropertyChanged);
            SpeedTrackBar.DataBindings.Add(speedTrackBinding);
            Binding speedLblBinding = new Binding("Text", _speedBS, null, true, DataSourceUpdateMode.Never);
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

            redrawDominantAlleles(numDominant);
            redrawGenotypes(numDominant, numRecessive);
        }
        private void RecessiveCombo_SelectedIndexChanged(object sender, EventArgs e) {
            int numDominant = Convert.ToInt32(DominantCombo.SelectedItem);
            int numRecessive = Convert.ToInt32(RecessiveCombo.SelectedItem);

            redrawRecessiveAlleles(numRecessive);
            redrawGenotypes(numDominant, numRecessive);
        }
        private void StepBtn_Click(object sender, EventArgs e) {
            // Make sure the Simulator has been initialized with user's parameters
            if (_sim == null)
                _sim = defineSimulator();

            // Do a single iteration
            doIteration(_sim);

            // Simulator's state has changed, so allow resetting
            ResetBtn.Enabled = true;
        }
        private void PlayPauseBtn_Click(object sender, EventArgs e) {
            // Make sure the Simulator has been initialized with user's parameters
            if (_sim == null)
                _sim = defineSimulator();

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
            Simulator sim = e.Argument as Simulator;
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
        private void resetSimulation() {
            _sim = null;
            _iteration = 0;

            IterationLbl.Text = $"Iteration: {0}";

            ResetBtn.Enabled = false;
        }
        private void redrawDominantAlleles(int num) {
            // Build a string out of the dominant allele symbols
            StringBuilder sb = new StringBuilder($"{{ {_dominantAlleles[0].Symbol}");
            for (int a = 1; a < num; ++a)
                sb.Append($", {_dominantAlleles[a].Symbol}");
            sb.Append(" }");

            DominantSetLbl.Text = sb.ToString();
        }
        private void redrawRecessiveAlleles(int num) {
            // Build a string out of the recessive allele symbols
            StringBuilder sb = new StringBuilder($"{{ {_recessiveAlleles[0].Symbol}");
            for (int a = 1; a < num; ++a)
                sb.Append($", {_recessiveAlleles[a].Symbol}");
            sb.Append(" }");

            RecessiveSetLbl.Text = sb.ToString();
        }
        private void redrawGenotypes(int numDominant, int numRecessive) {
            // Clear old count controls
            HeteroGrpbox.Controls.Clear();
            HomoGrpbox.Controls.Clear();

            // Add controls for the Homozygous genotype counts
            for (int d = 0; d < numDominant; ++d) {
                string symbol = _dominantAlleles[d].Symbol;
                GenotypeCountPrefab prefab = new GenotypeCountPrefab(true, symbol + symbol, d, 0);
                prefab.AddToContainer(HomoGrpbox);
            }
            for (int r = 0; r < numRecessive; ++r) {
                string symbol = _recessiveAlleles[r].Symbol;
                GenotypeCountPrefab prefab = new GenotypeCountPrefab(true, symbol + symbol, r + numDominant, 0);
                prefab.AddToContainer(HomoGrpbox);
            }

            // Add controls for the Heterozygous genotype counts
            Allele[] everyAllele = _dominantAlleles.Take(numDominant).Union(_recessiveAlleles.Take(numRecessive)).ToArray();
            for (int a1 = 0; a1 < numDominant + numRecessive; ++a1) {
                for (int a2=0;a2< a1; ++a2) {
                    string symbol = everyAllele[a2].Symbol + everyAllele[a1].Symbol;
                    GenotypeCountPrefab prefab = new GenotypeCountPrefab(false, symbol, a1, a2);
                    prefab.AddToContainer(HeteroGrpbox);
                }
            }
        }
        private Simulator defineSimulator() {
            // Get the number of dominant/recessive alleles
            int numDominant = Convert.ToInt32(DominantCombo.SelectedItem);
            int numRecessive = Convert.ToInt32(RecessiveCombo.SelectedItem);

            // Get the initial number of individuals with each genotype
            Dictionary<Genotype, int> counts = new Dictionary<Genotype, int>();

            // Return a Simulator with these initial counts
            Simulator sim = new Simulator(counts);
            return sim;
        }
        private void togglePlayState(bool playing) {
            StepBtn.Enabled = !playing;
            ResetBtn.Enabled = !playing;
            PlayPauseBtn.Text = (playing ? "Pause" : "Play");
        }
        private void doIteration(Simulator sim) {
            //sim.Iterate();

            IterationLbl.InvokeIfRequired(() => {
                IterationLbl.Text = $"Iteration: {++_iteration}";
            });
        }

    }

}
