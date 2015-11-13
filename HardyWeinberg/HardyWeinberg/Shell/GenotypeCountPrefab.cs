using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardyWeinberg.Shell {

    class GenotypeCountPrefab : Util.ControlPrefab {
        // HIDDEN FIELDS
        private const int INIT_VERT_PADDING = 20;
        private const int INIT_HORZ_PADDING = 7;
        private const int VERT_PADDING = 10;
        private const int HORZ_PADDING = 15;
        private Size UPDOWN_SIZE = new Size(60, 23);
        private Size LBL_SIZE = new Size(23, 13);
        private const int LBL_OFFSET = 2;
        private Label _label;
        private NumericUpDown _upDown;
        
        // CONSTRUCTORS
        public GenotypeCountPrefab(bool homozygous, string symbol, int row, int col) {
            build(homozygous, symbol, row, col);
        }

        // HELPER FUNCTIONS
        protected override void AddControlsToContainer(Control container) {
            container.Controls.Add(_label);
            container.Controls.Add(_upDown);
        }
        private void build(bool homozygous, string symbol, int row, int col) {
            string id = row.ToString() + col.ToString();
            int x = INIT_HORZ_PADDING + (UPDOWN_SIZE.Width + LBL_SIZE.Width + HORZ_PADDING) * col;
            int y = INIT_VERT_PADDING + (Math.Max(UPDOWN_SIZE.Height, LBL_SIZE.Width) + VERT_PADDING) * row;

            // Initialize the Label
            _label = new Label() {
                Name = $"{(homozygous ? "Homo" : "Hetero")}CountLbl{id}",
                Location = new Point(x, y + LBL_OFFSET),
                AutoSize = false,
                Size = LBL_SIZE,
                Text = symbol,
            };

            // Initialize the NumericUpDown
            _upDown = new NumericUpDown() {
                Name = $"{(homozygous ? "Homo" : "Hetero")}CountUpDown{id}",
                Location = new Point(x + LBL_SIZE.Width, y),
                Size = UPDOWN_SIZE,
                Maximum = 100000m,  // 100,000
                Minimum = 1m,
                Value = 100m,
                ThousandsSeparator = true,
            };
        }
        
    }

}
