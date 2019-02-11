using System;
namespace Quiz
{
    public class HDtv : Television
    {
        //public string physicalremote { get; set; }

        public void Hdtv()
        {
            string model = "HDTv";
            Console.WriteLine("This is " + model);
            Getinfotv(1500, 75, 4);
            remote = "Physicalremote";
            mountanable = true;
            Console.WriteLine("mountable");
            Kindremote();

        }


        public override void Kindremote()
        {
            Console.WriteLine($"this is {remote}\n\n");
        }
    }

}
