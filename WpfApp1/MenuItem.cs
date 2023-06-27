using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MenuItem
    {
        public static Random Randomizer = new Random();
        public string[] Proteins = new string[] {"Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu"};
        public string[] Bread = { "rye", "white", "wheat", "pumpernickel", "a roll" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish",
            "french dressing" };
        public string Description = "";
        public string Price;

        public void Generate()
        {
            string RandomProteins = Proteins[Randomizer.Next(Proteins.Length)];
            string RandomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string RandomBread = Bread[Randomizer.Next(Bread.Length)];

            Description = RandomProteins + " with " + RandomCondiments + " on " + RandomBread;

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = (bucks + (cents * 0.1M));
            Price = price.ToString("c");
        }
    }
}
