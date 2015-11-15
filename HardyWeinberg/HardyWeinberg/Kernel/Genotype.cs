using System.Collections.Generic;

namespace HardyWeinberg.Kernel {

    public class Genotype {
        // PROPERTIES
        public IList<Allele> Alleles { get; }

        // HIDDEN FIELDS
        private bool _homo;

        // CONSTRUCTORS
        public Genotype(Allele allele) {
            Alleles = new List<Allele>(2);

            // Define the genotype as homozygous
            Alleles.Add(allele);
            Alleles.Add(allele);
            _homo = true;
        }
        public Genotype(Allele allele1, Allele allele2) {
            Alleles = new List<Allele>(2);

            // Define the genotype as heterozygous
            Alleles.Add(allele1);
            Alleles.Add(allele2);
            _homo = false;
        }

        // INTERFACE FUNCTIONS
        public bool IsHomozygous {
            get { return _homo; }
        }
        public bool IsHeterozygous {
            get { return !_homo; }
        }
    }

}
