using System;

namespace Lessons
{
    public class Utilities
    {
        static int temMultiplier = 32;

        public static double CelsiusToFahrenheit(string temperature)
        {
            double celsius = Double.Parse(temperature);
            double fahrenheit = (celsius * 9 / 5) + temMultiplier;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(string temperature)
        {
            double fahrenheit = Double.Parse(temperature);
            double celsius = (fahrenheit - temMultiplier) * 5 / 9;
            return celsius;
        }

        public abstract class Dinosaur
        {
            public abstract void EatFood();
            public virtual void Move()
            {
                Console.WriteLine("Dinos move");
            }
        }

        public class TRex : Dinosaur
        {
            public override void EatFood()
            {
                Console.WriteLine("Dinos eat");
            }
            public override void Move()
            {
                Console.WriteLine("TRex runs");
            }

        }

    }
}