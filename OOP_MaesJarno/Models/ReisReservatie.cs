using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class ReisReservatie
    {
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        Reisbureau Reisbureau { get; set; }
        
        //Constructor voor ReisReservatie
        public ReisReservatie(Persoon persoon, Reis reis,Reisbureau reisbureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
        }
    }
}
