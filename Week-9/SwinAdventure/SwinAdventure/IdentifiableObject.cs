using System;
using System.Collections.Generic;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents) 
        {
            // Initialising a new List of string types for _identifiers
            _identifiers = new List<string>();

            // Adding an identifier to the List _identifier for each string id
            foreach (string id in idents)
            {
                this.AddIdentifier(id);
            }
        }

        public Boolean AreYou(string id)
        {
            return _identifiers.Contains(id.ToLower());
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count >= 1)
                {
                    return _identifiers[0];
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
