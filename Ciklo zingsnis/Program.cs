using System;

namespace Ciklo_zingsnis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UniversalCalculator calculator = new UniversalCalculator();
            decimal area = calculator.GetEarthArea();
            Console.WriteLine(area);
        }
    }
}
