using System;
namespace LittleLibrary
{
    public class LibraryResource
    {
        private string _name;
        private string _creator;
        private string _rating;
        private bool _onloan;
        public LibraryResource(string name, string creator, string rating)
        {
            _onloan = false;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Creator
        {
            get { return _creator; }
        }

        public string ContentRating
        {
            get { return _rating; }
        }

        public bool OnLoan
        {
            get { return _onloan; }
        }
    }
}
