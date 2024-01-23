using EF_Core_CodeFirst_Homework.Enums;

namespace EF_Core_CodeFirst_Homework.Entities;
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set;}

    public BaseEntity() 
    {
    
    }

}
