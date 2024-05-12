using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BorrowHistory> BorrowHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    BookId = 1,
                    Title = "Vardagsträning med klicker",
                    Author = "Åsa Jakobsson",
                    ISBN = "978-91-9845-302-7",
                    Publisher = "Klickerförlaget" 
                },
                new Book()
                {
                    BookId = 2,
                    Title = "101 Hundtrick",
                    Author = "Kyra Sundance & Chalcy",
                    ISBN = "978-91-7783-674-2",
                    Publisher = "Tucan förlag" 
                },
                new Book()
                {
                    BookId = 3,
                    Title = "Hjärngympa för hundar",
                    Author = "Sophie Collins",
                    ISBN = "978-91-7861-610-7",
                    Publisher = "Lindco"
                },
                new Book()
                {
                    BookId = 4,
                    Title = "Den missförstådda hunden",
                    Author = "Per Jensen",
                    ISBN = "978-91-27-15187-1",
                    Publisher = "Natur & Kultur"
                },
                new Book()
                {
                    BookId = 5,
                    Title = "Hundens språk och tankar",
                    Author = "Per Jensen",
                    ISBN = "978-91-27-13108-8",
                    Publisher = "Natur & Kultur"
                },
                new Book()
                {
                    BookId = 6,
                    Title = "Bra relation",
                    Author = "Kenth Svartberg",
                    ISBN = "978-91-978158-2-6",
                    Publisher = "Svartbergs Hundkunskap"
                },
                new Book()
                {
                    BookId = 7,
                    Title = "Lär känna din hund - och dig själv",
                    Author = "Kerstin Malm och Malin Avenius",
                    ISBN = "978-9163989919",
                    Publisher = "AH Books"
                },
                new Book()
                {
                    BookId = 8,
                    Title = "Kontakt kontraktet",
                    Author = "Eva Bodfäldt",
                    ISBN = "978-91-973578-7-6",
                    Publisher = "Eva Bodfäldt Education AB"
                },
                new Book()
                {
                    BookId = 9,
                    Title = "Nyckeln till lycka - att motverka social stress hos hundar",
                    Author = "Anders Hallgren",
                    ISBN = "978-91-6393-834-4",
                    Publisher = "AH Books"
                }
                );

            modelBuilder.Entity<Customer>().HasData(
                
                new Customer()
                {
                    CustomerId = 1,
                    CustomerName = "Léon Nahum",
                    CustomerEmail = "leon@mail.se",
                    CustomerPhone = "070-6233728"
                },
                new Customer()
                {
                    CustomerId = 2,
                    CustomerName = "Andreas Fors",
                    CustomerEmail = "andreas@mail.se",
                    CustomerPhone = "072-4421186"
                },
                new Customer()
                {
                    CustomerId = 3,
                    CustomerName = "Nadine Marklund",
                    CustomerEmail = "nadine@mail.se",
                    CustomerPhone = "076-6231458"
                },
                new Customer()
                {
                    CustomerId = 4,
                    CustomerName = "Axel Wennström",
                    CustomerEmail = "axel@mail.se",
                    CustomerPhone = "072-3664014"
                },
                new Customer()
                {
                    CustomerId = 5,
                    CustomerName = "Miriam Nahum",
                    CustomerEmail = "miriam@mail.se",
                    CustomerPhone = "073-8018685"
                }
                );

            modelBuilder.Entity<BorrowHistory>().HasData(
                
                new BorrowHistory()
                {
                    BorrowHistoryId = 1,
                    FkBookId = 1,
                    FkCustomerId = 1,
                    BorrowDate = new DateTime(2024, 01, 24),
                    ActualReturnDate = new DateTime(2024, 02, 15)
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 2,
                    FkBookId = 2,
                    FkCustomerId = 2,
                    BorrowDate = new DateTime(2024, 02, 20),
                    ActualReturnDate = new DateTime(2024, 03, 15)
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 3,
                    FkBookId = 3,
                    FkCustomerId = 3,
                    BorrowDate = new DateTime(2024, 03, 17),
                    ActualReturnDate = new DateTime(2024, 04, 13)
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 4,
                    FkBookId = 4,
                    FkCustomerId = 4,
                    BorrowDate = new DateTime(2024, 04, 14),
                    ActualReturnDate = new DateTime(2024, 04, 28)
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 5,
                    FkBookId = 5,
                    FkCustomerId = 5,
                    BorrowDate = new DateTime(2024, 03, 24),
                    ActualReturnDate = new DateTime(2024, 04, 12)
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 6,
                    FkBookId = 6,
                    FkCustomerId = 1,
                    BorrowDate = new DateTime(2024, 04, 26),
                    ActualReturnDate = new DateTime(2024, 05, 12)
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 7,
                    FkBookId = 7,
                    FkCustomerId = 2,
                    BorrowDate = new DateTime(2024, 05, 10)
                    
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 8,
                    FkBookId = 8,
                    FkCustomerId = 3,
                    BorrowDate = new DateTime(2024, 04, 24),
                    
                },
                new BorrowHistory()
                {
                    BorrowHistoryId = 9,
                    FkBookId = 9,
                    FkCustomerId = 5,
                    BorrowDate = new DateTime(2024, 05, 01)
            
                }
                );
        }
    }
}
