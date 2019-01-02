using System;
using Lessons;

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


            Console.WriteLine("Hello World!");
            /*console is a class and writeline is method needs parameter ()
               and should be in parameter  */

            Console.WriteLine("Hello World!");

            //created object instance of house called my house

            House myHouse = new House();
            myHouse.paintDoor = "Red";
            myHouse.CloseDoor();// the door closes
             //this get the value of red from the object

            Console.WriteLine(myHouse.paintDoor); // red
             //this is a second object instance of house.

            House mySecondHouse = new House();
            mySecondHouse.paintDoor = "green";
            Console.WriteLine(mySecondHouse.paintDoor); //green
            Console.WriteLine(myHouse.paintDoor);// red
            // MycarResuilt();
            MyNumericExamples();
            

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
            NumericTypes myTypes = new NumericTypes();
            myTypes.otherOperator();
        }


        static void MycarResuilt()
        {
            CarInACarRentalApplication my = new CarInACarRentalApplication();
            my.Name = "Selam";

            Console.WriteLine(my.Name);




        }

    }

}






