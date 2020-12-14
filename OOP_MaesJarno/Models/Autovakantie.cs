using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Autovakantie : Reis
    {
        private const double PrijsHuurWagen = 10;
        public bool EigenWagen { get; set; }

        //Constructor die erft van de base class
        public Autovakantie(bool eigenWagen, DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen)   :base (vertrekDatum, terugKeerDatum, aantalPersonen) 
        {
            EigenWagen = eigenWagen;
        }       
       
        //Berekent Prijs indien wagen huren
        public override double BerekenPrijs()
        {
            if (EigenWagen == true)
            {
                return base.BerekenPrijs();
            }
            else
            {
                var TotaalHuurPrijs =  base.BerekenPrijs() + (PrijsHuurWagen * aantalDagen);
                return TotaalHuurPrijs;
            }
        }
    }
}
