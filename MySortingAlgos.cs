using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithm
{
    public class MySortingAlgos
    {
      

        
        public ArrayList InsertionSort(ArrayList a)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Insertion Sort");
            
            sw.Start();
            for (int i = 1;i < a.Count; i++)
            {
                int key = (int)a[i];
                int j = i - 1;
                while (j >= 0 && (int)a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
                //Console.WriteLine(i);
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Sorting took {ts}.");
            foreach (int nr in a)
            {
                Console.Write($"{nr} ");
            }
            Console.WriteLine();
            return a;
        }

        public ArrayList SelectionSort(ArrayList a)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Selection Sort");
            sw.Start();
            for (int i = 0; i < a.Count-1; ++i) {
                int min = i;
                for (int j = i+1; j < a.Count; ++j) {
                    if ((int)a[j] < (int)a[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = (int)a[i];
                    a[i] = a[min];
                    a[min] = temp;
                }
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Sorting took {ts}.");
            foreach (int nr in a)
            {
                Console.Write($"{nr} ");
            }
            Console.WriteLine();
            return a;
        }
        private ArrayList merge(ArrayList left, ArrayList right)
        {
            ArrayList result = new ArrayList();
            while (left.Count > 0 && right.Count > 0)
            {
                if ((int)left[0] <= (int)right[0] )
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0) {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }

        private ArrayList MergeSort(ArrayList m)
        {
            if (m.Count <= 1)
            {
                return m;
            }

            ArrayList leftList = new ArrayList();
            ArrayList rightList = new ArrayList();
            for (int i = 0; i < m.Count; i++)
            {
                if(i < (m.Count / 2))
                {
                    leftList.Add(m[i]);
                }
                else
                {
                    rightList.Add(m[i]);
                }
            }

            return merge(leftList, rightList);
        }

        public ArrayList MergeSortcall(ArrayList m)
         {
            Console.WriteLine("Merge Sort");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ArrayList sortedlist = new ArrayList(MergeSort(m));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Sorting took {ts}.");
            foreach (int a in m)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
            return sortedlist;
         }
}
}
