using System;
using Lessons;
namespace Quiz
{

    public class Conversion

    {
        public enum Convert { centimeter, inch, meter, yard, milimeter };

        public void Metric(double value, Convert convert)
        {

            switch (convert)

            {
                case Convert.centimeter:
                    double total = value * 304.8;
                    Console.WriteLine(total + "centemter");
                    break;

                case Convert.inch:
                    double total1 = value * 12;
                    Console.WriteLine(total1 + "inch");
                    break;

                case Convert.meter:
                    double total2 = value * 0.3048;
                    Console.WriteLine(total2 + "meter");
                    break;

                case Convert.yard:
                    double total3 = value * 0.33333333333;
                    Console.WriteLine(total3 + "yards");
                    break;

                case Convert.milimeter:
                    double Total4 = value * 304.8;
                    Console.WriteLine(Total4 + "milimeter");
                    break;

                default:
                    Console.WriteLine("Unknown value");
                    break;

            }
        }
    }


}