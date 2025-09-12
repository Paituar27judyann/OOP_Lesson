using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paituar_InheritanceWithUserInput
{
     class Shoes
    {
        // Public fields 
        public string Brand;
        public string Color;

        // Constructor
        public Shoes(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        // Virtual method to display base details
        public virtual void DisplayShoeInfo()
        {
            Console.WriteLine("\n\tShoe Details");
            Console.WriteLine("Shoe Brand: " + Brand);
            Console.WriteLine("Shoe Color: " + Color);
        }
    }

    // Derived class: RubberShoes
    class RubberShoes : Shoes
    {
        public int Price;
        public int YearRelease;

        public RubberShoes(string brand, string color, int price, int yearRelease)
            : base(brand, color)
        {
            Price = price;
            YearRelease = yearRelease;
        }

        public override void DisplayShoeInfo()
        {
            base.DisplayShoeInfo();
            Console.WriteLine("Rubber Shoe Price: " + Price);
            Console.WriteLine("Rubber Shoe Release Year: " + YearRelease);
        }
    }

    // Derived class: FormalShoes
    class FormalShoes : Shoes
    {
        public string Material;
        public string Occasion;

        public FormalShoes(string brand, string color, string material, string occasion)
            : base(brand, color)
        {
            Material = material;
            Occasion = occasion;
        }

        public override void DisplayShoeInfo()
        {
            base.DisplayShoeInfo();
            Console.WriteLine("Formal Shoe Material: " + Material);
            Console.WriteLine("Best Worn For: " + Occasion);
        }
    }
}

