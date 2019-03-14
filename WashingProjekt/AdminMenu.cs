using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class AdminMenu
    {
        public string nameOfSnack;
        public double priceOfSnack;
        public void AddSnack()
        {
            try
            {
                Console.WriteLine("Write name of snack");
                nameOfSnack = Console.ReadLine();
                Console.WriteLine("Write price of snack");
                priceOfSnack = double.Parse(Console.ReadLine());
                Snack newSnack = new Snack(nameOfSnack, priceOfSnack);
            }
            catch
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
