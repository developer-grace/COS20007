using System;
namespace SwinAdventure
{
    public class Item : GameObject
    {

        public Item(string[] idents, string name, string desc) : base(idents, name, desc)
        {
        }

// We need this ToString() because we're going to use String.join() on a list of items later
        public override string ToString()
        {
            return base.ShortDescription;
        }

    }
}
