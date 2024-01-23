
namespace EF_Core_CodeFirst_Homework.Entities;
public class Author : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public ICollection<Book> Books { get; set; }

    public Author() 
    {
    
    }

    public Author(string? firstName, string? lastName, ICollection<Book> books)
    {
        FirstName = firstName;
        LastName = lastName;
        Books = books;
    }
}
