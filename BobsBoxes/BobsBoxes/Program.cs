using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program will find the volumn of each box, and caculate the priced based on how many, and how big each box is. ");

            Console.WriteLine("What color boxs would you like?");
            string color = Convert.ToString(Console.ReadLine());

            Console.Write("Please enter the inner lenght in cm: ");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the inner witdh in cm: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the inner hight in cm: ");
            double hight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the thickness in mm: ");
            double thickness = Convert.ToDouble(Console.ReadLine());

            double InnerVolumn = lenght * width * hight;

            double OLength = lenght + thickness * 2;
            double OWidth = width + thickness * 2;
            double OHight = hight + thickness * 2;

            double OuterVolumn = OLength * OWidth * OHight;

            double Plastic = (OuterVolumn - InnerVolumn);

            Console.WriteLine("How many Boxs Would you like? ");
            double boxes = Convert.ToInt32(Console.ReadLine());

            double cost = .00025;

           double price = Plastic*cost;

            double total = price*boxes;
            
            Console.WriteLine("For {0} {1} boxes, it cost {2}$", boxes, color, total);

            











        }
    }
}
