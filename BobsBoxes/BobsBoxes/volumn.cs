using System;

namespace VolumnCaculater
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("This program calculates the volumn of a box.");

            Console.Write("Please enter the lenght in cm: ");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the witdh in cm: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the hight in cm: ");
            double hight = Convert.ToDouble(Console.ReadLine());

            double volumn = lenght * width * hight; 

            Console.Write("The volumn of a {0} cm x {1} cm x {2} cm box is {3} cubic centimeters.:)",
                lenght, width, hight, volumn);

        }
    }
}
