using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Autovakantie : Reis
    {
        private const int PrijsHuurWagen = 10;
        private bool EigenWagen;

        //Constructor die erft van de base class
        public Autovakantie(bool eigenWagen, DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen)   :base (vertrekDatum, terugKeerDatum, aantalPersonen) 
        {
            EigenWagen = eigenWagen;
        }
        //Get And Set for EigenWagen
        public bool eigenWagen
        {
            get { return EigenWagen; }
            set
            {
                if (value == true || false)
                {
                    EigenWagen = value;
                }               
                else
                {
                    Console.WriteLine("Kies tussen True/False, geef niets anders in");
                }
            }
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
