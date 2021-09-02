using System;
namespace SwinAdventure
{
    public abstract class GameObject 
    {
        private string _name;
        private string _description;
        public GameObject(string[] ids, string name, string desc)
        {
        }

        public string Name
        {
            get { return _name; }
        }

        // Short Description should return a short desc made up of name, and first id of the game object
        public string ShortDescription
        {
            get { return _name; }
        }

        public virtual string FullDescription
        {
            get { return _description; }
        }
    }
}
