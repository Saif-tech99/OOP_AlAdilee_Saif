using ReisLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Models
{
    public class ReisReservatie 
    {
        public LogMessage LogMessage { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public ReisBureau ReisBureau { get; set; }

        public ReisReservatie( Persoon persoons, Reis reis, ReisBureau reisBureau)
        {
            this.Reis = reis;
            this.ReisBureau = reisBureau;
            this.Persoon = persoons;
        }
    }
}
