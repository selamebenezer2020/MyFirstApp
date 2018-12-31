using System;

namespace Lesson
{
    public class NumericTypes
    {
        /* Integral - Signed */
        // range -128 to 127
        sbyte _mysbyteValue = 2;

        //range -32,768 to 32,767
        short _myshortValue = 4;

        //range -2,147,483,648 to 2,147,483,647
        int _myIntValue = 25000;

        // range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        long _myLongValue = 1_234_567L;
        long _myLongValue2 = 0x5F;

        //* Integral -unsign*/
        //range 0 to 255 
        byte _myUShortValue = 35;

        // range 0 to 4,294,967,295
        uint _myUIntValue = 2345U;

        //range 0 to18,446,744,073,709,551,615
        ulong _myULongValue = 123456UL;

        /* Real number  */
        // range 3.4E +/- 38(7 digits)
        float _myFloatValue = -123.6589F;

        // range -7 .9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.234M;

        public void GetSomeType()
        {
            Console.WriteLine(3.0.GetType());
            Console.WriteLine(_myFloatValue.GetType());


        }



        
    }
}