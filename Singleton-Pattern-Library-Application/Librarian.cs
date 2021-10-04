using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern_Library_Application
{
    public class Librarian
    {
        //The function defining the working of the librarian issuing books to different users.
        public void Work()
        {
            UserActivity userA = new UserActivity();
            Book book1 = userA.IssueBookFromCityLibrary("Harry Potter");
            Console.WriteLine(userA.message);
            UserActivity userB = new UserActivity();
            Book book2 = userB.IssueBookFromCityLibrary("Harry Potter");
            Console.WriteLine(userB.message);
            UserActivity userC = new UserActivity();
            Book book3 = userC.IssueBookFromCityLibrary("Harry Potter");
            Console.WriteLine(userC.message);
            Book book4 = userC.IssueBookFromCityLibrary("Lost world");
            Console.WriteLine(userC.message);
            Book book5 = userC.IssueBookFromCityLibrary("C# Dummies");
            Console.WriteLine(userC.message);
        }
    }
}
