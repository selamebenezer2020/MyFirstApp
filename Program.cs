using System;

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

        House myHouse = new House ();
        myHouse.paintDoor = "Red"; 
        myHouse.CloseDoor();// the door closes
        //this get the value of red from the object
    
        Console.WriteLine(myHouse.paintDoor); // red
        //this is a second object instance of house.

        House mySecondHouse = new House();
        mySecondHouse.paintDoor = "green";
        Console.WriteLine(mySecondHouse.paintDoor); //green
        Console.WriteLine(myHouse.paintDoor);// red
        MycarResuilt();
        }
        
        static void  MycarResuilt(){
            CarInACarRentalApplication my = new CarInACarRentalApplication();
            my.Name = "Selam";
            
        }

    }
    
}
        


        


