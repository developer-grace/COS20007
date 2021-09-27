using System;
namespace LittleLibrary
{
    public class Book : LibraryResource
    {
        private string _author;
        private string _isbn;
        public Book(string name, string author, string isbn) : base(name, author, isbn)
        {
        }

        public string Author
        {
            get { return _author; }
        }

        public string ISBN
        {
            get { return _isbn; }
        }
    }
}
