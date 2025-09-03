using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_paituar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Judy Ann Paituar
            //Section: IT 301
            //Exercise title: Basic Inheritance

            // Object for Regular Student
            RegularStudent section = new RegularStudent();

            //Value for regular student child class
            section.Name = "Student 1";
            section.Program = "BSIT";
            section.Section = "IT301";

            section.BasicInfo();          // Inherit method
            section.SectionEnrolled();    // Regular students specific method


            // Object for Irregular Student
            IrregularStudent unitsEnrolled = new IrregularStudent();
            
            //Value for irregular student child class
            unitsEnrolled.Name = "Student 2";
            unitsEnrolled.Program = "BSIT";
            unitsEnrolled.UnitsEnrolled = 18;

            unitsEnrolled.BasicInfo();         // Inherit method
            unitsEnrolled.EnrolledSemUnits();  // irregular students specific method

            Console.ReadKey();
        }
    }
}
    

