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
            // checking if "id" is in the Player's Inventory
            if (_inventory.HasItem(id))
            {
                // if yes, ask if an Item is "id" and if it matches the 
                // identifier we are looking for then fetch it and return it

                return _inventory.Fetch(id);
            }

            // otherwise return nothing
            return null;
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
