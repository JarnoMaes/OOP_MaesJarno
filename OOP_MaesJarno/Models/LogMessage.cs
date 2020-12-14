using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public class LogMessage
    {
        public string Boodschap { get; private set; }
        public int ID { get; private set; }
        private static int _counter { get; set; }

        private int GenereedID()
        {
            _counter++;
            return _counter;
        }
        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenereedID();
        }
        public override string ToString()
        {
            return $"-----------------\nLogMessage: {ID} {Boodschap}";
        }
    }
}
