using System;
namespace ClassWork
{
    public class RanchStyle : House
    {
        public RanchStyle(string foundation, string window, string roof, string doorpiant)
        : base(foundation, window, roof, doorpiant)
        {
            Console.WriteLine("Ranch style constractor");
        }
        public RanchStyle(string foundation, string window)
        : base(foundation, window)
        {
            Console.WriteLine("Ranch style constractor");
        }
    }
}