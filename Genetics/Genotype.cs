using System.Collections.Generic;

namespace Genetics {

    public class Genotype {
        // PROPERTIES
        public IList<Allele> Alleles { get; }

        // HIDDEN FIELDS
        private bool _homo;

        // CONSTRUCTORS
        public Genotype(Allele allele) {
            // Define the genotype as homozygous
            Alleles = new List<Allele>(2) {
                allele,
                allele
            };
            _homo = true;
        }
        public Genotype(Allele allele1, Allele allele2) {
            // Define the genotype as heterozygous
            Alleles = new List<Allele>(2) {
                allele1,
                allele2
            };
            _homo = false;
        }

        // INTERFACE FUNCTIONS
        public bool IsHomozygous => _homo;
        public bool IsHeterozygous => !_homo;
    }

}
