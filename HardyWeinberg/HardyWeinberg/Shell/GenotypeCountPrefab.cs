using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HardyWeinberg.Kernel;

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
        private BindingSource _dataBS;
        
        // CONSTRUCTORS
        public GenotypeCountPrefab(GenotypeCount data, int row, int col) {
            _dataBS = new BindingSource(data, null);
            build(row, col);
        }

        // HELPER FUNCTIONS
        protected override void AddControlsToContainer(Control container) {
            container.Controls.Add(_label);
            container.Controls.Add(_upDown);
        }
        private void build(int row, int col) {
            string id = row.ToString() + col.ToString();
            int x = INIT_HORZ_PADDING + (UPDOWN_SIZE.Width + LBL_SIZE.Width + HORZ_PADDING) * col;
            int y = INIT_VERT_PADDING + (Math.Max(UPDOWN_SIZE.Height, LBL_SIZE.Width) + VERT_PADDING) * row;

            GenotypeCount data = (GenotypeCount)_dataBS.DataSource;
            bool isHomo = data.Genotype.IsHomozygous;

            // Initialize the Label
            _label = new Label() {
                Name = $"{(isHomo ? "Homo" : "Hetero")}CountLbl{id}",
                Location = new Point(x, y + LBL_OFFSET),
                AutoSize = false,
                Size = LBL_SIZE,
            };
            Binding lblBinding = new Binding("Text", _dataBS, "Genotype.Alleles", true, DataSourceUpdateMode.Never);
            lblBinding.Format += LblBinding_Format;
            _label.DataBindings.Add(lblBinding);

            // Initialize the NumericUpDown
            _upDown = new NumericUpDown() {
                Name = $"{(isHomo ? "Homo" : "Hetero")}CountUpDown{id}",
                Location = new Point(x + LBL_SIZE.Width, y),
                Size = UPDOWN_SIZE,
                Maximum = 100000m,  // 100,000
                Minimum = 0m,
                TabIndex = row,
                Value = 100m,
                ThousandsSeparator = true,
            };
            Binding countBinding = new Binding("Value", _dataBS, "Count", false, DataSourceUpdateMode.OnPropertyChanged);
            _upDown.DataBindings.Add(countBinding);
        }
        private void LblBinding_Format(object sender, ConvertEventArgs e) {
            IList<Allele> alleles = e.Value as List<Allele>;
            e.Value = alleles[0].Symbol + alleles[1].Symbol;
        }
    }

}
