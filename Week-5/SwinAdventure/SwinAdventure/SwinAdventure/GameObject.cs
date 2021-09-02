using System;
namespace SwinAdventure
{
    public abstract class GameObject : IdentifiableObject
    {
        private string _name;
        private string _description;
        private string[] _ids;

        public GameObject(string[] ids, string name, string desc)
        {
            _ids = ids;
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
            get {
                return _name + " " + _ids[0];
            }
        }

        public virtual string FullDescription
        {
            get { return _description; }
        }
    }
}
