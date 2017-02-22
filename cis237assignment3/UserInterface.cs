using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        const int maxMenuChoice = 3;
        int droidLength;
        Droid[] droidItems;


        //Methods
    
        public int DisplayMenuAndGetUserInput()
        {
            //Print out the menu
            this.PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid, re-get the input
            while (input != "1" && input != "2" && input != "3")
            {
                //Print error message
                this.PrintErrorMessage();

                //Re-print the menu
                this.PrintMenu();
                this.DisplayPrompt();
                //Get the input from te console again.
                input = Console.ReadLine();
            }

            //If input is a valid entry, proceed
            return Int32.Parse(input);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Make a Droid");
            Console.WriteLine("2. Print Current List of Droids");
            Console.WriteLine("3. Exit");

        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        private void DisplayPrompt()
        {
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
        }

        public void DisplayAllDroidsError()
        {
            Console.WriteLine();
            Console.WriteLine("There are no items in the list to print");
        }



        public void DisplayAllDroids(string[] allItemsOutput)
        {
            Console.WriteLine();
            foreach (string itemOutput in allItemsOutput)
            {
                Console.WriteLine(itemOutput);
            }
        }

        //Display Add Droid Success
        public void DisplayAddDroidSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("The Item was successfully added");
        }

        //Display menu to get information on new droid
        public string[] GetNewMaterialInformation()
        {
            Console.WriteLine();
            Console.WriteLine("What material would you like to make your Droid from?");
            Console.WriteLine("1. Plastic - $50");
            Console.WriteLine("2. Metal - $100");
            Console.WriteLine("3. Glass - $120");
            Console.WriteLine("4. Cancel");
            Console.Write("> ");
            string material = Console.ReadLine();
            Console.WriteLine("What Droid model would you like?");
            Console.WriteLine("1. Utility - ADD $20");
            Console.WriteLine("2. Protocol - ADD $30");
            Console.WriteLine("3. Janitor - ADD $40");
            Console.WriteLine("4. Astromech - ADD $50");
            Console.Write("> ");
            string model = Console.ReadLine();
            Console.WriteLine("Which color would you prefer your Droid to be?");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Green");
            Console.WriteLine("4. Yellow");
            Console.Write("> ");
            string color = Console.ReadLine();

            return new string[] { material, model, color };
        }

    }
}
