using System;
using System.Collections.Generic;
namespace SwinAdventure
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
           return _items.Contains(id);
        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        // Remove item from inventory by id
        public Item Take(string id)
        {
            _items.Remove(id);
        }

        // Locates an item by id (using AreYou) and returns it
        public Item Fetch(string id)
        {
            
        }

        // returns the list of Items in Inventory List
        public string ItemList
        {
            get { return _items; }
        }
    }
}
