namespace Genetics {

    public class Allele {
        // PROPERTIES
        public string Symbol { get; set; }
        public bool IsRecessive { get; set; }

        // INTERFACE FUNCTIONS
        public override string ToString() => Symbol;
        public override bool Equals(object obj) {
            if (!base.Equals(obj))
                return false;

            var that = obj as Allele;
            bool equal = (this.Symbol == that.Symbol);
            return equal;
        }
    }

}
