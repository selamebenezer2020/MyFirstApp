using System;
namespace Quiz
{
    public class Formula


    {
        double Volatge, resistance, current;

        public void CalcVoltage()
        {
            resistance = 10;
            current = 5;
            Volatge = resistance * current;
            Console.WriteLine("voltage =" + Volatge);
        }

        public void calcresistance()
        {
            Volatge = 200;
            current = 45;
            Console.WriteLine("ressistance =" + Volatge / current);
        }
        public void calccurrent()
        {
            Volatge = 300;
            resistance = 12;
            Console.WriteLine("ressistance =" + Volatge / resistance);
        }


    }
}