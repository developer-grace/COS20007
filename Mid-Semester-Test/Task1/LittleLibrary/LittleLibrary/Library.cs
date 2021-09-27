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

        public void AddResource(LibraryResource resource)
        {
            // code goes here
        }

        public bool HasResource(string name)
        {
            // code goes here
        }
    }
}
