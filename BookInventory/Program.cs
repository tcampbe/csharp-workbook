using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;


namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksContext context = new BooksContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Enter Book Title (comma) Author's full name");
            String fullName = Console.ReadLine();

            String[] parts = fullName.Split(',');
            if (parts.Length == 2)
            {
                Book newStudent = new Book(
                    parts[0], parts[1]);

                context.Books.Add(newStudent);

                context.SaveChanges();
                Console.WriteLine("Added the book.");
            }
            else
            {
                Console.WriteLine("Invalid Title & Author," +
                    " did not add book");
            }

            Console.WriteLine("The Current List of" +
                " books are: ");

            foreach (Book s in context.Books)
            {
                Console.WriteLine("{0} - {1} by {2}",
                     s.Id, s.Title, s.Author);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

    class Book
    {
        public int Id { get; private set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Book(String Title, String Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }

    class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new 
                DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = 
                ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(
                ProjectBase.FullName, "books.db");

            optionsBuilder.UseSqlite("Data Source=" 
                + DatabaseFile);
        }

        /* class StudentsContext : DbContext
    {

        // This property corresponds to the table in our database
        public DbSet<Student> students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=c:\Users\me\Desktop\students.db");
        }
    } */
    }
}

