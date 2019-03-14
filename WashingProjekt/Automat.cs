using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Automat
    {
        public static Program prog = new Program();
        static List<string> snacs = new List<string>();

        double moneyReturned;
        public double moneyErnedToday;
        bool cancelProduct;
        public double valueOfSnac;
        bool isEnough = false;


        public void AvaibleSnacks()
        {
                string snackInfo;
                foreach (Snack snack in Snack.Snac)
                {
                    snackInfo = "name of snack " + snack.NameOfSnack + ", price " + snack.PriceOfSnack;
                    Console.WriteLine(snackInfo);
                }

        }

        //Checks if there is a snack that users wants
        //if the snack is found, it checks if user put enough money
        public void CheckASnack()
        {
            Console.WriteLine("what snack");
            Program.whatSnack = Console.ReadLine();

            bool isFound = false;
            foreach (Snack snack in Snack.Snac)
            {
                if (Program.whatSnack == snack.NameOfSnack)
                {
                    isFound = true;
                    valueOfSnac = snack.PriceOfSnack;
                }
            }

            if (isFound == true)
            {
                CheckIfItsEnough();
                if(isEnough == true)
                    ReturnRestOfMoney();
                else
                    Console.WriteLine("Not enough money");
            }else
                Console.WriteLine("no snack");
        }

        bool CheckIfItsEnough()
        {
            if (valueOfSnac <= Program.moneyInput)
                isEnough = true;

            return isEnough;
        }

        void CancerOrder()
        {
            //Check if user want to procced with order
        }
        void GiveUserSnack()
        {
            //remove snack from snack list
        }
        public void HardCodeSnacks()
        {
            Snack charmander = new Snack("charmander", 15);
            Snack pikachu = new Snack("pikachu", 20);
            Snack squirtle = new Snack("squirtle", 10);
            Snack bulbasaur = new Snack("bulbasaur", 5);
        }
        double ReturnRestOfMoney()
        {
            double returnValue = Program.moneyInput - valueOfSnac;

            Console.WriteLine(returnValue);
            return returnValue;
        }
    }
}
