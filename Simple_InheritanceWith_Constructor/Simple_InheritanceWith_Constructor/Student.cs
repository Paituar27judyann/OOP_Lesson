using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_InheritanceWith_Constructor
{
    internal class Student  // Base class
    {

        // Variables (fields)
        public string name;
        public string program;

        // Constructor
        public Student(string nName, string nProgram)
        {
            this.name = nName;
            this.program = nProgram;
        }

        // Method to display student info
        public void BasicInfo()
        {
            Console.WriteLine("\n\tStudent Information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Program: " + program);
        }
    }

    class RegularStudent : Student   // Derived Class
    {
        // Variable for regular students
        public string section;

        // Constructor of derived class with base class call
        public RegularStudent(string name, string program, string section)
            : base(name, program)
        {
            this.section = section;
        }

        // Method specific to Regular Student
        public void SectionEnrolled()
        {
            Console.WriteLine("Section: " + section);
        }
    }

    class IrregularStudent : Student   // Derived Class
    {
        // Variable for irregular students
        public int unitsEnrolled;

        // Constructor of derived class with base class call
        public IrregularStudent(string name, string program, int unitsEnrolled)
            : base(name, program)
        {
            this.unitsEnrolled = unitsEnrolled;
        }

        // Method specific to Irregular Student
        public void EnrolledSemUnits()
        {
            Console.WriteLine("Units Enrolled: " + unitsEnrolled);
        }
    }
}
