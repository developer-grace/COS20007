using System;
using System.Collections.Generic;
namespace LittleLibrary
{
    public class Library
    {
        private List<LibraryResource> _resources;
        public Library(string name)
        {
            _resources = new List<LibraryResource>();
        }

        // adding a LibraryResource to the Library List
        public void AddResource(LibraryResource resource)
        {
            _resources.Add(resource);
        }

        //returns true if a LibraryResource exists within the Library List,
        // AND if it's not on loan
        public bool HasResource(string name)
        {
            Boolean TheBookHasBeenFoundAndIsntOut = false;
            Console.WriteLine("Looking for this book: " + name);

            foreach (LibraryResource l in _resources)
            {
                Console.WriteLine("Looking for name in: " + l.Name);
                Console.WriteLine("ON loan?" + l.OnLoan.ToString());
                if (l.Name == name && !l.OnLoan)
                {
                    Console.WriteLine("Found the book! And it's not on loan");
                    TheBookHasBeenFoundAndIsntOut = true;

                }
            }

            return TheBookHasBeenFoundAndIsntOut;
        }
    }
}
