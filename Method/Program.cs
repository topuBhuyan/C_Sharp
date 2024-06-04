using System;
using System.Runtime.InteropServices;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("moja", "Khan");

            //Console.WriteLine("Result: " + AddResult(5, 10));

            //int i = 0;
            //printValue(ref i);
            //Console.WriteLine("print value: " + i);

            //int sumResult = 0;
            //int productResult = 0;

            //printValue(2, 3, out sumResult, out productResult);
            //Console.WriteLine("Save vlaue: {0} and product value {1}", sumResult, productResult);


           // int[] myArray = { 1, 2, 3, 4 };
            printValue(1,2,3,4,5,6,7);
        }

        public static void printValue(params int[] num)
        {
            Console.WriteLine("Param langth: " + num.Length);
        }
             //public static void printValue(int fn, int ln, out int sum, out int product )
             //{
             //       sum = fn + ln;
             //       product = fn * ln;
             //}

        //public static void printValue(ref int j)
        //{
        //    j = 100;
        //}

       //public static int AddResult(int FN, int LN)
       // {
       //     //Console.WriteLine("FullName {0} {1}", FN, LN);
       //     int X = FN + LN;
       //     return X;
       // }


    }
}
