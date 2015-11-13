using System;
using System.Collections.Generic;
using System.Linq;

namespace HardyWeinberg.Kernel {

    class Simulator {
        // PROPERTIES
        public long PopulationSize {
            get { return _popSize; }
        }
        public IDictionary<Genotype, int> Counts {
            get { return _counts; }
        }

        // HIDDEN FIELDS
        private IList<Genotype> _genotypes;
        private IList<Phenotype> _phenotypes;
        private IDictionary<Genotype, int> _counts;
        private long _popSize;
        private Random _rand;

        // CONSTRUCTORS
        public Simulator(IDictionary<Genotype,int> genotypeCounts) {
            // Define private variables
            _genotypes = new List<Genotype>();
            _phenotypes = new List<Phenotype>();
            _rand = new Random();

            // Initialize simulation data
            _counts = genotypeCounts;
            _popSize = _counts.Sum(pair => pair.Value);
            foreach (Genotype g in genotypeCounts.Keys)
                _genotypes.Add(g);
        }

        // INTERFACE FUNCTIONS
        public void Iterate() {
            // Define a new Dictionary mapping genotypes to counts
            int numGenotypes = _genotypes.Count;
            IDictionary<Genotype, int> newCounts = new Dictionary<Genotype, int>();
            for (int g = 0; g < numGenotypes; ++g)
                newCounts.Add(_genotypes[g], 0);

            // Generate a new population of the same size
            // Each child's genotype is a pair of random alleles from random parent genotypes
            for (int i = 0; i < _popSize; ++i) {
                int g1 = _rand.Next(0, numGenotypes);
                int g2 = _rand.Next(0, numGenotypes);
                Genotype genotype1 = _genotypes[g1];
                Genotype genotype2 = _genotypes[g2];
                Allele a1 = randomAllele(genotype1);
                Allele a2 = randomAllele(genotype2);
                Genotype childGenotype = _genotypes.Where(g =>
                                                        (g.Alleles[0].Equals(a1) && g.Alleles.Equals(a2)) ||
                                                        (g.Alleles[0].Equals(a2) && g.Alleles[1].Equals(a1)))
                                                   .Single();
                newCounts[childGenotype]++;
            }

            // Overwrite the old genotype counts with the newly generated ones
            _counts = newCounts;
        }

        // HELPER FUNCTIONS
        private Allele randomAllele(Genotype genotype) {
            // If the Genotype is homozygous then just return the first Allele (doesn't matter which)
            if (genotype.IsHomozygous)
                return genotype.Alleles[0];

            // Otherwise, return a random Allele
            else {
                int a = _rand.Next(0, 2);
                return genotype.Alleles[a];
            }
        }
    }

}
