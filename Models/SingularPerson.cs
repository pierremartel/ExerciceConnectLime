using System;

namespace ExerciceConnectLime.Models
{
    public class SingularPerson
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; private set; }
        private int nif ;
        public int Nif {
            get {
                return nif ;
            } set {
                nif = value;
            }
        }  

        public int GetIdentificationNumber() {
            return this.nif;
        }

        // public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
        // public ICollection<Selling> Sellings { get; set; } = new List<Selling>();

    }
}
