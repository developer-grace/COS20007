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


        // To check if your inventory has an item
        // You must iterate over your list of items
        // and check if any of the items has the same ID as the one you're looking for.
        // In OOP, the items should identify themselves and you shouldn't know their inner workings.
        public bool HasItem(string id)
        {

            foreach(Item item in _items)
            {
                if(item.Name == id)
                {
                    return true;
                }
            }
            return false;


        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        // Remove item from inventory by id
        public Item Take(string id)
        {
            Item myItem = _items.Find(x => x.Name.Equals(id));
            _items.Remove(myItem);
            return myItem;
        }

        // Locates an item by id (using AreYou) and returns it
        public Item Fetch(string id)
        {
            
        }

        // returns the list of Items in Inventory List
        public string ItemList
        {
            get { return _items.ToString(); }
        }
    }
}
