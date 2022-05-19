using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_9
{
    class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList,MyDelegate fPtr)

        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks_BuiltIn(List<Book> bList, Func<Book,string> fPtr)

        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks_LAMBDA(List<Book> bList, Func<Book,DateTime> fptr)

        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
