using System;
namespace SwinAdventure
{
    public abstract class GameObject : IdentifiableObject
    {
        private string _name;
        private string _description;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }

        public string Name
        {
            get { return _name; }
        }

        // Short Description should return a short desc made up of name, and first id of the game object
        public string ShortDescription
        {
            // $ and {} allows you to interpolate strings
            get { return Name + $" ({FirstId})"; }
        }

        public virtual string FullDescription
        {
            get { return _description; }
        }
    }
}
