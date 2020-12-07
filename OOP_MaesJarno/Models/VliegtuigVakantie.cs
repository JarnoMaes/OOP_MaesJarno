using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class VliegtuigVakantie:Reis
    {
        private double VliegtuigTicketPrijs;

        //Constructor voor vliegtuigvakantie die erft van de base Class
        public VliegtuigVakantie(int vliegtuigTicketPrijs,DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen) :base (vertrekDatum,terugKeerDatum,aantalPersonen)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }       
        //Get and set voor vliegtuigticketprijs
        public double vliegtuigTicketPrijs
        {
            get { return VliegtuigTicketPrijs; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Geef een juist bedrag in AUB");
                }
                else
                {
                    VliegtuigTicketPrijs = value;
                }
            }
        }
        //Prijs berekening met vliegtuig
        public override double BerekenPrijs()
        {
            var TotaalPrijsVliegtuig = base.BerekenPrijs() + VliegtuigTicketPrijs;
            return TotaalPrijsVliegtuig;
        }
    }
}
