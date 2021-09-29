using System;

namespace GenericDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenericDemo<double> genericDemo = new GenericDemo<double>();
            genericDemo.MaximumOfNumber(11.3, 533.2123, 533.2124);
        }
    }
}
