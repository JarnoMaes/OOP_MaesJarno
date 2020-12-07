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

        Adress adressJarno = new Adress("Willebroek", "2", 2830, "Eggestraat");
        Persoon Jarno = new Persoon("Eggestraat 2, 2830 Willebroek", "Maes", "Jarno");
        Reisbureau TUI = new Reisbureau("Gistelsesteenweg 1, 8400 Oostende", "TUI");
        Autovakantie AutoJarno = new Autovakantie(false, new DateTime(2020, 12, 10), new DateTime(2020, 12, 15), 3);
        VliegtuigVakantie VliegJarno = new VliegtuigVakantie(110, new DateTime(2021, 01, 15), new DateTime(2021, 01, 25), 4);
        Cruise CruiseJarno = new Cruise(true, new DateTime(2021, 01, 10), new DateTime(2021, 02, 20), 10);

        Adress adressThomas = new Adress("Oostende", "18", 8400, "Oostendestraat");
        Persoon Thomas = new Persoon("Kleilaan 18, 8400 Oostende", "Kliko", "Thomas");
        Reisbureau Neckermann = new Reisbureau("Neckermannweg 12, 5200 Brugge", "Neckermann");
        Autovakantie AutoThomas = new Autovakantie(true, new DateTime(2020, 12, 18), new DateTime(2020, 12, 25), 4);
        VliegtuigVakantie VliegThomas = new VliegtuigVakantie(250, new DateTime(2021, 01, 10), new DateTime(2021, 02, 21), 5);
        Cruise CruiseThomas = new Cruise(false, new DateTime(2021, 01, 17), new DateTime(2021, 01, 28), 25);

        Adress adressLina = new Adress("Beernem", "850", 6500, "Beernmsestraat");
        Persoon Lina = new Persoon("Linastraat 707, 5000 Beernem", "Moeilijk", "Lina");
        Reisbureau Swiss = new Reisbureau("Swisseweg, 2050 Zoersel", "Swiss");
        Autovakantie AutoLina = new Autovakantie(false, new DateTime(2021, 05, 12), new DateTime(2021, 10, 12), 2);
        VliegtuigVakantie VliegLina = new VliegtuigVakantie(450, new DateTime(2021, 02, 05), new DateTime(2021, 02, 10), 10);
        Cruise CruiseLina = new Cruise(true, new DateTime(2021, 03, 08), new DateTime(2021, 03, 25), 5);

    }
}
