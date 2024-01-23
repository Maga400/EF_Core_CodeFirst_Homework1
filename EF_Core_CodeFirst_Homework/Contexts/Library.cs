
using EF_Core_CodeFirst_Homework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_CodeFirst_Homework.Contexts;
public class Library : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookType> BookTypes {get; set; } 
    public DbSet<Operation> Operations { get; set; }
    public DbSet<Student> Students { get; set; }


}
