using System;
namespace SwinAdventure
{
    public class Item : GameObject
    {
        private string[] _ids;
        private string _name;
        private string _desc;

        public Item()
        {

        }

        public Item(string[] idents, string name, string desc) : this()
        {
            _idents = idents;
            _name = name;
            _desc = desc;
        }

        public override string ToString()
        {
            return _name.ToString();
        }
    }
}
