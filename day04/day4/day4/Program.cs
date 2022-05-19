using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            Fun(out int x, y);
            Console.WriteLine(" X value has been changed to: " + x + "   Y value is: " + y);

        }

        static void Fun(out int x, int y)
        {
            x = 50;
            y = 90;

        }
    }
}
