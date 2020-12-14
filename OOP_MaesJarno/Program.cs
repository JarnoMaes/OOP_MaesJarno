using OOP_MaesJarno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno
{
    class Program
    {
        Adress AJarno = new Adress() 
        { 
            Gemeente = "Willebroek",
            HuisNmr = "2", 
            PostCode = 2830, 
            Straat = "Eggestraat" 
        };

        Adress AJordy = new Adress
        {
            Gemeente = "Willebroek",
            HuisNmr = "21",
            PostCode = 2830,
            Straat = "Breendonksesteenweg"
        };

        Adress AErwin = new Adress()
        {
            Gemeente = "Gent",
            HuisNmr = "250",
            PostCode = 9000,
            Straat = "Gentsesteenweg"
        };
        Adress ANeckermann = new Adress()
        {
            Gemeente = "Mechelen",
            HuisNmr = "560",
            PostCode = 2800,
            Straat = "Mechelsesteenweg"
        };
        Adress ATUI = new Adress()
        {
            Gemeente = "Wijnegem",
            HuisNmr = "1",
            PostCode = 3400,
            Straat = "Wijnegemsestraat"
        };

        Persoon Jarno = new Persoon()
        {
            VoorNaam = "Jarno",
            FamilieNaam = "Maes",
            //Adress = Ajarno
        };
        Persoon Jordy = new Persoon() 
        {
            VoorNaam = "Jordy",
            FamilieNaam = "Maes",
            //Adress = AJordy 
        };
        Persoon Erwin = new Persoon() 
        { 
            VoorNaam = "Erwin",
            FamilieNaam = "Naegels",
            //Adress = AErwin
        };
        Reisbureau TUI = new Reisbureau() 
        { 
            //Adress = ATUI,
            Naam = "TUI" 
        };
        Reisbureau Neckermann = new Reisbureau() 
        { 
            //Adress = ANeckermann,
            Naam = "Neckermann" 
        };
               
        Autovakantie VakantieJarno = new Autovakantie(true,new DateTime(2020,15,12),new DateTime(2020,20,12),5);
        VliegtuigVakantie VakantieJordy = new VliegtuigVakantie(250,new DateTime(2020,20,12),new DateTime(2020,30,12),3);        
        Cruise VakantieErwin = new Cruise(true,new DateTime(2021,15,01),new DateTime(2021,25,01),10);

        ReisReservatie ReservatieJarno = new ReisReservatie(Jarno, VakantieJarno, TUI);      
        ReisReservatie ReservatieJordy = new ReisReservatie(Jordy, VakantieJordy, Neckermann);       
        ReisReservatie reservatieErwin = new ReisReservatie(Erwin, VakantieErwin,TUI);

    }
}
