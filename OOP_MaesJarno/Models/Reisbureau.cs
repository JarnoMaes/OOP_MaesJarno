using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class Reisbureau
    {
        private string Adress;
        private string Name;

        //Constructor voor Reisbureu
        public Reisbureau(string adress,string name)
        {
            Adress = adress;
            Name = name;
        }
        //Get and Set for Adress
        public string adress
        {
            get { return Adress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please fill in the adress");
                }
                else
                {
                    Adress = value;
                }
            }
        }
        //Get and Set for Name
        public string name
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please fill in your name");
                }
                else
                {
                    Name = value;
                }
            }
        }
    }
}
