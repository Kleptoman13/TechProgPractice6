namespace Practice6_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Novel("Book1", "Ivan1", 1968, 200, "Skazka1", "Suuuuuuuu");
            Book book2 = new Novel("Book2", "Ivan2", 1969, 201, "Skazka2", "Suuuuuuuu");
            Book book3 = new Novel("Book3", "Ivan3", 1970, 202, "Skazka3", "Suuuuuuuu");
            Book book4 = new Novel("Book4", "Ivan4", 1971, 203, "Skazka4", "Suuuuuuuu");
            Book book5 = new Novel("Book5", "Ivan5", 1972, 204, "Skazka5", "Suuuuuuuu");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            foreach (var book in library.Books)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }

            library.DeleteBook(3);

            foreach (var book in library.Books)
            {
                Console.WriteLine(book);
                Console.WriteLine();
            }

            book1.CloseBook();
            book1.OpenBook();
            book1.OpenBook();
            book1.CloseBook();
        }
    }
}