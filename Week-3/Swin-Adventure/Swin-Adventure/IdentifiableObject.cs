using System;
using System.Collections.Generic;

namespace Swin_Adventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            foreach(string id in idents)
            {
                this.AddIdentifier(id);
            }
        }

        public Boolean AreYou(string id)
        {
            if(_identifiers.Contains(id))
            {
                return true;
            }
            return false;
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
