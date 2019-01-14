using System;
namespace Lessons
{
    public class Fruits//parent class
    {
        public virtual void EatFruit()
        {
            Console.WriteLine("I eat fruit");
            ThrowFruits();
        }
        //private is olny accesable from within the class
        private void ThrowFruits()
        {
            Console.WriteLine("Throughing fruits");

        }
    }
}