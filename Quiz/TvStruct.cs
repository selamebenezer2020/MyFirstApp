using System;
namespace Quiz
{
    public struct TvStruct
    {
        public double price;
        public int size;
        public int ports;
        public bool mountanable;
        public string remote;

        public void TvDemo(double price, int size, int ports, bool mountable, string remote)
        {
            this.price = price;
            this.size = size;
            this.ports = ports;
            this.mountanable = mountable;
            this.remote = remote;
            Console.WriteLine($"{price} , {size}, {ports},{mountable}, {remote}");
        }

    }
}