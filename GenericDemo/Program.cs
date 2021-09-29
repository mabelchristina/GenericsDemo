using System;

namespace GenericDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenericDemo<string> genericDemo = new GenericDemo<string>();
            genericDemo.MaximumOfNumber("hi", "hello", "world");
        }
    }
}
