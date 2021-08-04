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

            if (name == "Grace")
            {
                myMessage = new Message("Welcome back, Grace! Ready to girlboss, gaslight, gatekeep today?");
                myMessage.Print();
            }

            else if (name == "Richard")
            {
                myMessage = new Message("Hello Dick. Don't forget to pay your reparations to the land you've stolen from.");
                myMessage.Print();
            }

            else if (name == "Ella")
            {
                myMessage = new Message("Welcome back, Ella!");
                myMessage.Print();
            }

            else
            {
                myMessage = new Message("That's a bit of a silly name innit luv?");
                myMessage.Print();
            }
        }
    }
}