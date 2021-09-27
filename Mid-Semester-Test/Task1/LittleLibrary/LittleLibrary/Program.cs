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


            Book lim = new Book("Natalie Tan’s Book of Luck and Fortune", "Roselle Lim", "1984803255");
            lim.OnLoan = true;

            Book larkin = new Book("The People We Keep", "Allison Larkin", "1982171294");
            library.AddResource(larkin);
            larkin.OnLoan = true;


            Game zelda = new Game("The Legend of Zelda: Breath of the Wild", "Nintendo EPD", "E+10");
            zelda.OnLoan = true;


            Game doki = new Game("Doki Doki Literature Club!", "Team Salvato", "PEGI 16");
            library.AddResource(doki);


            Console.WriteLine(library.HasResource("Doki Doki Literature Club!")); // not on loan, should return true
            Console.WriteLine(library.HasResource("The People We Keep")); // on loan, should return false
        }
    }
}
