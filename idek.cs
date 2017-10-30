using System;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("TextFile1.txt");

            string line1 = reader.ReadLine();
            string line2 = reader.ReadLine();
            string line3 = reader.ReadLine();
            string line4 = reader.ReadLine();
            string line5 = reader.ReadLine();
        

        }
    }
}
