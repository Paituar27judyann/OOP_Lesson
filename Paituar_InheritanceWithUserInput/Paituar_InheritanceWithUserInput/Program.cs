using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_InheritanceWithUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Section: IT 301
            //Exercise title: Inheritance with User Input

            // Ask user Input
            Console.Write("Enter rubber shoe Brand: ");
            string rBrand = Console.ReadLine();

            Console.Write("Enter rubber shoe Color: ");
            string rColor = Console.ReadLine();

            Console.Write("Enter rubber shoe Price: ");
            int rPrice = int.Parse(Console.ReadLine());

            Console.Write("Enter rubber shoe Release Year: ");
            int rYear = int.Parse(Console.ReadLine());

            // Create RubberShoes object
            RubberShoes rubberShoes = new RubberShoes(rBrand, rColor, rPrice, rYear);
            rubberShoes.DisplayShoeInfo();

            Console.WriteLine("\n-----------------------------------\n");

            Console.Write("Enter formal shoe Brand: ");
            string fBrand = Console.ReadLine();

            Console.Write("Enter formal shoe Color: ");
            string fColor = Console.ReadLine();

            Console.Write("Enter formal shoe Material: ");
            string fMaterial = Console.ReadLine();

            Console.Write("Enter formal shoe Occasion: ");
            string fOccasion = Console.ReadLine();

            // Create FormalShoes object
            FormalShoes formalShoes = new FormalShoes(fBrand, fColor, fMaterial, fOccasion);
            formalShoes.DisplayShoeInfo();

            Console.ReadKey();
        }
    }
}
