using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Persoon
    {
        public Adress Adress { get; set; }
        public string FamilieNaam { get; set; }
        public string VoorNaam { get; set; }
        public string VolledigeNaam
        {
            get
            {
                return $"{FamilieNaam} {VoorNaam}";
            }    
        }    
    }
}
