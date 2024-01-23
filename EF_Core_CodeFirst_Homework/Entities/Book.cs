namespace EF_Core_CodeFirst_Homework.Entities;
public class Book : BaseEntity
{

    public string? Name { get; set; }
    public int PageCount { get; set; }
    public ICollection<Student> Students { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public int BookTypeId { get; set; }
    public BookType BookType { get; set; }

    public Book() 
    {
    
    }

    public Book(string? name, int pageCount, ICollection<Student> students, int authorId, Author author, int bookTypeId, BookType bookType)
    {
        Name = name;
        PageCount = pageCount;
        Students = students;
        AuthorId = authorId;
        Author = author;
        BookTypeId = bookTypeId;
        BookType = bookType;
    }
}
