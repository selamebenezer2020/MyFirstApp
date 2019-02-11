using System;
namespace Quiz
{
    public abstract class Television
    {
        public double price { get; set; }
        public int size { get; set; }
        public int ports { get; set; }
        public bool mountanable { get; set; }
        public string remote { get; set; }




        public void Getinfotv(double price, int size, int ports)
        {
            Console.WriteLine($"{price}  {size}  {ports}");

        }


        public abstract void Kindremote();





    }



}








