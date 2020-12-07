using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Autovakantie : Reis
    {
        public const double EXTRAPRIJSHUURAUTO = 10;

        private bool EigenWagen { get; set; }

        public override double BerekenPrijs()
        {
            if (EigenWagen == true && AantalPersoonen <= 5)
            {
                double bp = BASISDAGPRIJS * AantalDagen * AantalPersoonen + EXTRAPRIJSHUURAUTO;
                bp /= AantalPersoonen;
                return bp;
            }
            else if (EigenWagen == true && AantalPersoonen > 5)
            {
                double bp = BASISDAGPRIJS * AantalDagen * AantalPersoonen + (EXTRAPRIJSHUURAUTO * AantalPersoonen);
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

        public Autovakantie(int aantalPersoonen, DateTime vertrekDatume, DateTime terugKeerDatume, bool eigenWagen)
            : base(aantalPersoonen, vertrekDatume, terugKeerDatume)
        {
            this.VertrekDatume = vertrekDatume;
            this.AantalPersoonen = aantalPersoonen;
            this.TerugKeerDatume = terugKeerDatume;
            this.EigenWagen = eigenWagen;
        }
    }
}
