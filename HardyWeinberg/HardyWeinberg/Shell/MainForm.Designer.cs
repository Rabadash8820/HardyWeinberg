namespace HardyWeinberg.Shell {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabCtrl = new System.Windows.Forms.TabControl();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.ConfigTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NumAllelesPanel = new System.Windows.Forms.Panel();
            this.RecessiveSetLbl = new System.Windows.Forms.Label();
            this.DominantSetLbl = new System.Windows.Forms.Label();
            this.DominantCombo = new System.Windows.Forms.ComboBox();
            this.RecessiveCombo = new System.Windows.Forms.ComboBox();
            this.RecessiveLbl = new System.Windows.Forms.Label();
            this.DominantLbl = new System.Windows.Forms.Label();
            this.GenotypesSplit = new System.Windows.Forms.SplitContainer();
            this.HomoGrpbox = new System.Windows.Forms.GroupBox();
            this.HeteroGrpbox = new System.Windows.Forms.GroupBox();
            this.RunTab = new System.Windows.Forms.TabPage();
            this.RunTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlaybackPanel = new System.Windows.Forms.Panel();
            this.IterationLbl = new System.Windows.Forms.Label();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.StepBtn = new System.Windows.Forms.Button();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.SimulationWorker = new System.ComponentModel.BackgroundWorker();
            this.AlleleCheckPanel = new System.Windows.Forms.Panel();
            this.OutputSplit = new System.Windows.Forms.SplitContainer();
            this.OutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutputDgv = new System.Windows.Forms.DataGridView();
            this.IterationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabCtrl.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.ConfigTblLayout.SuspendLayout();
            this.NumAllelesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenotypesSplit)).BeginInit();
            this.GenotypesSplit.Panel1.SuspendLayout();
            this.GenotypesSplit.Panel2.SuspendLayout();
            this.GenotypesSplit.SuspendLayout();
            this.RunTab.SuspendLayout();
            this.RunTblLayout.SuspendLayout();
            this.PlaybackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.OutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputSplit)).BeginInit();
            this.OutputSplit.Panel1.SuspendLayout();
            this.OutputSplit.Panel2.SuspendLayout();
            this.OutputSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabCtrl
            // 
            this.MainTabCtrl.Controls.Add(this.ConfigTab);
            this.MainTabCtrl.Controls.Add(this.RunTab);
            this.MainTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabCtrl.Location = new System.Drawing.Point(0, 0);
            this.MainTabCtrl.Name = "MainTabCtrl";
            this.MainTabCtrl.SelectedIndex = 0;
            this.MainTabCtrl.Size = new System.Drawing.Size(1025, 410);
            this.MainTabCtrl.TabIndex = 0;
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.ConfigTblLayout);
            this.ConfigTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(1017, 384);
            this.ConfigTab.TabIndex = 0;
            this.ConfigTab.Text = " Configure";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // ConfigTblLayout
            // 
            this.ConfigTblLayout.ColumnCount = 1;
            this.ConfigTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConfigTblLayout.Controls.Add(this.NumAllelesPanel, 0, 0);
            this.ConfigTblLayout.Controls.Add(this.GenotypesSplit, 0, 1);
            this.ConfigTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigTblLayout.Location = new System.Drawing.Point(3, 3);
            this.ConfigTblLayout.Name = "ConfigTblLayout";
            this.ConfigTblLayout.RowCount = 2;
            this.ConfigTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConfigTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConfigTblLayout.Size = new System.Drawing.Size(1011, 378);
            this.ConfigTblLayout.TabIndex = 0;
            // 
            // NumAllelesPanel
            // 
            this.NumAllelesPanel.Controls.Add(this.RecessiveSetLbl);
            this.NumAllelesPanel.Controls.Add(this.DominantSetLbl);
            this.NumAllelesPanel.Controls.Add(this.DominantCombo);
            this.NumAllelesPanel.Controls.Add(this.RecessiveCombo);
            this.NumAllelesPanel.Controls.Add(this.RecessiveLbl);
            this.NumAllelesPanel.Controls.Add(this.DominantLbl);
            this.NumAllelesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumAllelesPanel.Location = new System.Drawing.Point(3, 3);
            this.NumAllelesPanel.Name = "NumAllelesPanel";
            this.NumAllelesPanel.Size = new System.Drawing.Size(1005, 84);
            this.NumAllelesPanel.TabIndex = 0;
            // 
            // RecessiveSetLbl
            // 
            this.RecessiveSetLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecessiveSetLbl.AutoSize = true;
            this.RecessiveSetLbl.Location = new System.Drawing.Point(576, 44);
            this.RecessiveSetLbl.Name = "RecessiveSetLbl";
            this.RecessiveSetLbl.Size = new System.Drawing.Size(16, 13);
            this.RecessiveSetLbl.TabIndex = 4;
            this.RecessiveSetLbl.Text = "{ }";
            // 
            // DominantSetLbl
            // 
            this.DominantSetLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DominantSetLbl.AutoSize = true;
            this.DominantSetLbl.Location = new System.Drawing.Point(576, 17);
            this.DominantSetLbl.Name = "DominantSetLbl";
            this.DominantSetLbl.Size = new System.Drawing.Size(78, 13);
            this.DominantSetLbl.TabIndex = 4;
            this.DominantSetLbl.Text = "{ A, B, C, D, E }";
            // 
            // DominantCombo
            // 
            this.DominantCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DominantCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DominantCombo.FormattingEnabled = true;
            this.DominantCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.DominantCombo.Location = new System.Drawing.Point(449, 14);
            this.DominantCombo.Name = "DominantCombo";
            this.DominantCombo.Size = new System.Drawing.Size(121, 21);
            this.DominantCombo.TabIndex = 0;
            this.DominantCombo.SelectedIndexChanged += new System.EventHandler(this.DominantCombo_SelectedIndexChanged);
            // 
            // RecessiveCombo
            // 
            this.RecessiveCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecessiveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecessiveCombo.FormattingEnabled = true;
            this.RecessiveCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RecessiveCombo.Location = new System.Drawing.Point(449, 41);
            this.RecessiveCombo.Name = "RecessiveCombo";
            this.RecessiveCombo.Size = new System.Drawing.Size(121, 21);
            this.RecessiveCombo.TabIndex = 1;
            this.RecessiveCombo.SelectedIndexChanged += new System.EventHandler(this.RecessiveCombo_SelectedIndexChanged);
            // 
            // RecessiveLbl
            // 
            this.RecessiveLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecessiveLbl.AutoSize = true;
            this.RecessiveLbl.Location = new System.Drawing.Point(350, 44);
            this.RecessiveLbl.Name = "RecessiveLbl";
            this.RecessiveLbl.Size = new System.Drawing.Size(90, 13);
            this.RecessiveLbl.TabIndex = 1;
            this.RecessiveLbl.Text = "Recessive alleles";
            // 
            // DominantLbl
            // 
            this.DominantLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DominantLbl.AutoSize = true;
            this.DominantLbl.Location = new System.Drawing.Point(350, 17);
            this.DominantLbl.Name = "DominantLbl";
            this.DominantLbl.Size = new System.Drawing.Size(93, 13);
            this.DominantLbl.TabIndex = 0;
            this.DominantLbl.Text = "Dominant alleles";
            // 
            // GenotypesSplit
            // 
            this.GenotypesSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GenotypesSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenotypesSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.GenotypesSplit.Location = new System.Drawing.Point(3, 93);
            this.GenotypesSplit.Name = "GenotypesSplit";
            // 
            // GenotypesSplit.Panel1
            // 
            this.GenotypesSplit.Panel1.Controls.Add(this.HomoGrpbox);
            // 
            // GenotypesSplit.Panel2
            // 
            this.GenotypesSplit.Panel2.Controls.Add(this.HeteroGrpbox);
            this.GenotypesSplit.Size = new System.Drawing.Size(1005, 282);
            this.GenotypesSplit.SplitterDistance = 136;
            this.GenotypesSplit.TabIndex = 2;
            this.GenotypesSplit.TabStop = false;
            // 
            // HomoGrpbox
            // 
            this.HomoGrpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomoGrpbox.Location = new System.Drawing.Point(0, 0);
            this.HomoGrpbox.Name = "HomoGrpbox";
            this.HomoGrpbox.Size = new System.Drawing.Size(132, 278);
            this.HomoGrpbox.TabIndex = 2;
            this.HomoGrpbox.TabStop = false;
            this.HomoGrpbox.Text = "Initial homozygotes";
            // 
            // HeteroGrpbox
            // 
            this.HeteroGrpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeteroGrpbox.Location = new System.Drawing.Point(0, 0);
            this.HeteroGrpbox.Name = "HeteroGrpbox";
            this.HeteroGrpbox.Size = new System.Drawing.Size(861, 278);
            this.HeteroGrpbox.TabIndex = 3;
            this.HeteroGrpbox.TabStop = false;
            this.HeteroGrpbox.Text = "Initial heterozygotes";
            // 
            // RunTab
            // 
            this.RunTab.Controls.Add(this.RunTblLayout);
            this.RunTab.Location = new System.Drawing.Point(4, 22);
            this.RunTab.Name = "RunTab";
            this.RunTab.Padding = new System.Windows.Forms.Padding(3);
            this.RunTab.Size = new System.Drawing.Size(1017, 384);
            this.RunTab.TabIndex = 1;
            this.RunTab.Text = "Run";
            this.RunTab.UseVisualStyleBackColor = true;
            // 
            // RunTblLayout
            // 
            this.RunTblLayout.ColumnCount = 2;
            this.RunTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.RunTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RunTblLayout.Controls.Add(this.PlaybackPanel, 0, 0);
            this.RunTblLayout.Controls.Add(this.OutputPanel, 1, 1);
            this.RunTblLayout.Controls.Add(this.AlleleCheckPanel, 0, 1);
            this.RunTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunTblLayout.Location = new System.Drawing.Point(3, 3);
            this.RunTblLayout.Name = "RunTblLayout";
            this.RunTblLayout.RowCount = 2;
            this.RunTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.RunTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RunTblLayout.Size = new System.Drawing.Size(1011, 378);
            this.RunTblLayout.TabIndex = 0;
            // 
            // PlaybackPanel
            // 
            this.RunTblLayout.SetColumnSpan(this.PlaybackPanel, 2);
            this.PlaybackPanel.Controls.Add(this.IterationLbl);
            this.PlaybackPanel.Controls.Add(this.SpeedLbl);
            this.PlaybackPanel.Controls.Add(this.SpeedTrackBar);
            this.PlaybackPanel.Controls.Add(this.ResetBtn);
            this.PlaybackPanel.Controls.Add(this.PlayPauseBtn);
            this.PlaybackPanel.Controls.Add(this.StepBtn);
            this.PlaybackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaybackPanel.Location = new System.Drawing.Point(3, 3);
            this.PlaybackPanel.Name = "PlaybackPanel";
            this.PlaybackPanel.Size = new System.Drawing.Size(1005, 84);
            this.PlaybackPanel.TabIndex = 0;
            // 
            // IterationLbl
            // 
            this.IterationLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IterationLbl.AutoSize = true;
            this.IterationLbl.Location = new System.Drawing.Point(558, 54);
            this.IterationLbl.Name = "IterationLbl";
            this.IterationLbl.Size = new System.Drawing.Size(38, 13);
            this.IterationLbl.TabIndex = 1;
            this.IterationLbl.Text = "label2";
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpeedLbl.AutoSize = true;
            this.SpeedLbl.Location = new System.Drawing.Point(558, 32);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(63, 13);
            this.SpeedLbl.TabIndex = 4;
            this.SpeedLbl.Text = "5 steps/sec";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpeedTrackBar.LargeChange = 10;
            this.SpeedTrackBar.Location = new System.Drawing.Point(448, 32);
            this.SpeedTrackBar.Maximum = 30;
            this.SpeedTrackBar.Minimum = 1;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.SpeedTrackBar.TabIndex = 3;
            this.SpeedTrackBar.TickFrequency = 5;
            this.SpeedTrackBar.Value = 10;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Location = new System.Drawing.Point(546, 3);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayPauseBtn.Location = new System.Drawing.Point(465, 3);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayPauseBtn.TabIndex = 1;
            this.PlayPauseBtn.Text = "Play";
            this.PlayPauseBtn.UseVisualStyleBackColor = true;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // StepBtn
            // 
            this.StepBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StepBtn.Location = new System.Drawing.Point(384, 3);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(75, 23);
            this.StepBtn.TabIndex = 0;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.StepBtn_Click);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.OutputSplit);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(53, 93);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(955, 282);
            this.OutputPanel.TabIndex = 1;
            // 
            // SimulationWorker
            // 
            this.SimulationWorker.WorkerSupportsCancellation = true;
            this.SimulationWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SimulationWorker_DoWork);
            this.SimulationWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SimulationWorker_RunWorkerCompleted);
            // 
            // AlleleCheckPanel
            // 
            this.AlleleCheckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlleleCheckPanel.Location = new System.Drawing.Point(3, 93);
            this.AlleleCheckPanel.Name = "AlleleCheckPanel";
            this.AlleleCheckPanel.Size = new System.Drawing.Size(44, 282);
            this.AlleleCheckPanel.TabIndex = 1;
            // 
            // OutputSplit
            // 
            this.OutputSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputSplit.Location = new System.Drawing.Point(0, 0);
            this.OutputSplit.Name = "OutputSplit";
            // 
            // OutputSplit.Panel1
            // 
            this.OutputSplit.Panel1.Controls.Add(this.OutputChart);
            // 
            // OutputSplit.Panel2
            // 
            this.OutputSplit.Panel2.Controls.Add(this.OutputDgv);
            this.OutputSplit.Size = new System.Drawing.Size(955, 282);
            this.OutputSplit.SplitterDistance = 508;
            this.OutputSplit.TabIndex = 0;
            this.OutputSplit.TabStop = false;
            // 
            // OutputChart
            // 
            chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Interval = 0D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "Iteration";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.LabelStyle.Interval = 0.1D;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Interval = 0.1D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.Title = "Allele Frequency";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.Name = "AlleleFreqArea";
            this.OutputChart.ChartAreas.Add(chartArea4);
            this.OutputChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "ChartLegend";
            this.OutputChart.Legends.Add(legend4);
            this.OutputChart.Location = new System.Drawing.Point(0, 0);
            this.OutputChart.Name = "OutputChart";
            this.OutputChart.Size = new System.Drawing.Size(504, 278);
            this.OutputChart.TabIndex = 3;
            this.OutputChart.TabStop = false;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title4.Name = "ChartTitle";
            title4.Text = "Allele Frequencies Over Time";
            this.OutputChart.Titles.Add(title4);
            // 
            // OutputDgv
            // 
            this.OutputDgv.AllowUserToAddRows = false;
            this.OutputDgv.AllowUserToDeleteRows = false;
            this.OutputDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IterationCol});
            this.OutputDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputDgv.Location = new System.Drawing.Point(0, 0);
            this.OutputDgv.Name = "OutputDgv";
            this.OutputDgv.ReadOnly = true;
            this.OutputDgv.RowHeadersVisible = false;
            this.OutputDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.OutputDgv.Size = new System.Drawing.Size(439, 278);
            this.OutputDgv.TabIndex = 0;
            this.OutputDgv.TabStop = false;
            // 
            // IterationCol
            // 
            this.IterationCol.HeaderText = "Iteration";
            this.IterationCol.Name = "IterationCol";
            this.IterationCol.ReadOnly = true;
            this.IterationCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 410);
            this.Controls.Add(this.MainTabCtrl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(360, 230);
            this.Name = "MainForm";
            this.Text = "Hardy-Weinberg Simulator";
            this.MainTabCtrl.ResumeLayout(false);
            this.ConfigTab.ResumeLayout(false);
            this.ConfigTblLayout.ResumeLayout(false);
            this.NumAllelesPanel.ResumeLayout(false);
            this.NumAllelesPanel.PerformLayout();
            this.GenotypesSplit.Panel1.ResumeLayout(false);
            this.GenotypesSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GenotypesSplit)).EndInit();
            this.GenotypesSplit.ResumeLayout(false);
            this.RunTab.ResumeLayout(false);
            this.RunTblLayout.ResumeLayout(false);
            this.PlaybackPanel.ResumeLayout(false);
            this.PlaybackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.OutputPanel.ResumeLayout(false);
            this.OutputSplit.Panel1.ResumeLayout(false);
            this.OutputSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputSplit)).EndInit();
            this.OutputSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabCtrl;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.TabPage RunTab;
        private System.Windows.Forms.TableLayoutPanel ConfigTblLayout;
        private System.Windows.Forms.Panel NumAllelesPanel;
        private System.Windows.Forms.Label RecessiveSetLbl;
        private System.Windows.Forms.Label DominantSetLbl;
        private System.Windows.Forms.ComboBox DominantCombo;
        private System.Windows.Forms.ComboBox RecessiveCombo;
        private System.Windows.Forms.Label RecessiveLbl;
        private System.Windows.Forms.Label DominantLbl;
        private System.Windows.Forms.TableLayoutPanel RunTblLayout;
        private System.Windows.Forms.Panel PlaybackPanel;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button PlayPauseBtn;
        private System.Windows.Forms.Button StepBtn;
        private System.Windows.Forms.Label SpeedLbl;
        private System.Windows.Forms.SplitContainer GenotypesSplit;
        private System.Windows.Forms.GroupBox HomoGrpbox;
        private System.Windows.Forms.GroupBox HeteroGrpbox;
        private System.ComponentModel.BackgroundWorker SimulationWorker;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label IterationLbl;
        private System.Windows.Forms.Panel AlleleCheckPanel;
        private System.Windows.Forms.SplitContainer OutputSplit;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutputChart;
        private System.Windows.Forms.DataGridView OutputDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IterationCol;
    }
}

