using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

using HardyWeinberg.Kernel;

namespace HardyWeinberg.Shell {

    class AlleleCheckPrefab : Util.ControlPrefab {
        // HIDDEN FIELDS
        private const int INIT_VERT_PADDING = 20;
        private const int INIT_HORZ_PADDING = 7;
        private const int VERT_PADDING = 10;
        private const int CHK_HEIGHT = 20;

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
        protected override void AddControlsToContainer(Control container) {
            container.Controls.Add(_chk);
        }
        private void build(Allele allele, int row) {
            int x = INIT_HORZ_PADDING;
            int y = INIT_VERT_PADDING + (CHK_HEIGHT + VERT_PADDING) * row;

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
