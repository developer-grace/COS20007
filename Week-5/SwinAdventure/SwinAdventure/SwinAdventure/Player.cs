using System;
namespace SwinAdventure
{
    public class Player : GameObject
    {
        private Inventory _inventory;
        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
        }

        public override string FullDescription
        {
            get { return FullDescription; }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }
    }
}
