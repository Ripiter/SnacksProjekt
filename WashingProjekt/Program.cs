using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Program
    {
        public  double moneyInput = 100;
        public static string chooseMenu;
        //whatSnack is userinput for what kind of snack he wants
        public string whatSnack;
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 to show all snack");
                Console.WriteLine("2 to add a snack");
                Console.WriteLine("3 to test snack");
                Console.WriteLine("4 add hardcoded snacks");
                Console.WriteLine("5 cancer the order");

                chooseMenu = Console.ReadLine();
                Menu();

                Console.ReadLine();
            }

        }

        static void Menu()
        {
            Automat automat = new Automat();
            AdminMenu admin = new AdminMenu();
            switch (chooseMenu)
            {
                case "1":
                    //shows all avaible snacks
                    automat.AvaibleSnacks();
                    break;
                case "2":
                    //adds snacks
                    admin.AddSnack();
                    break;
                case "3":
                    automat.CheckASnack();
                    break;
                case "4":
                    automat.HardCodeSnacks();
                    break;
                case "5":
                    automat.CancerOrder();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
                    
            }
        }
    }
}
