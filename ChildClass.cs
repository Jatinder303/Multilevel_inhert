using System;

namespace Multilevel_inhert
{
    class ChildClass : IntermClass
    {
        public int multi;
        public ChildClass(int firstNumber, int SecondNumber) : base(firstNumber, SecondNumber)
        {
            a = firstNumber;
            b = SecondNumber;
        }


        // Base Class Addtion method
        public void Multi()
        {
            multi = a * b;
            Console.WriteLine("Multiplication of two number :" + multi);
        }
    }
}
