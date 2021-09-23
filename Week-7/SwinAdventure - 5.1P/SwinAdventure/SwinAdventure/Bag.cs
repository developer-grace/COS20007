using System;
using System.Collections.Generic;
namespace SwinAdventure
{
    public class Bag : Item
    {
        private Inventory _inventory;
        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id)) // Are we trying to locate the Bag itself?
            {
                return this;
            }
            // If not, check if what we're looking for is in the Bag Inventory
            else if (_inventory.HasItem(id))
            {
                // If yes, ask if an Item is "id" and if it matches the 
                // identifier we are looking for then return the item
                return _inventory.Fetch(id);
            }
            else
            {
                // otherwise return nothing
                return null;
            }
        }

        public override string FullDescription
        {
            get
            {
                return "In the " + Name + " you can see: " + Inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}
