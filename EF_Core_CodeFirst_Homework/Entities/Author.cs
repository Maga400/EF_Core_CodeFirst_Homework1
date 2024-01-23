
namespace EF_Core_CodeFirst_Homework.Entities;
public class Author : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public string? Title { get; set; }
    public ICollection<Book> Books { get; set; }

    public Author() 
    {
    
    }

    public Author(string? firstName, string? lastName, string? title, ICollection<Book> books)
    {
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        Books = books;
    }
}
