using System;
namespace Lessons
{
    public class Lesson11

    {
        public const int MY_VALUE = 25;

        /*method to demonstarte a constant which can not change its value */
        public void SampleLesson11()
        {
            const string today = "Wednsday";
            //MY_VALUE = 20; 
            // can not change the value 
            //but can use it with other variables

            int total = MY_VALUE * 2;
            Console.WriteLine(total);
            // can't change value of method level constant
            //today = "Friday";

        }
        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void UseParams2(params object[] items)//object is anything not a specific type
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void optionlalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " yearsold.");
        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
            // output=19

        }
        public void outSample(string name, out string firstName, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);

        }

    }
}