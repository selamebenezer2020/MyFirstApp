using System;
namespace Quiz
{
    public class FourKtv : Television
    {

        public void FourKtvs()
        {
            string model = "4ktv";
            Console.WriteLine("This is " + model);
            Getinfotv(2000, 60, 8);
            remote = "smartApp";
            mountanable = true;
            Kindremote();
            Console.WriteLine($"model{model}\nThe tv is Mountable.");
        }

        public override void Kindremote()
        {
            Console.WriteLine(remote);
        }
    }
}