using System;
namespace SwinAdventure
{
    public class Item : GameObject
    {
        private string _name;
        private string _desc;

        public Item(string[] idents, string name, string desc) : base(idents, name, desc)
        {
            _name = name;
            _desc = desc;
        }

        public override string ToString()
        {
            return _name.ToString();
        }
    }
}
