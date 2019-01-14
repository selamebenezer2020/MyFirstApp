using System;
namespace Quiz
{
    public class QuizClass1
    {

        public string GradeResult(string Grade)
        {
            switch (Grade)
            {

                // if(grade == 'E'){ return "Excellent"} 
                case "E":

                    return "Excellent";

                case "V":
                    return "VeryGood";

                case "G":
                    return "Good";

                case "A":
                    return "Average";

                case "F":
                    return "Fail";


                default:

                    return "The value entered is not correct";




            }

        }


        public void ForTest()

        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("number " + i);
                }


            }

        }
    }
}
