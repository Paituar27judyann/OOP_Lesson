using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_InheritanceWith_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Section: IT 301
            //Exercise title: Simple Inheritance with Constructor

            // Object for Regular Student
            RegularStudent section = new RegularStudent("Student 1", "BSIT", "IT301");

            section.BasicInfo();          // Inherited method
            section.SectionEnrolled();    // Regular student specific method


            // Object for Irregular Student
            IrregularStudent unitsEnrolled = new IrregularStudent("Student 2", "BSIT", 18);

            unitsEnrolled.BasicInfo();         // Inherited method
            unitsEnrolled.EnrolledSemUnits();  // Irregular student specific method

            Console.ReadKey();
        }
    }
}
