using System;

namespace day03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 5, 9, 4, 4, 5, 6, 7 };
            Console.WriteLine("before calling any fun");
            foreach (int i in Arr)
            { Console.WriteLine(i); }

            Console.WriteLine("after calling the first fun where we pass by ref");
            fun1( ref Arr);
            foreach (int i in Arr)
            { Console.WriteLine(i); }

            Console.WriteLine("after calling the second fun where we pass by value ");
            fun2(Arr);
            foreach (int i in Arr)
            { Console.WriteLine(i); }
            
        }

        static void fun1 ( ref int[] arr)
        {
             arr = new int [] { 10, 9 }; // the original array in "main" will be affected due to passing by ref
            
        }
        static void fun2 (int [] arr)
        {
            arr = new int[] { 3, 6 }; // the original array in "main" won't be affected due to passing by value
        }
    }
}
