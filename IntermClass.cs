using System;

namespace Multilevel_inhert
{
    public class IntermClass : BaseClass
    {
        public int sub;
        public IntermClass(int firstNumber, int SecondNumber) : base(firstNumber, SecondNumber)
        {
            a = firstNumber;
            b = SecondNumber;
        }


        // Inter Class Subtaction method
        public void Sub()
        {
            sub = a - b;
            Console.WriteLine("Sub of two number :" + sub);
        }
    }
}
