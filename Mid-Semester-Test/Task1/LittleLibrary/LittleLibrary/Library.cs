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
            //return _resources.Find((LibraryResource obj) => obj.Name == name && !obj.OnLoan) != null;

            Boolean TheBookHasBeenFoundAndIsntOnLoan = false;

            foreach (LibraryResource l in _resources)
            {
                if (l.Name == name && !l.OnLoan)
                {
                    TheBookHasBeenFoundAndIsntOnLoan = true;
                }
            }
            return TheBookHasBeenFoundAndIsntOnLoan;
        }

    }
}
