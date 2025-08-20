using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_BasicOnEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Section: IT 301
            //Exercise title: Basics on Encapsulation

            //Intantiate an Object 
            Shoes shoe1 = new Shoes();

            //Use encapsulated properties to assign value for fields
            shoe1.Brand = "Nike";
            shoe1.Model = "Air Max series ";

            //Call Method to display shoe Details
            shoe1.DisplayShoeInfo();
        }
    }
}
