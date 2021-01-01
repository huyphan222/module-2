using System;
using System.Collections.Generic;

namespace THDictionaryThemSuaXoaTimkiem
{
   class BookManagement
    {
        static void Main()
        {

            Dictionary<string, Book> bookList = new Dictionary<string, Book>();

            


            // //Tìm kiếm phần tử
            // Console.WriteLine("Search for a specific book with ISBN");
            
            

            // Console.WriteLine();


            // //Xoá phần tử
            // bookList.Remove("9780321344755");
            // Console.WriteLine("Remove book with ISBN");
            // PrintValue(bookList);

             bookList.Add("9780321344755", new Book { ISBN = "9780321344755", Name = "Don't Make Me Think (Beta)", Author = "Steve Krug" });
             bookList.Add("321123", new Book {ISBN = "321123" , Name = "See you again", Author ="Mia Khalifa"}); 
             bookList.Add("696969", new Book{ISBN = "696969", Name = "Allahu akabar",Author = "Bin ladin"});
             PrintValue(bookList); 

             bookList["321123"] = new Book{ISBN = "444444",Name = "All i want for chrismart", Author = "Midnight Riders"};
              PrintValue(bookList); 

              if (bookList.ContainsKey("696969") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book book = bookList["696969"];
                Console.WriteLine("Found this book: " + book.Name);
            }
 



        }


        private static void PrintValue(Dictionary<string, Book> books)
        {
            foreach (KeyValuePair<string, Book> kvp in books)
            {
                Book book = kvp.Value;

                Console.WriteLine("ISBN: " + book.ISBN + " - " +
                    book.Name + " - " + book.Author);
            }
            Console.WriteLine();
        }

    }


    class Book
    { 
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
