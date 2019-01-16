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
        public string spoil { get; set; }
        public void FruitsSpoil(string blend, string spoil, string bake)
        {
            Console.WriteLine("The frits can not be eaten");
        }
    }
}