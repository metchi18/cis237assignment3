using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set a constant for the droid collection
            const int droidCollectionSize = 20;

            //Create instance of UserInterface class
            UserInterface UI = new UserInterface();

            //Create an instance of the DroidCollection class
            DroidCollection droidCollection = new DroidCollection(droidCollectionSize);

            //Display the menu and get the response. Store the response in the choice integer
            int choice = UI.DisplayMenuAndGetUserInput();

            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        //Begin process to create droid by displaying initial options menu
                        string[] newDroidInformation = UI.GetNewMaterialInformation();

                        {
                            droidCollection.AddNewItem(newDroidInformation[0], newDroidInformation[1], newDroidInformation[2]);
                            UI.DisplayAddDroidSuccess();
                        }

                        break;
                    case 2:
                        //Print List of Droids 
                        string[] allDroids = droidCollection.GetPrintStringForAllDroids();
                        if (allDroids.Length > 0)
                        {
                            //Display all of the Droids
                            UI.DisplayAllDroids(allDroids);
                        }
                        else
                        {
                            //Display error message for Droids
                            UI.DisplayAllDroidsError();
                        } 

                        break;
                }
            }

            if (choice == 3)
            {
                Environment.Exit(0);
            }
        }
    }
}
