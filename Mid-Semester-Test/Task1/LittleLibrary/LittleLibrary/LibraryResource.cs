using System;
namespace LittleLibrary
{
    public class LibraryResource
    {
        private string _name;
        private string _creator;
        private string _rating;
        private bool _onloan;

        public LibraryResource() { }

        public LibraryResource(string name, string creator, string rating)
        {
            _name = name;
            _creator = creator;
            _rating = rating;
            _onloan = false;
        }

        public string Name
        {
            get { return _name; }
        }

        public string ContentRating
        {
            get { return _rating; }
        }

        public bool OnLoan
        {
            get { return _onloan; }
            set { _onloan = value;}
        }
    }
}
