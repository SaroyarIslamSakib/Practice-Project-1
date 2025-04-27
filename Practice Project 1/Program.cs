using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Practice_Project_1
{
    class Program
    {
        static void Main()
        {
            Sample sample = new Sample();

            Func<int, int, bool> func = (a, b) => 
            {
                if(a>b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            List<int> list = new List<int>()
            {
                10,6,4,8,25,68
            };
            sample.bubbleSort(list, func);

            foreach(var val in list)
            {
                Console.Write(val+" ");
            }
        }
    }
}
