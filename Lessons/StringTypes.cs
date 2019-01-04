using System;
using System.Text;
using ClassWork;

namespace Lessons
{
    public class StringTypes
    {
        private string _testString = "Test String";
        private string _secondString = "second String";


        public void SampleString()
        {
            Console.WriteLine(_testString);
        }
        public void AddString()
        {
            Console.WriteLine(_testString + _secondString);
        }
        public String StringBuilderExample(string value1,
        string value2, string value3)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value1)
            .Append("").Append(value2)
            .Append("").Append(value3);

            return builder.ToString();
        }


        public void charTypeExample()
        {

            char ab = 'A';
            char de = 'B';
            char copyrightsymbol = '\u00A9';
            char hi = (char)88;// change 88 to char

            Console.WriteLine(hi);
            Console.WriteLine(ab == de);

        }
        public void EscapeExample()
        {
            Console.WriteLine("My name is selam O/'Dell");
            Console.WriteLine("This is an /a O/'Alart");
            Console.WriteLine("some sort of new line/nthat ");
            Console.WriteLine(" A sort of tab /t is around here somewhere");

        }

        public void PlaceHolderExample()
        {
            Console.WriteLine("this string is {0}", "cool");
            Console.WriteLine("We can use init like {0}", "and {1}", 15, 10);
            Console.WriteLine("I like {1} more than {0}, but not as much as {2}", "sad", "happy", "funny");


        }

        public void ArraySample()
        {
            String[] Cars = new string[3];
            Cars[0] = "camaro";
            Cars[1] = "mustang";
            Cars[2] = "chevelle";

            // other method

            string[] names = { "Tom", "Roger", " Matt" };

            Console.WriteLine(Cars[1]);
            Console.WriteLine(names[0]);

        }

        public void MyHouseArray()
        {
            House house1 = new House();
            house1.paintDoor = "Green";
            House house2 = new House();
            house2.paintDoor = "Blue";
            House[] houseList = { house1, house2 };
            Console.WriteLine(houseList[0].paintDoor);

        }

        public void MultiArraySample()
        {
            int[,] myIntArray = new int[2, 2];
            myIntArray[0, 0] = 5;
            myIntArray[0, 1] = 10;
            myIntArray[1, 0] = 2;
            myIntArray[1, 1] = 4;

            Console.WriteLine(myIntArray[1, 0]);
            Console.WriteLine(myIntArray[1,1]);
        }


    }
}