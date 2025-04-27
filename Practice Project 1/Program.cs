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

            Func<double, double, bool> func = (a, b) => 
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

            List<double> list = new List<double>()
            {
                10.5,6.3,4.1,8.9,25.5,68.6
            };
            sample.bubbleSort(list, func);

            foreach(var val in list)
            {
                Console.Write(val+" ");
            }
        }
    }
}
