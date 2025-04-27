using System;
using System.Collections.Generic;

public class Sample
{
    public void bubbleSort(List<int> arr, Func<int,int,bool> func)
    {
        int n = arr.Count;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                bool result = func(arr[j], arr[j + 1]);
                if (result)
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
               
            }

            if (!swapped)
                break;
        }
    }
}