using System;
namespace SwinAdventure
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;
        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
            _location = new Location("here".Split(), "here", "here");
        }

        public GameObject Locate(string id) 
        {
            if (AreYou(id)) // Are we trying to locate the Player itself?
            {
                return this;
            }
            // If not, check if what we're looking for is in the Player's Inventory
            else if (_inventory.HasItem(id))
            {
                // If yes, ask if an Item is "id" and if it matches the 
                // identifier we are looking for then return it
                return _inventory.Fetch(id);
            }
            else if(_location.AreYou(id))
            {
                return _location;
            }
            else if(_location.FetchItem(id) != null)
            {
                return _location.FetchItem(id);
            }
            else
            {
                // otherwise return nothing
                return null;
            }
        }


        public string InventoryDescription
        {
            get { return "You are carrying: " + _inventory; }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public override string ToString()
        {
            return base.FullDescription;
        }
    }
}
