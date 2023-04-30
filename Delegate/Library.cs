using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Delegate
{
    internal class Library
    {
        public List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        public void SS()
        {
            Console.WriteLine(books);
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void GetBook(string code)
        {
            var a = books.Find(x => x.Code == code);
            Console.WriteLine(a);
        }

        public void FindAllBooks(string code)
        {
            books.FindAll(x => x.Code == code).ForEach(x => Console.WriteLine(x));
        }

        public void RemoveBook(string code)
        {
            var a = books.RemoveAll(x => x.Code == code);
            Console.WriteLine(a);


        }

        public void SHowInfo()
        {
            books.ForEach(x => Console.WriteLine(x));
        }
        public void SerializeLibrar(Library book)
        {
            string json = JsonConvert.SerializeObject(book);
            using (StreamWriter sw = new StreamWriter(@"C:\\Users\\Asus\\Documents\\C#AB103\\Delegate\\Delegate\\JSon.json"))
            {
                sw.WriteLine(json);
            }
        }
        public void Deserlize()
        {
            string result;
            using (StreamReader str = new StreamReader(@"C:\Users\Asus\Documents\C#AB103\Delegate\Delegate\JSon.json"))
            {
                result = str.ReadToEnd();
            }
            List<Book> sr = JsonConvert.DeserializeObject<List<Book>>(result);
            sr.ForEach(x => Console.WriteLine(x));




        }
    }
}