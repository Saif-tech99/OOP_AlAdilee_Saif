using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Vliegtuigvakantie : Reis
    {
        private const double VLIEGTUIGTICKETPRIJS = 20.00d;

        private bool VliegtuigTicketPrijs { get; set; }

        public override double BerekenPrijs()
        {
            if (VliegtuigTicketPrijs == true)
            {
                double bp = (VLIEGTUIGTICKETPRIJS + BASISDAGPRIJS) * AantalDagen * AantalPersoonen;
                bp /= AantalPersoonen;
                return bp;
            }
            else
            {
                double bp = BASISDAGPRIJS * AantalDagen * AantalPersoonen;
                bp /= AantalPersoonen;
                return bp;
            }
        }

        public Vliegtuigvakantie(int aantalPersoonen, DateTime vertrekDatume, DateTime terugKeerDatume, bool vliegtuigTicketPrijs)
            : base(aantalPersoonen, vertrekDatume, terugKeerDatume)
        {
            this.VertrekDatume = vertrekDatume;
        }
    }
}
