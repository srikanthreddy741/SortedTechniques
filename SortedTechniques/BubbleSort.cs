using System;
using System.Collections.Generic;
using System.Text;

namespace SortedTechniques
{
    public class BubbleSort
    {
        public static void DisplayBubbleSort()
        {
            int[] arr = {65, 86, 23, 75, 12 };

            int temp;
            for(int j=0;j<=arr.Length-2;j++)
            {
                for(int i=0;i<=arr.Length-2;i++)
                {
                    if (arr[i] > arr[i+1])
                        {
                        temp = arr[i+1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted : ");
            foreach (int p in arr)
            {
                Console.WriteLine(p);
            }
        }
        
    }
}
