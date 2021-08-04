using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Message myMessage;
            myMessage = new Message("Hello World...");
            myMessage.Print();

            Console.WriteLine("Enter name:");
            string name;
            name = Console.ReadLine ();

            Message[] messages = new Message[4];
            messages[0] = new Message("Welcome back, Grace! Ready to girlboss, gaslight, gatekeep today?");
            messages[1] = new Message("M-m-m-Mario?");
            messages[2] = new Message("Hello Dick, don't forget to apologise for last night's mansplain manipulate malewife on Twitter.");
            messages[3] = new Message("Bit of a silly name, goofy even, if you ask me.");



            if (name == "Grace")
            {
                messages[0].Print();
            }

            else if (name == "Mario")
            {
                messages[1].Print();
            }

            else if (name == "Richard")
            {
                messages[2].Print();
            }

            else
            {
                messages[3].Print();
            }
        }
    }
}