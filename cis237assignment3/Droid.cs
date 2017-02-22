using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    //This is the abstract class which will give more functionality to the subclasses.
    abstract class Droid : IDroid
    {
        //Variables
        string material;
        string model;
        string color;
        decimal baseCost;
        decimal totalCost;

        //Constructor
        public Droid(string material, string model, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }
        decimal IDroid.TotalCost
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void CaluclateTotalCost()
        {
            
        }

        public void TotalCost()
        {
            //do something
        }

        public void CalculateBaseCost()
        {
            throw new NotImplementedException();
        }

    }
}
