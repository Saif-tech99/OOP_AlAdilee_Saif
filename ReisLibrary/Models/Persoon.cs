using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string FamilieNaam { get; set; }
        public string VoorNaam { get; set; }

        private string _naam;

        public string Naam
        {
            get 
            {
                Naam = VoorNaam + " " + FamilieNaam;
                return _naam;
            }
            set { _naam = value; }
        }
    }
}
