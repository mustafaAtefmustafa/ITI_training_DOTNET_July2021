using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////problem1 getting max and min value of an array

            Console.WriteLine("please enter the 5 elements of the array");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];

                }



            }

            Console.WriteLine("the max is " + max);
            Console.WriteLine("the min is " + min);



            //////problem 2 keep entering numbers until the sum is 100 or the value enterd is zero


            int y;
            Console.WriteLine("please enter the numbers u want");
            int sum = 0;
            while (sum < 100)
            {
                y = int.Parse(Console.ReadLine());

                sum += y;
                if (y == 0)
                {
                    break;
                }
            }
            Console.WriteLine("the sum is " + sum);




            //////problem 3 swapping two words taken from user

            Console.WriteLine("please enter the 2-word sentence to be swapped");
            String x = Console.ReadLine();
            string[] xSplit = x.Split();
            Console.WriteLine("" + xSplit[1] + " " + xSplit[0]);

            ////another solution
            
            /*
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String temp = x;
            x = y;
            y = temp;
            Console.WriteLine("" + x + " " + y);
            */


        }
    }
}
