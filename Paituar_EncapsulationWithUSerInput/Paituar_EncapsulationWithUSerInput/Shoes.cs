using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_EncapsulationWithUSerInput
{
    internal class Shoes
    {
        //Declare private fields
        private string brand;
        private string model;

        //Public properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        //Method to display shoe Information
        public void DisplayShoeInfo()
        {
            Console.WriteLine("\n\tShoe Details");
            Console.WriteLine("Shoe Brand: " + brand);
            Console.WriteLine("Shoe Model: " + model);

        }

    }
}
