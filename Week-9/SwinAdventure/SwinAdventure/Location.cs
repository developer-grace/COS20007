using System;
namespace SwinAdventure
{
    public class Location : GameObject
    {
        private Inventory _inventory;
        private string _identifier;
        private string _name;
        private string _desc;
        public Location(string[] identifier, string name, string desc): base(identifier, name, desc)
        {
            _inventory = new Inventory();
        }

        public string Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }

        public string LocationName
        {
            get { return _name; }
        }

        public string LocationDesc
        {
            get { return _desc; }
        }

        public Item FetchItem(string id)
        {
            return _inventory.Fetch(id);
        }
    }
}
