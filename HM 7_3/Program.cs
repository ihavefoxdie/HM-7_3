using System;
using HW7_3.Classes;

namespace Testing
{
    class Program
    {
        static void Print(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random rnd = new();

            int[][] array = new int[10][];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new int[10];
                for(int j = 0; j < array[i].Length; j++)
                    array[i][j] = rnd.Next(-10, 10);
            }
            Console.WriteLine("initial array:");
            Print(array);

            Console.WriteLine("inserted with new values array:");
            array.InsertElementFirst(1, 5);
            array.InsertElementLast(0, 10);
            Print(array);

            Console.WriteLine("array elements deleted:");
            array.DeleteElementFirst(1);
            array.DeleteElementLast(0);
            Print(array);


            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 500;
            }

            Console.WriteLine("joined array:");
            array = array.JoinArrays(array, arr);
            Print(array);

            Console.WriteLine("positives to ones and negatives to zeores:");
            array.ZeroesAndOnes();
            Print(array);

            Console.WriteLine("main diagonal:");
            array.MainDiagonal();
            Print(array);

            Console.WriteLine("main diagonal with everything else zeroed:");
            array.MainDiagonalWithZeroes();
            Print(array);
        }
    }
}
