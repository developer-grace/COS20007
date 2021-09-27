using System;

namespace LittleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Little Library!");

            Console.WriteLine("Initialising Little Library...");
            Library library = new Library("My Little Library");

            Console.WriteLine("Initialising books and games...");
            Book book1 = new Book("Natalie Tan’s Book of Luck and Fortune", "Roselle Lim", "1984803255");
            Book book2 = new Book("The People We Keep", "Allison Larkin", "1982171294");
            Game game1 = new Game("The Legend of Zelda: Breath of the Wild", "Nintendo EPD", "E+10");
            Game game2 = new Game("Doki Doki Literature Club!", "Team Salvato", "PEGI 16");

            Console.WriteLine("Adding a book to Library");
            library.AddResource(book2);
            Console.WriteLine("Adding a game to Library");
            library.AddResource(game1);

        }
    }
}
