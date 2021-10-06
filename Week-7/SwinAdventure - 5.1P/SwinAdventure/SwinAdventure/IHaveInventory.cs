using System;
namespace SwinAdventure
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name { get; }

        //public Boolean AddItem(GameObject item);
    }
}
