using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class Cruise : Reis
    {
        private const double CRUISEPRIJSEXTRADAGKOST = 10.00d;

        private bool VIP { get; set; }

        public override double BerekenPrijs()
        {
            if (VIP == true)
            {
                double bp = (CRUISEPRIJSEXTRADAGKOST + BASISDAGPRIJS) * AantalDagen * AantalPersoonen;
                bp *= 1.5 / AantalPersoonen;
                return bp;
            }
            else
            {
                double bp = (CRUISEPRIJSEXTRADAGKOST + BASISDAGPRIJS) * AantalDagen * AantalPersoonen;
                bp /= AantalPersoonen;
                return bp;
            }
        }

        public Cruise(int aantalPersoonen, DateTime vertrekDatume, DateTime terugKeerDatume, bool vip)
            :base(aantalPersoonen, vertrekDatume, terugKeerDatume)
        {
            this.VIP = vip;
        }
    }
}
