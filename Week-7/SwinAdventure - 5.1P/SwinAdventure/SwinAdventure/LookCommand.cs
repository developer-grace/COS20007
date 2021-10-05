using System;
namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand(string[] ids) : base(ids)
        {
        }

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory container = p;

            if (text.Length == 3 || text.Length == 5)
            {
                if (text[0] == "look")
                {
                    if (text[1] == "at")
                    {
                        if (text.Length == 5)
                        {
                            if (text[3] == "in")
                            {
                                container = FetchContainer(p, text[4]);
                                if(container == null)
                                {
                                    return "I can't find the " + text[4];
                                }
                            }
                            else return "What do you want to look in?";
                        }

                        return LookAtIn(text[2], container);
                    }
                    else return "What do you want to look at?";
                }
                else return "Error in look input";

            }

            return "I don't know how to look like that";
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            GameObject obj = p.Locate(containerId);
            if(obj is IHaveInventory)
            {
                return (IHaveInventory)obj;
            } else return null;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            return container.Locate(thingId).ToString();
        }
    }
}
