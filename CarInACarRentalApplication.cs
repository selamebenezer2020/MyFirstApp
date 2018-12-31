using System;
namespace ClassWork
{
    public class CarInACarRentalApplication
    {
        string _Firstname;
        string _DrivingLicence;
        string _Location;

        public void Rent()
        {

        }
        public void Sell()
        {

        }
        public void Like ()
        {

        }

         public string Name {
            get {
                return _Firstname;

            }
            set {
                this._Firstname= value;
            }
        }

        
         public string DrivingLicence {
            get {
                return _DrivingLicence;

            }
            set {
                this._DrivingLicence= value;
            }
        }

        public string Location{
            get {
                return _Location;

            }
            set {
                this._Location= value;
            }
        }


        //short way
        public string firstname { get; set; }
         public string drivingLicenceNumber { get; set; }
         public string location{ get; set; }


    }
}

