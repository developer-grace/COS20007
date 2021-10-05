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
                                // the container id is the 5th word
                            }
                            else return "What do you want to look in?";
                        }

                        if (text.Length == 3)
                        {
                            // tell LookCommand that the container is the player
                        }
                    }
                    else return "What do you want to look at?";
                }
                else return "Error in look input";

            }
            return "I don't know how to look like that";
        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            return null;
        }

        private string LookAtIn(string thingId, IHaveInventory container)
        {
            return null;
        }
    }
}
