using System;

namespace Multilevel_inhert
{
    public class BaseClass
    {
        public int a;
        public int b;
        public int sum;

        // Base Class constructor
        public BaseClass(int firstNumber, int SecondNumber)
        {
            a = firstNumber;
            b = SecondNumber;
        }

        // Base Class Addtion method
        public void Add()
        {
            sum = a + b;
            Console.WriteLine("Sum of two number :" + sum);
        }
    }
}
