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

        // checking if a LibraryResource exists, AND if it exists within
        // the Library List
        public bool HasResource(string name)
        {
            return false;
        }
    }
}
