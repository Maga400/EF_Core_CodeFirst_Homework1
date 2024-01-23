using System.Collections.ObjectModel;

namespace EF_Core_CodeFirst_Homework.Entities;
public class BookType : BaseEntity
{
    public string? Name { get; set; } 
    public ICollection<Book> Books { get; set; }
    public BookType()
    {
    
    }
    public BookType(string? name, ICollection<Book> books)
    {
        Name = name;
        Books = books;
    }
}
