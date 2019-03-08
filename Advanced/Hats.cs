using System;
using System.Collections.Generic;
using System.Text;
using Advanced;

namespace Advanced
{
    public class Hats
    {
        public delegate void TryHat(string type);
        public string HatType { get; }
        public int HatSize { get; }

        public Hats()
        {
            TryHat myHat = TryOnHat;
            TryALargeHat("fadora", 7, myHat);
        }
        public Hats(int size)
        {
            this.HatSize = size;
        }

        public Hats(string type, int size)
        {
            this.HatSize = size;
            this.HatType = type;
        }
        // method

        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }
        public void TryALargeHat(string type, int oldsize, TryHat another)
        {
            another("I tries on a " + type + "hat at size " + (oldsize + 1).ToString());
        }
        public void FindLuckyHat(string message)
        {
            Console.WriteLine("Lucky the hat is {0}", message);

        }
        public void FindUglyHat(string message)
        {
            Console.WriteLine("ugly the hat is {0}", message);
        }

    }

}
