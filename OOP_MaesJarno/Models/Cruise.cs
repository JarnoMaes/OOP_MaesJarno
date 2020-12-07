using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Cruise:Reis
    {
        private const double CruiseExtraDagKost = 10;
        private bool VIP;
           
        //Constructor voor Cruise die erft van de base class
        public Cruise(bool vip, DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen) :base (vertrekDatum,terugKeerDatum,aantalPersonen)
        {
            VIP = vip;
        }
        //Get and Set voor VIP
        public bool vip
        {
            get { return VIP; }
            set
            {
                if (value == false || true)
                {
                    VIP = value;
                }
                else
                {
                    Console.WriteLine("Kies tussen True/False, geef niets anders in");
                }
            }
        }
        //Berekening prijs wel/niet VIP
        public override double BerekenPrijs()
        {
            if (VIP == false)
            {
                var totaalNietVIP = base.BerekenPrijs() + (CruiseExtraDagKost * aantalPersonen);
                return totaalNietVIP;
            }
            else
            {
                double totaalVip = base.BerekenPrijs() + ((CruiseExtraDagKost * aantalPersonen) * 1.5);
                return totaalVip;
            }
        }
    }
}
