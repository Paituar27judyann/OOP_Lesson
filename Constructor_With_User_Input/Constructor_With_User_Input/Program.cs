using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_With_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Name: Judy Ann Paituar
            //Section: IT301
            //Exercise: User Input with Constructor


            // Ask user for the first group's details
            Console.WriteLine("Enter details for the first K-pop group:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Agency: ");
            string agency1 = Console.ReadLine();
            Console.Write("Debut Year: ");
            int year1 = int.Parse(Console.ReadLine());


            // Ask user for the second group's details
            Console.WriteLine("\nEnter details for the second K-pop group:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Agency: ");
            string agency2 = Console.ReadLine();
            Console.Write("Debut Year: ");
            int year2 = int.Parse(Console.ReadLine());


            // Display information of both groups
            Console.WriteLine("\n--- Group Details ---");

            // instantiate an object for the first group using parameterized constructor
            KoreanBoyGroup group1 = new KoreanBoyGroup("Exo", "SM Entertainment", 2012);
            group1.DisplayGroupInfo();

            //instantiate an object for the first group   using parameterized constructor
            KoreanBoyGroup group2 = new KoreanBoyGroup("BTS", "Big Hit Entertainment", 2013);
            group2.DisplayGroupInfo();

            Console.ReadKey();
        }
    }
}
