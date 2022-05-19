using System;
using System.Collections.Generic;

namespace Day8_9
{



    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("isbn1", "Science", new string[] { "Ahmed","Mustafa" }, new DateTime(2005, 3, 25), 30);
            Book book2 = new Book("isbn2", "Math", new string[] { "Khaled","Saeed" }, new DateTime(2010, 3, 12), 110);


            List<Book> b1 = new List<Book>();
            b1.Add(book1);
            b1.Add(book2);

            MyDelegate Fptr = BookFunctions.GetTitle;



            LibraryEngine.ProcessBooks(b1, Fptr); // user defined Delegate
            Console.WriteLine();

            
            Func<Book, string> Fptr2 = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks_BuiltIn(b1, Fptr2); // Built in Delegates
            Console.WriteLine();



            #region Anonymos Fun
            MyDelegate Fptr3 = BookFunctions.GetISBN;
            LibraryEngine.ProcessBooks(b1, Fptr3);

            #endregion
            Console.WriteLine();


            LibraryEngine.ProcessBooks_LAMBDA(b1, (i) => i.PublicationDate); // Lambda expression






        }
    }
}
