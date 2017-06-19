using Genetics;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HardyWeinberg {

    class AlleleCheckPrefab : ControlPrefab {
        // HIDDEN FIELDS
        private const int s_initVertPadding = 20;
        private const int s_initHorzPadding = 7;
        private const int s_vertPadding = 10;
        private const int s_chkHeight = 20;

        private CheckBox _chk;
        private Series _series;
        private DataGridViewColumn _col;

        // CONSTRUCTORS
        public AlleleCheckPrefab(Allele allele, Series series, DataGridViewColumn column, int row) {
            _series = series;
            _col = column;

            build(allele, row);
        }

        // HELPER FUNCTIONS
        protected override void addControlsToContainer(Control container) {
            container.Controls.Add(_chk);
        }
        private void build(Allele allele, int row) {
            int x = s_initHorzPadding;
            int y = s_initVertPadding + (s_chkHeight + s_vertPadding) * row;

            // Initialize the Checkbox
            _chk = new CheckBox() {
                Name = $"AlleleChk{row}",
                AutoSize = true,
                Location = new Point(x, y),
                Checked = true,
                TabIndex = row,
                Text = allele.Symbol,
                UseVisualStyleBackColor = true,
            };
            _chk.CheckedChanged += AlleleChk_CheckedChanged;
        }

        private void AlleleChk_CheckedChanged(object sender, EventArgs e) {
            bool isChecked = _chk.Checked;

            _series.Enabled = isChecked;
            _col.Visible = isChecked;
        }

    }

}
