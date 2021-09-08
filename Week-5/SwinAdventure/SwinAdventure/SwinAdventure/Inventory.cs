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

        // Remove item from inventory by id.
        // id can be the name or one of the idents
        public Item Take(string id)
        {
            // Jai says that this line is too complicated,
            // "that code falls into a common trap of trying to be too clever at the expense of comprehension,
            // which is why you don't really underrstand it."
            // You should revisit that and find an easier way that you do understand.
            // foreach is probably the tool to start with here.
            //Item myItem = _items.Find(x => x.Name.Equals(id));

            Item myItem = this.Fetch(id);
            _items.Remove(myItem);
            return myItem;
        }

        // Locates an item by id (using AreYou to search list of ids, and Name if the input is the name) and returns it
        // id can be the name or one of the idents
        public Item Fetch(string id)
        {
            Item myItem = _items.Find(x => x.AreYou(id) || x.Name.Equals(id));
            return myItem;
        }

        // returns the list of Items in Inventory List
        public string ItemList
        {
            get { return _items.ToString(); }
        }
    }
}
