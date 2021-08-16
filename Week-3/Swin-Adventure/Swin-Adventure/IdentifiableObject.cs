using System;
using System.Collections.Generic;

namespace Swin_Adventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents) : this()
        {
            foreach(string id in idents)
            {
                this.AddIdentifier(id);
            }
        }

        public IdentifiableObject()
        {
            _identifiers = new List<string>();
        }

        public Boolean AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        public void AddIdentifier( string id )
        {
            _identifiers.Add(id.ToLower());
        }

        public string FirstId
        {
            get
            {
                return _identifiers[0];
            }
        }
    }
}
