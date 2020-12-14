using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Adress
    {
        public string Gemeente { get; set; }
        public string HuisNmr { get; set;}
        public int PostCode { get; set; }
        public string Straat { get; set; }

        //Constructor voor Adress
        public Adress(string gemeente, string huisNmr, int postCode, string straat)
        {
            Gemeente = gemeente;
            HuisNmr = huisNmr;
            PostCode = postCode;
            Straat = straat;
        }
        public Adress()
        {
        }
    }
}
