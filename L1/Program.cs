using System;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the values");
            Console.WriteLine("Side 1");
            string input = Console.ReadLine();
            double a = Double.Parse(input);

            Console.WriteLine("Side 2");
            string input1 = Console.ReadLine();
            double b = Double.Parse(input1);

            Console.WriteLine("Side 3");
            string input2 = Console.ReadLine();
            double c = Double.Parse(input2);

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area of triangle is = {0}", +area);
            Console.ReadLine();
            
        }
    }
}
