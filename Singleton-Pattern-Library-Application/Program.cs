using System;

namespace Singleton_Pattern_Library_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new Librarian();
            librarian.Work();
        }
    }
}
