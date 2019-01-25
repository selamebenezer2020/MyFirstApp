using System;
using Lessons;
using Quiz;

/*This namespace represents the file folder that the class is in
{
    
} represent the file folder */

//class is a blueprint of an object.
// Action is shoud have only one perspective

namespace ClassWork
/*point to namespace */

{
    class Program
    //class is a blueprint 
    {
        static void Main(string[] args)


        {


            //Console.WriteLine("Hello World!");
            /*console is a class and writeline is method needs parameter ()
               and should be in parameter  */

            //Console.WriteLine("Hello World!");

            //created object instance of house called my house

            //House myHouse = new House();
            //myHouse.paintDoor = "Red";
            //myHouse.CloseDoor();// the door closes
            //this get the value of red from the object

            //Console.WriteLine(myHouse.paintDoor); // red
            //this is a second object instance of house.

            //House mySecondHouse = new House();
            //mySecondHouse.paintDoor = "green";
            //Console.WriteLine(mySecondHouse.paintDoor); //green
            //Console.WriteLine(myHouse.paintDoor);// red
            // MycarResuilt();
            //MyNumericExamples();
            //MyStringExamples();
            //StatmentSamples();
            //HouseSample();
            //StructSample();
            //Graderesult();
            //FruitsSample();
            //ParamsSample();
            //ModifierExample();
            //Lesson12();
            //AbstractDemo();
            //DeconstractSample();
            //FinalizerSample();
            //IndexerSample();
            PartialSample();





        }
        static void PartialSample()
        {
            Pear pear = new Pear("Yellow");

        }
        static void IndexerSample()
        {
            IndexerExample indexerExample = new IndexerExample();
            indexerExample[2] = 250;
            for (int i = 0; i < indexerExample.Length; i++)
                Console.WriteLine("Value {0} = {1}", i, indexerExample[i]);

        }

        static void FinalizerSample()
        {
            FinalizerExample finalExam = new
            FinalizerExample("Jhon", "Doe");
        }
        static void DeconstractSample()
        {
            string first = "Tom", last = "Jones";

            Lesson13 lesson13 = new Lesson13("Jhon", "Doe");
            Console.WriteLine("First Name = {0} and LastName = {1}", first, last);

            lesson13.Deconstruct(out first, out last);
            Console.WriteLine("First Name = {0} and Last Name = {1}", first, last);


        }
        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();


































            trex.EatFood();
            trex.Move();
            trex.skinType();
            trex.Teeth();
            trex.Die();
            triceratops.EatFood();
            triceratops.Move();
            triceratops.Teeth();
            triceratops.skinType();

            triceratops.Die();
            triceratops.sleep();
            triceratops.Teeth();
            triceratops.skinType();






        }

        static void Lesson12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            Console.WriteLine(temp);
            double temp2 = Utilities.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp2);

        }
        static void ModifierExample()
        {
            int test = 14;
            Lesson11 myLesson = new Lesson11();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);
            string first, second;//this is method for outsample
            myLesson.outSample("Jhon Doe", out first, out second);
            Console.WriteLine(first);
            Console.WriteLine(second);


        }


        static void ParamsSample()
        {
            Lesson11 lesson = new Lesson11();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams();

            int[] intArray = { 2, 3, 4, 5, 6, };
            lesson.UseParams(intArray);

            lesson.UseParams2(1, "Happy", false, 34.5F);

            lesson.optionlalParam("selam");
            lesson.optionlalParam("selam", 19);

        }

        static void FruitsSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();


            Fruits myFruits = new Apple();
            myFruits.EatFruit();

            Orange myOrange = new Orange(); //object instance of orange
            myOrange.EatFruit();
            RanchStyle ranch = new RanchStyle("Stone", "Triple pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);


        }

        static void StructSample()
        {

            BookSample bookSample = new BookSample(5.99m, "Zombie Fallout", "Mark Tufo");

            Console.WriteLine(" The book " + bookSample.title + " by " + bookSample.author +
            " is $" + bookSample.price);
        }

        static void HouseSample()
        {
            House myHouse = new House("Concret", "triple pane");
            Console.WriteLine(myHouse.paintDoor);
            Console.WriteLine(myHouse.Foundation);


        }



        static void StatmentSamples()
        {


            StatmentExamples se = new StatmentExamples();


            //se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(10);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.SampleForEach();
            //string mystring = se.JumpStatmentExample("Sunday");
            //Console.WriteLine(mystring);
            // BottlesSong();
            se.SampleDays(DaysOfWeek.Wen);
            Graderesult();





        }

        static void BottlesSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);

        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample
            ("Hello", "C  Sharp", "class");

            Console.WriteLine(words);
            myTypes.charTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceHolderExample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
        }

        static void MyNumericExamples()

        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();
            int something = myTypes.convertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();
            myTypes.CheckedOperators();
            myTypes.IncrementDecrement();
            myTypes.SpecialValue();
            myTypes.ComparisonOperators();


        }

        static void OtherNumbericExamples()
        {
            NumericTypes myTypes = new NumericTypes();//deafaltconstaractor
            myTypes.otherOperator();
        }

        public static void Graderesult()
        {
            QuizClass1 myGrade = new QuizClass1();
            string description = myGrade.GradeResult("E");
            Console.WriteLine(description);
            myGrade.ForTest();

        }


        static void quizpractice()
        {
            StatmentExamples myquizpractice = new StatmentExamples();
            myquizpractice.quizpractice();

        }

        static void MycarResuilt()
        {
            CarInACarRentalApplication my = new CarInACarRentalApplication();
            my.Name = "Selam";

            Console.WriteLine(my.Name);

        }

        public void DaysOfWeek1(int day)
        {
            int DaysOfWeek1 = day;
            if (DaysOfWeek1 == 1)
                Console.WriteLine("Sunday");
            else if (DaysOfWeek1 == 2)
                Console.WriteLine("Monday");
            else
            {
                Console.WriteLine("Tusday");
            }
        }
        public void Eodd()
        {
            int num1 = 5, num2 = 5;

            if (num1 == num2)
            {
                Console.WriteLine("the number is odd");
            }

            else
            {
                Console.WriteLine("the number is even");
            }
        }



    }




}








