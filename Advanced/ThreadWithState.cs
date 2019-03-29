using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public delegate void ExampleCallback(int lineCount);
    public class ThreadWithState
    {
        private string _boilerplate;
        private int _Value;
        private ExampleCallback _Callback;

        //create constractor
        public ThreadWithState(string text, int number,
            ExampleCallback callbackDelegate)
        {
            this._boilerplate = text;
            this._Value = number;
            this._Callback = callbackDelegate;
        }

        public void ThreadProc()
        {
            Console.WriteLine(_boilerplate, _Value);
            if (_Callback != null) { _Callback(1); }





        }
    }
}
