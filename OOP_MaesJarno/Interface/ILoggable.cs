using OOP_MaesJarno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Interface
{
    public interface ILoggable
    {  
        LogMessage LogMessage { get; } //Readonly
    }
}
