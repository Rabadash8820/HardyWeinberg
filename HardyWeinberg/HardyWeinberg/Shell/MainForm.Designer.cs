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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainTabCtrl = new System.Windows.Forms.TabControl();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.RunTab = new System.Windows.Forms.TabPage();
            this.ConfigTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NumAllelesPanel = new System.Windows.Forms.Panel();
            this.DominantLbl = new System.Windows.Forms.Label();
            this.RecessiveLbl = new System.Windows.Forms.Label();
            this.RecessiveCombo = new System.Windows.Forms.ComboBox();
            this.DominantCombo = new System.Windows.Forms.ComboBox();
            this.DominantSetLbl = new System.Windows.Forms.Label();
            this.RecessiveSetLbl = new System.Windows.Forms.Label();
            this.RunTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlaybackPanel = new System.Windows.Forms.Panel();
            this.StepBtn = new System.Windows.Forms.Button();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.SimulationWorker = new System.ComponentModel.BackgroundWorker();
            this.GenotypesSplit = new System.Windows.Forms.SplitContainer();
            this.HeteroGrpbox = new System.Windows.Forms.GroupBox();
            this.HomoGrpbox = new System.Windows.Forms.GroupBox();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IterationLbl = new System.Windows.Forms.Label();
            this.MainTabCtrl.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.RunTab.SuspendLayout();
            this.ConfigTblLayout.SuspendLayout();
            this.NumAllelesPanel.SuspendLayout();
            this.RunTblLayout.SuspendLayout();
            this.PlaybackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenotypesSplit)).BeginInit();
            this.GenotypesSplit.Panel1.SuspendLayout();
            this.GenotypesSplit.Panel2.SuspendLayout();
            this.GenotypesSplit.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).BeginInit();
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
            this.MainTabCtrl.Size = new System.Drawing.Size(591, 410);
            this.MainTabCtrl.TabIndex = 0;
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.ConfigTblLayout);
            this.ConfigTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(583, 384);
            this.ConfigTab.TabIndex = 0;
            this.ConfigTab.Text = " Configure";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // RunTab
            // 
            this.RunTab.Controls.Add(this.RunTblLayout);
            this.RunTab.Location = new System.Drawing.Point(4, 22);
            this.RunTab.Name = "RunTab";
            this.RunTab.Padding = new System.Windows.Forms.Padding(3);
            this.RunTab.Size = new System.Drawing.Size(583, 384);
            this.RunTab.TabIndex = 1;
            this.RunTab.Text = "Run";
            this.RunTab.UseVisualStyleBackColor = true;
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
            this.ConfigTblLayout.Size = new System.Drawing.Size(577, 378);
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
            this.NumAllelesPanel.Size = new System.Drawing.Size(571, 84);
            this.NumAllelesPanel.TabIndex = 0;
            // 
            // DominantLbl
            // 
            this.DominantLbl.AutoSize = true;
            this.DominantLbl.Location = new System.Drawing.Point(13, 17);
            this.DominantLbl.Name = "DominantLbl";
            this.DominantLbl.Size = new System.Drawing.Size(93, 13);
            this.DominantLbl.TabIndex = 0;
            this.DominantLbl.Text = "Dominant alleles";
            // 
            // RecessiveLbl
            // 
            this.RecessiveLbl.AutoSize = true;
            this.RecessiveLbl.Location = new System.Drawing.Point(13, 44);
            this.RecessiveLbl.Name = "RecessiveLbl";
            this.RecessiveLbl.Size = new System.Drawing.Size(90, 13);
            this.RecessiveLbl.TabIndex = 1;
            this.RecessiveLbl.Text = "Recessive alleles";
            // 
            // RecessiveCombo
            // 
            this.RecessiveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecessiveCombo.FormattingEnabled = true;
            this.RecessiveCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RecessiveCombo.Location = new System.Drawing.Point(112, 41);
            this.RecessiveCombo.Name = "RecessiveCombo";
            this.RecessiveCombo.Size = new System.Drawing.Size(121, 21);
            this.RecessiveCombo.TabIndex = 2;
            this.RecessiveCombo.SelectedIndexChanged += new System.EventHandler(this.RecessiveCombo_SelectedIndexChanged);
            // 
            // DominantCombo
            // 
            this.DominantCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DominantCombo.FormattingEnabled = true;
            this.DominantCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.DominantCombo.Location = new System.Drawing.Point(112, 14);
            this.DominantCombo.Name = "DominantCombo";
            this.DominantCombo.Size = new System.Drawing.Size(121, 21);
            this.DominantCombo.TabIndex = 3;
            this.DominantCombo.SelectedIndexChanged += new System.EventHandler(this.DominantCombo_SelectedIndexChanged);
            // 
            // DominantSetLbl
            // 
            this.DominantSetLbl.AutoSize = true;
            this.DominantSetLbl.Location = new System.Drawing.Point(239, 17);
            this.DominantSetLbl.Name = "DominantSetLbl";
            this.DominantSetLbl.Size = new System.Drawing.Size(78, 13);
            this.DominantSetLbl.TabIndex = 4;
            this.DominantSetLbl.Text = "{ A, B, C, D, E }";
            // 
            // RecessiveSetLbl
            // 
            this.RecessiveSetLbl.AutoSize = true;
            this.RecessiveSetLbl.Location = new System.Drawing.Point(239, 44);
            this.RecessiveSetLbl.Name = "RecessiveSetLbl";
            this.RecessiveSetLbl.Size = new System.Drawing.Size(16, 13);
            this.RecessiveSetLbl.TabIndex = 4;
            this.RecessiveSetLbl.Text = "{ }";
            // 
            // RunTblLayout
            // 
            this.RunTblLayout.ColumnCount = 1;
            this.RunTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RunTblLayout.Controls.Add(this.PlaybackPanel, 0, 0);
            this.RunTblLayout.Controls.Add(this.OutputPanel, 0, 1);
            this.RunTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunTblLayout.Location = new System.Drawing.Point(3, 3);
            this.RunTblLayout.Name = "RunTblLayout";
            this.RunTblLayout.RowCount = 2;
            this.RunTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.RunTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RunTblLayout.Size = new System.Drawing.Size(577, 378);
            this.RunTblLayout.TabIndex = 0;
            // 
            // PlaybackPanel
            // 
            this.PlaybackPanel.Controls.Add(this.IterationLbl);
            this.PlaybackPanel.Controls.Add(this.SpeedLbl);
            this.PlaybackPanel.Controls.Add(this.SpeedTrackBar);
            this.PlaybackPanel.Controls.Add(this.ResetBtn);
            this.PlaybackPanel.Controls.Add(this.PlayPauseBtn);
            this.PlaybackPanel.Controls.Add(this.StepBtn);
            this.PlaybackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaybackPanel.Location = new System.Drawing.Point(3, 3);
            this.PlaybackPanel.Name = "PlaybackPanel";
            this.PlaybackPanel.Size = new System.Drawing.Size(571, 84);
            this.PlaybackPanel.TabIndex = 0;
            // 
            // StepBtn
            // 
            this.StepBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StepBtn.Location = new System.Drawing.Point(167, 3);
            this.StepBtn.Name = "StepBtn";
            this.StepBtn.Size = new System.Drawing.Size(75, 23);
            this.StepBtn.TabIndex = 0;
            this.StepBtn.Text = "Step";
            this.StepBtn.UseVisualStyleBackColor = true;
            this.StepBtn.Click += new System.EventHandler(this.StepBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayPauseBtn.Location = new System.Drawing.Point(248, 3);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayPauseBtn.TabIndex = 1;
            this.PlayPauseBtn.Text = "Play";
            this.PlayPauseBtn.UseVisualStyleBackColor = true;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Location = new System.Drawing.Point(329, 3);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpeedTrackBar.LargeChange = 10;
            this.SpeedTrackBar.Location = new System.Drawing.Point(231, 32);
            this.SpeedTrackBar.Maximum = 30;
            this.SpeedTrackBar.Minimum = 1;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.SpeedTrackBar.TabIndex = 3;
            this.SpeedTrackBar.TickFrequency = 5;
            this.SpeedTrackBar.Value = 5;
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpeedLbl.AutoSize = true;
            this.SpeedLbl.Location = new System.Drawing.Point(341, 32);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(63, 13);
            this.SpeedLbl.TabIndex = 4;
            this.SpeedLbl.Text = "5 steps/sec";
            // 
            // SimulationWorker
            // 
            this.SimulationWorker.WorkerSupportsCancellation = true;
            this.SimulationWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SimulationWorker_DoWork);
            this.SimulationWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SimulationWorker_RunWorkerCompleted);
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
            this.GenotypesSplit.Size = new System.Drawing.Size(571, 282);
            this.GenotypesSplit.SplitterDistance = 136;
            this.GenotypesSplit.TabIndex = 2;
            // 
            // HeteroGrpbox
            // 
            this.HeteroGrpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeteroGrpbox.Location = new System.Drawing.Point(0, 0);
            this.HeteroGrpbox.Name = "HeteroGrpbox";
            this.HeteroGrpbox.Size = new System.Drawing.Size(427, 278);
            this.HeteroGrpbox.TabIndex = 3;
            this.HeteroGrpbox.TabStop = false;
            this.HeteroGrpbox.Text = "Initial heterozygotes";
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
            // OutputPanel
            // 
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputPanel.Controls.Add(this.OutputChart);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(3, 93);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(571, 282);
            this.OutputPanel.TabIndex = 1;
            // 
            // OutputChart
            // 
            chartArea6.Name = "ChartArea1";
            this.OutputChart.ChartAreas.Add(chartArea6);
            this.OutputChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.OutputChart.Legends.Add(legend6);
            this.OutputChart.Location = new System.Drawing.Point(0, 0);
            this.OutputChart.Name = "OutputChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.OutputChart.Series.Add(series6);
            this.OutputChart.Size = new System.Drawing.Size(567, 278);
            this.OutputChart.TabIndex = 2;
            this.OutputChart.Text = "chart1";
            // 
            // IterationLbl
            // 
            this.IterationLbl.AutoSize = true;
            this.IterationLbl.Location = new System.Drawing.Point(58, 32);
            this.IterationLbl.Name = "IterationLbl";
            this.IterationLbl.Size = new System.Drawing.Size(38, 13);
            this.IterationLbl.TabIndex = 1;
            this.IterationLbl.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 410);
            this.Controls.Add(this.MainTabCtrl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(360, 230);
            this.Name = "MainForm";
            this.Text = "Hardy-Weinberg Simulator";
            this.MainTabCtrl.ResumeLayout(false);
            this.ConfigTab.ResumeLayout(false);
            this.RunTab.ResumeLayout(false);
            this.ConfigTblLayout.ResumeLayout(false);
            this.NumAllelesPanel.ResumeLayout(false);
            this.NumAllelesPanel.PerformLayout();
            this.RunTblLayout.ResumeLayout(false);
            this.PlaybackPanel.ResumeLayout(false);
            this.PlaybackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.GenotypesSplit.Panel1.ResumeLayout(false);
            this.GenotypesSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GenotypesSplit)).EndInit();
            this.GenotypesSplit.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart OutputChart;
        private System.Windows.Forms.Label IterationLbl;
    }
}

