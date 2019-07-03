using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysofweek
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\batuhan.celebi\source\repos\daysofweek\daysofweek\PopByLarge.csv";

            CsvReadr reader = new CsvReadr(filePath);


            List<Country> countries = reader.ReadAllCountries();
            Country trabzon = new Country("Trabzon", "TZX", "Somewhere", 2_000_000);
            int trabzonIndex = countries.FindIndex(x=>x.Population < 2_000_000);
            countries.Insert(trabzonIndex, trabzon);
            countries.RemoveAt(trabzonIndex);
            Console.WriteLine($"Enter country name: ");
            string ulke = Console.ReadLine();
            Console.WriteLine($"Enter country code: ");
            string ukod= Console.ReadLine();
            Console.WriteLine($"Enter country region: ");
            string bolge = Console.ReadLine();
            Console.WriteLine($"Enter country population: ");
            int nufus = Convert.ToInt32(Console.ReadLine());
            Country newc = new Country(ulke, ukod , bolge , nufus);
            int newcindex = countries.FindIndex(x => x.Population < 2_000_000);
            countries.Insert(newcindex, newc);

            Console.WriteLine("Do u want a see TOP10 country with most population? '1' FOR YES '0' FOR NO");
            int secenek = Convert.ToInt32(Console.ReadLine());
            if (secenek == 1)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
                }
                Console.WriteLine($"{countries.Count} countries ");
            }
            else
            {
                return;
            }

           

        }
    }
}
