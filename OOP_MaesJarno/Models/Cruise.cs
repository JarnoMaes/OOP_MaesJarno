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
        public bool VIP { get; private set; }
           
        //Constructor voor Cruise die erft van de base class
        public Cruise(bool vip, DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen) :base (vertrekDatum,terugKeerDatum,aantalPersonen)
        {
            VIP = vip;
        }
         
        //Berekening prijs wel/niet VIP
        public override double BerekenPrijs()
        {
            if (VIP == false)
            {
                return base.BerekenPrijs() + (CruiseExtraDagKost * aantalPersonen);
                
            }
            else
            {
                double totaalVip = base.BerekenPrijs() + ((CruiseExtraDagKost * aantalPersonen) * 1.5);
                return totaalVip;
            }
        }
    }
}
