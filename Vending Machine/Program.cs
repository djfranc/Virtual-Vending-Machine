using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Title: Change Return Program




namespace Vending_Machine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// //Title: Change Return Program

        //Difficulty: 2
        //Description: Create a program where it shows the user a list of items to buy and their price.Then ask the user to pick an item and 
        //enter in the amount of money they would have inserted into the “vending machine”. Have the program calculate the change and 
        //return it to the user in the form of quarters, dimes, nickels and pennies.For example, if the user chooses an item that
        //costs $1.25 and they say they give it $2.07 the program would print out 3 quarters, 1 nickel and 2 pennies as change for the user.

        //Tips: First find out the difference between the item they bought and how much they are paying.Then look at using 
        //integer division to first calculate how many coins of each type to return. Then use the modulus(% operator in most languages) 
        //to determine the remainder of the change and repeat the process for each denomination.Be sure to check that the money they have 
        //inserted will first cover the price of the item! For example 89 cents / 25 is 3. This means 3 quarters with 14 cents returned.

        //Added Difficulty: Create a menu system where the user can quickly select the item they wish to buy. You can also take it a 
        //step further and create a full graphic user interface (GUI) showing the front of a vending machine where they can press buttons 
        //to specify which item they want or the amount they entered.

        ///
        /// Problem Approach:
        /// Steps: 
        /// 1. Create Slots for a vending machine for items to sell. (quantity is fixed).
        /// 2. Allow vending machine to recognize and initialize the cost as the vending machine starts up.
        /// 3. Allow for the user to place coins in the vending machine.
        /// 4. Vending machine should show cost and money currently held.
        /// 5. Vending machine should be able to give back change efficienty.
        /// 6. Vending machine should allow for purchases.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Form1 frm1 = new Form1();
            
           
            Application.Run(frm1);
            
        }
    }
}
