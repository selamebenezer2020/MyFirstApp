using System;
namespace Quiz

{
    public struct TvStruct
    {
        public string Letter;
        public double price;
        public int size;
        public int ports;
        public bool mountanable;
        public string remote;
        public string fullname;

        public void TvDemo(double price, int size, int ports, bool mountable, string remote)
        {
            this.price = price;
            this.size = size;
            this.ports = ports;
            this.mountanable = mountable;
            this.remote = remote;
            Console.WriteLine($"{price} , {size}, {ports},{mountable}, {remote}");
        }


        public void LetterOrder()

        {

            string Letter1 = "a";
            string Letter2 = "b";
            String Letter3 = "c";
            Console.WriteLine($"letter order is {Letter3},{Letter2},{Letter1}");
        }
        public void Calwidth()
        {
            for (int i = 0; i <= 5; i++) ;
        }

        public void Writingname()
        {
            Console.WriteLine("my name is Selamawit Ebenezer" + fullname);
        }
    }
}