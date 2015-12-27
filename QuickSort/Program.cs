using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort.Print();
            Sort.QuickSort(Sort.A,0,Sort.A.Length-1);
            Sort.Print();
        }
    }
    class Sort
    {
        public static void Print()
        {
            foreach (var item in A)
            {
                System.Console.Write(" {0,3} ", item);
            }
            System.Console.WriteLine();
        }
        public static void Print(int[] array)
        {
            foreach (var item in array)
            {
                System.Console.Write(" {0} ",item);
            }
            System.Console.WriteLine();
        }
        public static int[] A = new int[] { 23, 56, 1, 6, 2, 9, 4, 67, 0, -2, 3 };

        public static void QuickSort(int[] A,int p,int r)
        {
            if (p >= r)
                return;
            int q = GetPartionByPivot(A,p,r);
            QuickSort(A,p,q-1);
            QuickSort(A,q+1,r);
        }
        public static int GetPartion(int[] A,int p,int r)
        {
            int x = A[r];
            int swap = p - 1;
            for (int i=p;i<r;i++)
            {
                if (A[i]<=x)
                {
                    swap++;
                    Swap(A,swap,i);
                }
            }
            Swap(A,swap+1,r);
            return swap + 1;
        }
        public static int GetPartionByPivot(int[] A,int p,int r)
        {
            int x = A[p];
            int lower = p;
            int higher = r;
            while (lower<higher)
            {
                if (lower<higher&&A[higher]>=x)
                {
                    higher--;
                }
                A[lower] = A[higher];
                while (lower<higher&&A[lower]<=x)
                {
                    lower++;
                }
                A[higher] = A[lower];
            }
            A[lower] = x;
            return lower;
        }
        public static void Swap(int[] A,int i,int j)
        {
            int temp = 0;
            temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
