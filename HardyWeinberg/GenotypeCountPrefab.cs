using Genetics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HardyWeinberg {

    class GenotypeCountPrefab : ControlPrefab {
        // HIDDEN FIELDS
        private static int s_initVertPadding = 20;
        private static int s_initHorzPadding = 7;
        private static int s_vertPadding = 10;
        private static int s_horzPadding = 15;
        private Size _updownSize = new Size(60, 23);
        private Size _lblSize = new Size(23, 13);
        private const int s_lblOffset = 2;

        private Label _label;
        private NumericUpDown _upDown;
        private BindingSource _dataBS;
        
        // CONSTRUCTORS
        public GenotypeCountPrefab(GenotypeCount data, int row, int col) {
            _dataBS = new BindingSource(data, null);
            build(row, col);
        }

        // HELPER FUNCTIONS
        protected override void addControlsToContainer(Control container) {
            container.Controls.Add(_label);
            container.Controls.Add(_upDown);
        }
        private void build(int row, int col) {
            string id = row.ToString() + col.ToString();
            int x = s_initHorzPadding + (_updownSize.Width + _lblSize.Width + s_horzPadding) * col;
            int y = s_initVertPadding + (Math.Max(_updownSize.Height, _lblSize.Width) + s_vertPadding) * row;

            var data = (GenotypeCount)_dataBS.DataSource;
            bool isHomo = data.Genotype.IsHomozygous;

            // Initialize the Label
            _label = new Label() {
                Name = $"{(isHomo ? "Homo" : "Hetero")}CountLbl{id}",
                Location = new Point(x, y + s_lblOffset),
                AutoSize = false,
                Size = _lblSize,
            };
            var lblBinding = new Binding("Text", _dataBS, "Genotype.Alleles", true, DataSourceUpdateMode.Never);
            lblBinding.Format += LblBinding_Format;
            _label.DataBindings.Add(lblBinding);

            // Initialize the NumericUpDown
            _upDown = new NumericUpDown() {
                Name = $"{(isHomo ? "Homo" : "Hetero")}CountUpDown{id}",
                Location = new Point(x + _lblSize.Width, y),
                Size = _updownSize,
                Maximum = 100000m,  // 100,000
                Minimum = 0m,
                TabIndex = row,
                Value = 100m,
                ThousandsSeparator = true,
            };
            var countBinding = new Binding("Value", _dataBS, "Count", false, DataSourceUpdateMode.OnPropertyChanged);
            _upDown.DataBindings.Add(countBinding);
        }
        private void LblBinding_Format(object sender, ConvertEventArgs e) {
            IList<Allele> alleles = e.Value as List<Allele>;
            e.Value = alleles[0].Symbol + alleles[1].Symbol;
        }
    }

}
