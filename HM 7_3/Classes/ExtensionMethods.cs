using System.Drawing;

namespace HW7_3.Classes
{
    public static class ExtensionMethods
    {
        public static int[][] InsertElementLast(this int[][] Arr, int row, int element)
        {
            Point coords = new(row, Arr[row].Length);
            return InsertElement(Arr, coords, element);
        }
        public static int[][] InsertElementFirst(this int[][] Arr, int row, int element)
        {
            Point coords = new(row, 0);
            return InsertElement(Arr, coords, element);
        }

        public static int[][] InsertElement(this int[][] Arr, System.Drawing.Point coords, int element)
        {
            int[] copy = new int[Arr[coords.X].Length];
            Array.Copy(Arr[coords.X], copy, Arr[coords.X].Length);
            Arr[coords.X] = new int[copy.Length + 1];
            Arr[coords.X][coords.Y] = element;

            for (int i = 0, j = 0; i < Arr[coords.X].Length; i++)
            {
                if (i == coords.Y)
                    continue;
                Arr[coords.X][i] = copy[j];
                j++;
            }

            return Arr;
        }


        public static int[][] DeleteElementLast(this int[][] Arr, int row)
        {
            Point coords = new(row, Arr[row].Length - 1);
            return DeleteElement(Arr, coords);
        }

        public static int[][] DeleteElementFirst(this int[][] Arr, int row)
        {
            Point coords = new(row, 0);
            return DeleteElement(Arr, coords);
        }

        public static int[][] DeleteElement(this int[][] Arr, System.Drawing.Point coords)
        {
            int[] copy = new int[Arr[coords.X].Length];
            Array.Copy(Arr[coords.X], copy, Arr[coords.X].Length);
            Arr[coords.X] = new int[copy.Length - 1];

            for (int i = 0, j = 0; i < Arr[coords.X].Length; i++)
            {
                if (i == coords.Y)
                    j++;
                Arr[coords.X][i] = copy[j];
                j++;
            }

            return Arr;
        }

        public static int[][] JoinArrays(this int[][] arr, int[] arr1, int[] arr2)
        {
            int[][] array = new int[1][];
            array[0] = new int[arr1.Length];

            for (int i = 0; i < array[0].Length; i++)
            {
                array[0][i] = arr1[i];
            }

            return JoinArrays(arr, array, arr2);
        }

        public static int[][] JoinArrays(this int[][] arr, int[] arr1, int[][] arr2)
        {
            return JoinArrays(arr, arr2, arr1);
        }

        public static int[][] JoinArrays(this int[][] arr, int[][] arr1, int[] arr2)
        {
            int[][] array = new int[arr1.Length + 1][];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = new int[arr1[i].Length];
                Array.Copy(arr1[i], array[i], array[i].Length);
            }

            array[array.Length - 1] = new int[arr2.Length];
            Array.Copy(arr2, array[array.Length - 1], array[array.Length - 1].Length);


            return array;
        }



        public static int[][] ZeroesAndOnes(this int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < 0)
                        arr[i][j] = 0;
                    else if (arr[i][j] > 0)
                        arr[i][j] = 1;
                }

            }
            return arr;
        }

        public static int[][] MainDiagonalWithZeroes(this int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = 0;
                }

            }
            return MainDiagonal(arr);
        }

        public static int[][] MainDiagonal(this int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i == j)
                        arr[i][j] = 1;
                }

            }
            return arr;
        }
    }
}
