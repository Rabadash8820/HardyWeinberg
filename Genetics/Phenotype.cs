using System.Linq;
using System.Collections.Generic;

namespace Genetics {

    public class Phenotype {
        // INTERFACE
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Genotype> Genotypes { get; set; }

        // CONSTRUCTORS
        public Phenotype(string name) {
            reset(name, "", new List<Genotype>());
        }
        public Phenotype(string name, string description) {
            reset(name, description, new List<Genotype>());
        }
        public Phenotype(string name, IEnumerable<Genotype> genotypes) {
            reset(name, "", genotypes.ToList());
        }
        public Phenotype(string name, string description, IEnumerable<Genotype> genotypes) {
            reset(name, description, genotypes.ToList());
        }
        public Phenotype(string name, params Genotype[] genotypes) {
            reset(name, "", genotypes.ToList());
        }
        public Phenotype(string name, string description, params Genotype[] genotypes) {
            reset(name, description, genotypes.ToList());
        }

        // HELPER FUNCTIONS
        private void reset(string name, string description, IList<Genotype> genotypes) {
            Name = name;
            Description = description;
            Genotypes = genotypes;
        }
    }

}
