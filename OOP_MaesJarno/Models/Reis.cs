using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public abstract class Reis
    {
        private const double BasisDagPrijs = 40;

        public int AantalDagen { get; set; }
        public int AantalPersonen { get; set; }
        private DateTime TerugKeerDatum;
        private DateTime VertrekDatum;

        public Reis(DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen)
        {
            VertrekDatum = vertrekDatum;
            TerugKeerDatum = terugKeerDatum;
            AantalPersonen = aantalPersonen;

        }
        // Vertrek Datum Verkrijgen
        public DateTime vertrekDatum
        {
            get { return VertrekDatum; }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Vertrek Datum kan niet in het verleden liggen");
                }
                else if (value > TerugKeerDatum)
                {
                    Console.WriteLine("Vertrek datum kan niet later dan terugkeer datum liggen");
                }
                else
                {
                    VertrekDatum = value;
                }
            }
        }
        //TerugKeerDatum verkrijgen
        public DateTime terugKeerDatum
        {
            get { return TerugKeerDatum; }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Terug keer datum kan niet in het verleden liggen");
                }
                else if (value < VertrekDatum)
                {
                    Console.WriteLine("Terug keer datum moet na vertrek datum komen");
                }
                else
                {
                    TerugKeerDatum = value;
                }
            }
        }
        //Aantal Dagen Verkrijgen
        public int aantalDagen
        {
            get { return AantalDagen = (int)(TerugKeerDatum - VertrekDatum).TotalDays; }            
        }
        //Aantal Personen Verkrijgen
        public int aantalPersonen
        {
            get { return AantalPersonen; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Geef een geldig aantal personen in");
                }
                else
                {
                    AantalPersonen = value;
                }
            }
        }
        //Berekening van de prijs
        public virtual double BerekenPrijs()
        {
            var TotaalPrijs = AantalDagen * BasisDagPrijs * AantalPersonen;
            return TotaalPrijs;
        }
        public override string ToString()
        {
            return $"Aantal personen: {AantalPersonen}\nAantal Dagen: {AantalDagen}\nVertrek Datum: {VertrekDatum.Day}{VertrekDatum.Month}{VertrekDatum.Year}" +
                $"\nTerugkeer Datum: {TerugKeerDatum.Day}{TerugKeerDatum.Month}{TerugKeerDatum.Year}\nTotaal Prijs: {BerekenPrijs()} EURO";


        }
    }
}
