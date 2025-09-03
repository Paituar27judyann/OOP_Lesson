using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_paituar
{
    internal class Student
    {
        // Properties
        public string Name { get; set; }
        public string Program { get; set; }

        // Method to display student info
        public void BasicInfo()
        {
            Console.WriteLine("\n\tStudent Information:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Program: " + Program);
        }
    }   
    class RegularStudent : Student         // Derived Class
    {
        //Properties for regular students
        public string Section { get; set; }

        // Method specific to Regular Student
        public void SectionEnrolled()
        {
            Console.WriteLine("Section: " + Section);
        }
    }
    class IrregularStudent : Student      // Derived Class
    {
        //Properties for irregular students
        public int UnitsEnrolled { get; set; }

        // Method specific to IrregularStudent
        public void EnrolledSemUnits()
        {
            Console.WriteLine("Units Enrolled: " + UnitsEnrolled);
        }
    }
}





