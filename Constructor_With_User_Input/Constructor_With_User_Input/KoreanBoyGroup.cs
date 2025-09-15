using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_With_User_Input
{
    internal class KoreanBoyGroup
    {
        // Fields
        public string name, agency;
        public int debutyear;

        // Method to display group info
        public void DisplayGroupInfo()
        {
            Console.WriteLine("\nGroup name: " + name + "\nAgency: " + agency + "\nYear Debuted: " + debutyear);
        }

        public KoreanBoyGroup(string name, string agency, int debutyear)
        {
            // Parameterized Constructor
            this.name = name;
            this.agency = agency;
            this.debutyear = debutyear;
        }
    }
}
