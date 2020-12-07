using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class LogMessage
    {
        private string Boodschap;
        public int ID;

        //Constructor voor Logmessage
        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenerateID();
        }
        //Get and set van boodschap
        public string boodschap
        {
            get { return Boodschap; }
            set { Boodschap = value; }
        }
        //Method for generating Id
        public int GenerateID()
        {
            Random rnd = new Random();
            ID = rnd.Next(1, 8);
            return ID;
        }
    }
}
