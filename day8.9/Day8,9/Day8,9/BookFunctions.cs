using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_9
{
    class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Title: {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            string author="";
            for(int i = 0; i < B.Authors?.Length ; i++)
            {
                author += B.Authors[i] + "," ;
            }
            return $"Authors of {B.Title} are: {author}";
        }
        public static string GetPrice(Book B)
        {
            return $"Price: {B.Price}";
        }

        public static string GetISBN(Book B)
        {
            return B.ISBN;
        }
        public static DateTime GetDate(Book B)
        {
            return B.PublicationDate;
        }
    }
}
