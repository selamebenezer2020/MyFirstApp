using System;
namespace Lessons
{
    public class StatmentExamples
    {
        public void SampleIf()
        {
            int num = 10;
            Console.WriteLine("Before If Statment");
            if (num > 9)
            {
                Console.WriteLine("if statment was valid");
            }
            Console.WriteLine("After If Statment");
        }

        public void SampleIfElse()
        {
            int value = 15;
            Console.WriteLine("Before If statment");
            if (value >= 15)
            {
                Console.WriteLine("if statment Excutes");
            }
            else
            {
                Console.WriteLine("Else statment execues");
            }
            Console.WriteLine("After if astatment");

        }

        public void SampleIfChain()
        {
            int num = 15;
            Console.WriteLine("Before If");
            if (num > 15)
            {
                Console.WriteLine("Else If excutes");
            }
            else if (num == 15)
            {
                Console.WriteLine("Else If excutes");
            }
            else
            {
                Console.WriteLine("Else Excutes");
            }
            Console.WriteLine("After If");
        }

        public void SampleIfAnd()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine("Before if");
            if (num1 < 20 && num2 > 19)
            {
                Console.WriteLine("if excutes");
            }
            else
            {
                Console.WriteLine("Else excutes");
            }
            Console.WriteLine("After If");
        }

        public void SampleIfOr()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine();
            if (num2 > 25 || num1 == 15)
            {
                Console.WriteLine("if excutes");
            }
            else
            {
                Console.WriteLine("else excutes");
            }
            Console.WriteLine("After If");

        }



        public void quizpractice()
        {
            int x = 5, y = 6;
            if (x != y || x > y)
            {
                Console.WriteLine("not equal");

            }
            else if (x > y)
            {
                Console.WriteLine("The number is greater");
            }
            else
            {
                Console.WriteLine("Correct");
            }
            Console.WriteLine("this line is excuted");


        }

        public void SampleConditional()
        {
            int num = 20;
            string word = (num < 25) ? "its less" : "its more";
            Console.WriteLine(word);
        }

        public void SampleSwitch(int num)
        {
            switch (num)
            {
                case 5:
                    Console.WriteLine("5 was choosen");
                    break;
                case 10:
                    Console.WriteLine("10 was choosen");
                    break;
                case 15:
                    Console.WriteLine("15 was choosen");
                    break;
                case 20:
                    Console.WriteLine("20 was choosen");
                    break;

                default:
                    Console.WriteLine("No correct number was choosen");
                    break;
            }
        }

        public void SampleWhile()
        {
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine("Number = {0}", num);
                num++;
            }
        }

        public void SampleDoWhile()
        {
            int num = 0;
            do
            {
                Console.WriteLine("Number = {0}", num);
                num++;
            } while (num < 10);
        }

        public void SampleFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number = {0}", i);
            }
        }

        public void SampleForEach()
        {
            foreach (char ch in "Kansas")
            {
                Console.WriteLine(ch);
            }
        }

        public string JumpStatmentExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    goto default;
                case "Monday":
                case "Tusday":
                    return "Test someting Tusday";
                default:
                    return "TestNothing";
            }
        }


        //put method

        public void SampleDays(DaysOfWeek days)

        {
            switch (days)
            {

                case DaysOfWeek.Fri:
                case DaysOfWeek.Sat:
                case DaysOfWeek.Sun:
                    Console.WriteLine("the Weekend is Here.");
                    break;
                case DaysOfWeek.Mon:
                case DaysOfWeek.Tus:
                case DaysOfWeek.Wen:
                case DaysOfWeek.Thur:

                    Console.WriteLine("Still at Work");
                    break;


            }




        }





    }
}