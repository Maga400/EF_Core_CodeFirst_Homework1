using EF_Core_CodeFirst_Homework.Enums;

namespace EF_Core_CodeFirst_Homework.Entities;
public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string? PhoneNumber { get; set; }
    public ICollection<Book> Books { get; set; }
    
    public Student()
    {
    
    }

    public Student(string? firstName, string? lastName, string? schoolNumber, Gender gender, DateTime birthday, string? phoneNumber, ICollection<Book> books)
    {
        FirstName = firstName;
        LastName = lastName;
        SchoolNumber = schoolNumber;
        Gender = gender;
        Birthday = birthday;
        PhoneNumber = phoneNumber;
        Books = books;
    }
}
