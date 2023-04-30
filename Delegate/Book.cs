using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Book
    {
        public static int Count = 0;


        public string Name { get; set; }
        public string AuthorName { get; set; }

        public int PageCount { get; set; }

        public double Price { get; set; }

        public string Code { get; set; }

        public Library Library { get; set; }

        public Book(string name, string authorName, int pageCount, double price/*,/* Library library*/)
        {
            //Library = library;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Price = price;
            Count++;
            Code = name.Substring(0,1).ToUpper() + Count;
        }
        public override string ToString()
        {
            return $"NAme :{Name} AuthorName:{AuthorName} PageCount{PageCount} Price{Price} Code:{Code}";
        }

    }
}
