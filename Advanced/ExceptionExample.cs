using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExample
    {
        string _ExampleNull;

        public void MyException()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Try run");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Exception thrown" + ex.Message);
            }
        }
        public void MyArrayException()
        {
            string[] names = { "Mimi", "Selam", "Wende" };
            string[] value = { "42", "43", "44" };
            try
            {
                //byte b = byte.Parse(names[1]);
                byte W = byte.Parse(value[1]);
                Console.WriteLine(W);
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least one argument!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("That's not a number!");
            }
            catch (OverflowException a)
            {
                Console.WriteLine("You've given me more that a byte!");
            }
        }

    }
}
