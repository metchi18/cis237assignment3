using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        //Private Variables
        Droid[] droidItems;
        int droidItemsLength;

        //Constructor. Must pass the size of the collection.

        public DroidCollection(int size)
        {
            droidItems = new Droid[size];
            droidItemsLength = 0;
        }

        //Add a new item to the collection
        public void AddNewItem(string material, string model, string color)
        {
            //Add a new WineItem to the collection. Increase the Length variable.
            droidItems[droidItemsLength] = new Droid(material, model, color);
            droidItemsLength++;
        }

        //Get The Print String Array For All Items
        public string[] GetPrintStringForAllDroids()
        {
            //Create and array to hold all of the printed strings
            string[] allItemStrings = new string[droidItemsLength];
            //set a counter to be used
            int counter = 0;

            //If the wineItemsLength is greater than 0, create the array of strings
            if (droidItemsLength > 0)
            {
                //For each item in the collection
                foreach (Droid droidItem in droidItems)
                {
                    //if the current item is not null.
                    if (droidItem != null)
                    {
                        //Add the results of calling ToString on the item to the string array.
                        allItemStrings[counter] = droidItem.ToString();
                        counter++;
                    }
                }
            }
            //Return the array of item strings
            return allItemStrings;
        }
    }

}
