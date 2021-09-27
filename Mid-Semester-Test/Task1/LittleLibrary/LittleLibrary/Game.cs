using System;
namespace LittleLibrary
{
    public class Game : LibraryResource
    {
        private string _developer;
        public Game(string name, string developer, string rating) : base(name, developer, rating)
        {
        }

        public string Developer
        {
            get { return _developer; }
        }
    }
}
