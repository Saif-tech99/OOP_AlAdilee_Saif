using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public abstract class Reis
    {
        protected const double BASISDAGPRIJS = 40.00d;

        public int AantalDagen { get; }
        public int AantalPersoonen { get; set; }
        public DateTime TerugKeerDatume { get; set; }
        public DateTime VertrekDatume { get; set; }

        public  abstract double  BerekenPrijs();

        public Reis(int aantalPersoonen, DateTime vertrekDatume, DateTime terugKeerDatume)
        {
            this.AantalPersoonen = aantalPersoonen;
            this.VertrekDatume = vertrekDatume;
            this.TerugKeerDatume = terugKeerDatume;
        }

    }
}
