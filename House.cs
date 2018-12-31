using System;
namespace ClassWork
{
    public class House
    //the following are fields
    {
        string _foundation;
        string _roof;
        string _window;
        string _door;

        //standard long way to create property

        public string Foundation
        {
            get
            {
                return _foundation;

            }
            set
            {
                this._foundation = value;
            }
        }

        public string Roof
        {
            get
            {
                return _roof;

            }
            set
            {
                this._roof = value;
            }
        }

        public string Window
        {
            get
            {
                return _window;

            }
            set
            {
                this._window = value;

            }
        }




        //short handhand propety +field;

        public string foundation { get; set; }

        public string paintDoor { get; set; }

        public string door { get; set; }

        public string roof { get; set; }





        //below are methods 

        public void OpenDoor()
        {

            Console.WriteLine("The door opens");
        }
        public void CloseDoor()
        {
            Console.WriteLine("The door closes");
        }


    }
}
