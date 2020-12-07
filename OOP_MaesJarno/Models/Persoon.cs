using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Persoon
    {
        private string Adress;
        private string FamilieNaam;        
        private string VoorNaam;
        public string VolledigeNaam;
        
        //Constructor voor Persoon.
        public Persoon(string adress, string familieNaam,string voorNaam)
        {
            Adress = adress;
            FamilieNaam = familieNaam;
            VoorNaam = voorNaam;
            VolledigeNaam = volledigeNaam;
        }
        //Get and set Adress
        public string adress
        {
            get { return Adress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter Adress");
                }
                else
                {
                    Adress = value;
                }
            }
        }
        //Get and set Familienaam
        public string familieNaam
        {
            get { return FamilieNaam; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter family name");
                }
                else
                {
                    FamilieNaam = value;
                }
            }
        }
        //Get and set voornaam
        public string voorNaam
        {
            get { return VoorNaam; }
            set
            {
                if (string.IsNullOrEmpty(VoorNaam))
                {
                    Console.WriteLine("Please enter sur name");
                }
                else
                {
                    VoorNaam = value;
                }
            }
        }
        //Get volledige naam
        public string volledigeNaam
        {
            get { return VoorNaam + "  " + FamilieNaam; } 
        }
    }
}
