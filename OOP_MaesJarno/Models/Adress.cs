using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Adress
    {
        private string Gemeente;
        private string HuisNmr;
        private int PostCode;
        private string Straat;

        //Constructor voor Adress
        public Adress(string gemeente, string huisNmr,int postCode, string straat)
        {
            Gemeente = gemeente;
            HuisNmr = huisNmr;
            PostCode = postCode;
            Straat = straat;
        }
        //Get and set Gemeente
        public string gemeente
        {
            get { return Gemeente; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Please enter Gemeente");
                }
                else
                {
                    Gemeente = value;
                }
            }
        }
        //Get and set Huis Nummer
        public string huisNmr
        {
            get { return HuisNmr; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter Huis nummer");
                }
                else
                {
                    HuisNmr = value;
                }
            }
        }
        //Get and set PostCode
        public int postCode
        {
            get { return PostCode; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Enter right Post code");
                }
                else
                {
                    PostCode = value;
                }
            }

        }
        //Get and set Straat
        public string straat
        {
            get { return Straat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter Straat");
                }
                else
                {
                    Straat = value;
                }
            }
        }

    }
}
