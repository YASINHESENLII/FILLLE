using Newtonsoft.Json;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            
            
           List<Book> list = new List<Book>();
           
            library.AddBook(new Book("Les Miserables", "Victor Hugo", 1488, 12));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 281, 12.50));
            library.AddBook(new Book("1984", "George Orwell", 328, 8.99));
            library.AddBook(new Book("Pride and Prejudice", "Jane Austen", 279, 9.99));


           
            
            library.SerializeLibrar(library);
            



        }
    }
}
