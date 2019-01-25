using System;
namespace Lessons
{
    public class TRex : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex Eats");
        }
        public override void Move()
        {
            Console.WriteLine("TRex Runs");
        }

        public override void sleep()
        {
            Console.WriteLine("Trex Sleep");
        }
        public override void Die()
        {
            Console.WriteLine("TRex \n" + "is \n" + "Dying");

        }

        public override void skinType()
        {
            Console.WriteLine("Leathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Flat Teeth");
        }
    }
}