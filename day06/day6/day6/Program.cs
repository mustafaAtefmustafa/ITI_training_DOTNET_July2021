using System;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            Complex c1 = new Complex(1,1);
            Complex c2 = new Complex(3,3);
            Complex c3 = new Complex(1,4);
            Complex c4 = new Complex(5,9);
            Complex c5 = new Complex(3,10);
            Complex c6 = new Complex(1,8);


            c3 = c1 + c2;
            Console.WriteLine($"c3 = c1 + c2 :  {c3}");

            Console.WriteLine("please enter a number to add to the object");
            x = int.Parse(Console.ReadLine());
            c4 = c1 + x;
            Console.WriteLine($"c4 = c1 + x   : {c4} ");

            c5 = ++c1;
            Console.WriteLine($"c5 = ++c1   : {c5}");


            c6 = c2++;
            Console.WriteLine($"c6 = c2++  :  {c6}");

            if (c3 > c1)  { Console.WriteLine("c3>c1");  }
            else { Console.WriteLine("false"); }

            if (c4 < c2) { Console.WriteLine("c4<c2"); }
            else { Console.WriteLine("false"); }

        }
    }
}
