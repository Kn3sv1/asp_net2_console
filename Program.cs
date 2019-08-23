using System;
using System.Collections.Generic;

namespace asp_net2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new EFCoreDemoContext())
            {
                var author = new Author {
                    FirstName = "William11",
                    LastName = "Shakespeare11",
                    Books = new List<Book>
                    {
                        new Book { Title = "Hamlet22"},
                        new Book { Title = "Othello22" },
                        new Book { Title = "MacBeth22" }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }
        }
    }
}
