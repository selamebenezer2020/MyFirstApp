using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public delegate string myCoat(string message);
    public class Coats
    {
        public event myCoat MyEventCoat;

        public string myResult { get; private set; }

        // deafalt constractor
        public Coats()
        {
            this.MyEventCoat += new myCoat(this.MyFavoriteCoat);
            myResult = MyEventCoat("Trench");
        }
        public string MyFavoriteCoat(String message)
        {
            return "my favorite coat is" + message;
        }
    }
}