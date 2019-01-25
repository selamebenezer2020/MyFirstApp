using System;
namespace Lessons
{
    public abstract class Dinosaur : IPrehistoric
    {
        public string Travel { get; set; } = "Walk"; // creating AutoProperty
        public abstract void EatFood();
        public abstract void sleep();

        public virtual void Move()
        {
            Console.WriteLine("The Dinosaur Moves");

        }

        public virtual void Die()
        {
            Console.WriteLine("The Dinosaur is Dying");
        }

        public abstract void skinType();
        public abstract void Teeth();
    }







}