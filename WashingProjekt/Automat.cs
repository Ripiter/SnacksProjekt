using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Automat
    {
        static Program prog = new Program();
        public static double moneyErnedToday;
        public double valueOfSnac;
        bool isEnough = false;
        public bool cancer = false;


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
        //if user did not put enough money return how much its missing

        /// <summary>
        /// Remove later
        public int i = 0;
        public int temp = -1;
        /// </summary>
        public void CheckASnack()
        {
            Console.WriteLine("name of snack");
            prog.whatSnack = Console.ReadLine().ToLower();

            bool isFound = false;
            foreach (Snack snack in Snack.Snac)
            {
                if (prog.whatSnack == snack.NameOfSnack)
                {
                    isFound = true;
                    //We put the price of the snac that user wants into the valueofscan
                    valueOfSnac = snack.PriceOfSnack;
                    temp = i;
                }
                i++;
            }

            if (isFound == true)
            {
                //Checks if the user put enough money to autmat
                CheckIfItsEnough();
                //CancerOrder ask user if he is sure that he wants to proccede
                //with action, there is no other chance
                CancerOrder();
                if (isEnough == true && cancer == false)
                {
                    ReturnRestOfMoney();
                    GiveUserSnack();
                }
                else
                {
                    Console.WriteLine("Not enough money or action canceled");
                    ReturnRestOfMoney();
                }
                ///also method for user to add to the money so they can try again
            }else
                Console.WriteLine("no snack with that name");
        }

        bool CheckIfItsEnough()
        {
            if (valueOfSnac <= prog.moneyInput)
                isEnough = true;

            return isEnough;
        }

        //Asks user if he wants to proccede with the order
        //if not user gets his money back
        public bool CancerOrder()
        {
            Console.WriteLine("Do you want to proccede?");
            string yesNo = Console.ReadLine().ToLower();

            if (yesNo != "yes")
                cancer = true;

            return cancer;
            //Check if user want to procced with order
        }
        void GiveUserSnack()
        {
            //remove snack from snack list
            Snack.Snac.RemoveAt(temp);
            Console.WriteLine("user got his snack");
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
            //if user canceled the valueofsnac goes to 0
            if (cancer == true)
                valueOfSnac = 0;

            double returnValue = prog.moneyInput - valueOfSnac;

            moneyErnedToday = moneyErnedToday + valueOfSnac;
            Console.WriteLine(returnValue);
            Console.WriteLine(moneyErnedToday);
            return returnValue;
        }
    }
}
