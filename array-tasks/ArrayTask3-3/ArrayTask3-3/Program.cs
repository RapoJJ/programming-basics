using System;

namespace ArrayTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Intro();
            arrT_1 = RndArray(arrT_1.Length);
            PrintData(ref arrT_1, "arrT_1");

            arrT_2 = RndArray(arrT_2.Length);
            PrintData(ref arrT_2, "arrT_2");

            arrT_3 = CompareArrays(ref arrT_1, arrT_2, arrT_1.Length);
            PrintData(ref arrT_3, "arrT_3");
        }
        static void Intro()
        {
            Console.Write("\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i:d2} ");
            }
            Console.Write("\n\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"---");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Fills array with random numbers.
        /// Set array length.
        /// Returns filled array.
        /// </summary>
        /// <param name="length"></param>
        /// <returns>int array</returns>
        static int[] RndArray(int length)
        {
            Random rnd = new Random();
            int[] arrT = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrT[i] = rnd.Next(50);
            }
            return arrT;
        }
        /// <summary>
        /// Prints arrays data
        /// </summary>
        /// <param name="array"></param>
        /// <param name="label"></param>
        static void PrintData(ref int[]array, string label)
        {
            Console.Write($"{label}\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:d2} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Compares two arrays for bigger numbers and returns array with bigger numbers.
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static int[] CompareArrays(ref int[] array1, int[] array2, int length)
        {
            int[] arrBig = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (array1[i] > array2[i])
                {
                    arrBig[i] = array1[i];
                }
                else
                    arrBig[i] = array2[i];
            }
            return arrBig;
        }
    }
}