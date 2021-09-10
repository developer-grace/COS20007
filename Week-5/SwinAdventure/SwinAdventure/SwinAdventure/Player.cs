using System;
namespace SwinAdventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;

        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
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
                return this;
            }
            else
            {
                // otherwise return nothing
                return null;
            }
        }

        public override string FullDescription
        {
            get { return "You are carrying: " + ShortDescription; }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }
    }
}
