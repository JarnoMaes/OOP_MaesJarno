using OOP_MaesJarno.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class ReisReservatie : ILoggable
    {
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }

        public LogMessage LogMessage
        {
            get
            {
                return new LogMessage
                     (
                     "\nReservatie:" +
                     $"\nNaam: {Persoon.VolledigeNaam}" +
                     $"\nAdres: {Persoon.Adress.Straat} // {Persoon.Adress.HuisNmr} // {Persoon.Adress.PostCode} // {Persoon.Adress.Gemeente}" +
                     $"\nReisbureau: {Reisbureau.Naam}" +
                     $"\nAdres:{Reisbureau.Adress.Straat} // {Reisbureau.Adress.HuisNmr} // {Reisbureau.Adress.PostCode} // {Reisbureau.Adress.Gemeente}" +
                     $"\nReisGegevens : {Reis}"
                     );
            }
        }

        //Constructor voor ReisReservatie
        public ReisReservatie(Persoon persoon, Reis reis,Reisbureau reisbureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
            LoggerService.AddLog(LogMessage);
        }
        
    }
}
