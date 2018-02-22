namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    AuthorID = 1,
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 1,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID = 2,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID = 3,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 3,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    AuthorID = 3,
                    Price = 9.95M
                });

            //TODO: Add several Author records
         context.Author.AddOrUpdate(a => a.AuthorID,
            new Author()
            {
                AuthorID = 1,
                AuthorName = "Jane Austen",
                AuthorAddress = "Winchester, United Kingdom",
                AuthorPhone = "0",
            },
            new Author()
            {
                AuthorID = 2,
                AuthorName = "Charles Dickens",
                AuthorAddress = "Gads Hill Place, United Kingdom",
                AuthorPhone = "0",
            },
            new Author()
            {
                AuthorID = 3,
                AuthorName = "Ursula Le Guin",
                AuthorAddress = "Portland, OR",
                AuthorPhone = "123.456.7890",
            });

            //TODO: Add several Member records
            context.Members.AddOrUpdate(m => m.MemberID,
            new Member()
            {
                MemberID = 1,
                MemberName = "Joe Shmoe",
                MemberAddress = "123 Fake St",
                MemberPhone = "555.555.5555",
            },
            new Member()
            {
                MemberID = 2,
                MemberName = "Susie Lee",
                MemberAddress = "123 Sunny Ave SE",
                MemberPhone = "000.000.0000",
            });

            //TODO: Add additional Purchase records
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,
                    MemberID = 1,
                },
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 2,
                    Amount = 7.95M,
                    BookID = 5,
                    MemberID = 2,
                },
                new IndyBooks.Models.Purchase()
                {
                    PurchaseID = 3,
                    Amount = 8.95M,
                    BookID = 4,
                    MemberID = 1,
                });
        }
    }
}
