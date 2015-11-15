namespace HardyWeinberg.Kernel {

    public class Allele {
        // PROPERTIES
        public string Symbol { get; set; }
        public bool IsRecessive { get; set; }

        // INTERFACE FUNCTIONS
        public override string ToString() {
            return Symbol;
        }
        public override bool Equals(object obj) {
            if (!base.Equals(obj))
                return false;

            Allele that = obj as Allele;
            bool equal = (this.Symbol == that.Symbol);
            return equal;
        }
    }

}
