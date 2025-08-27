using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_EncapsulationWithUSerInput
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

            //Ask User Input
            Console.Write("Enter shoe Brand: ");
            shoe1.Brand = Console.ReadLine();

            Console.Write("Enter shoe Model: ");
            shoe1.Model = Console.ReadLine();

            //Call Method to display shoe Details
            shoe1.DisplayShoeInfo();

            Console.ReadKey();

        }
    }
}
