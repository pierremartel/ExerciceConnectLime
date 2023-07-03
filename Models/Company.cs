using System;

namespace ExerciceConnectLime.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; private set; }
        private long nipc ;
        public long Nipc {
            get {
                return nipc ;
            } set {
                nipc = value;
            }
        }  

        public long GetIdentificationNumber() {
            return this.nipc;
        }

        // public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
        // public ICollection<Selling> Sellings { get; set; } = new List<Selling>();
    }
}
