using System;

namespace GenericDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenericDemo<int> genericDemo = new GenericDemo<int>();
            genericDemo.MaximumOfNumber(11, 5, 2);
        }
    }
}
