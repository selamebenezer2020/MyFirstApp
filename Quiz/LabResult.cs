using System;
namespace Quiz
{
    public class LabResult
    {

        public void Leapyear()
        {
            string y = "1920";

            if (y.Length == 4)
            {
                int.Parse(y);
            }
            //Console.WriteLine("year is Leapyear")


            else
            {
                Console.WriteLine("is not leap year");
            }






        }
    }
}