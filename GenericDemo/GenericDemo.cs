﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class GenericDemo<T> where T:IComparable
    {
        public void MaximumOfNumber(string firstValue,string secondValue,string thirdValue)
        {
            if(firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>0||
                firstValue.CompareTo(secondValue)>=0 && firstValue.CompareTo(thirdValue)>0||
                firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>=0)
                 {
                     Console.WriteLine(firstValue);
                 }
            if(secondValue.CompareTo(firstValue)>0 && secondValue.CompareTo(thirdValue)>0||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0 )
                {
                    Console.WriteLine(secondValue);
                }
            if(thirdValue.CompareTo(firstValue)>0 && thirdValue.CompareTo(secondValue)>0 ||
                    thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                Console.WriteLine(thirdValue);
            }
        }
    }
}
