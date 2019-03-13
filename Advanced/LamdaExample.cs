using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class LamdaExample
    {
        delegate int del(int value);

        public int MyLamdaOne(int val)
        {
            //input parameter =>expresstion or statment block
            del myDelegate = x => x * x;
            return myDelegate(val);
        }
    }
}
