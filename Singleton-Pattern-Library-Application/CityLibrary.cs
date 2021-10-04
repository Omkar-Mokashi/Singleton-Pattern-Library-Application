using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern_Library_Application
{
    public class CityLibrary
    {
        //Initialize the set of book in the library
        List<Book> books = new List<Book>() {

            new Book() { Name = "Harry Potter", Id = 1, Issued = false },
            new Book() { Name = "Harry Potter", Id = 2, Issued = false },
            new Book() { Name = "C# Dummies", Id = 3, Issued = false }
        };

        private static CityLibrary cityLibrary = null;

        //Constructor set to private so no instance can be created directly.
        private CityLibrary()
        {
        }

        //This is function is used to create a single instance of the class CityLibrary
        public static CityLibrary getInstance()
        {
            if (cityLibrary == null)
            {
                cityLibrary = new CityLibrary();
            }
            return cityLibrary;
        }

        //Function to issue a book from the library given the book name
        public Dictionary<string, dynamic> IssueBook(string bookName)
        {
            Dictionary<string, dynamic> requiredBook = new Dictionary<string, dynamic>() {
                { "Book", null},
                { "Message", "The book is not present"}
            };

            foreach (var book in books)
            {
                if (book.Name == bookName)
                {
                    if (book.Issued == false)
                    {
                        book.Issued = true;
                        requiredBook["Book"] = book;
                        requiredBook["Message"] = "You got the book : " + book.Name;
                        break;
                    }
                    requiredBook["Message"] = "The book is already issued";
                }
            }
            return requiredBook;
        }
    }
}
