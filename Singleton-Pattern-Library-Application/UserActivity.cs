using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern_Library_Application
{
    public class UserActivity
    {
        public string message;

        //Funtion that defines the user activity to issue the book from the library and returns the issued book
        public Book IssueBookFromCityLibrary(string bookName)
        {
            Dictionary<string, dynamic> issuedBook = new Dictionary<string, dynamic>();
            CityLibrary cityLibrary = CityLibrary.getInstance();
            issuedBook = cityLibrary.IssueBook(bookName);
            this.message = issuedBook["Message"];
            return issuedBook["Book"];
        }
    }
}
