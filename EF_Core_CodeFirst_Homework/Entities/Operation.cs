namespace EF_Core_CodeFirst_Homework.Entities;
public class Operation : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Operation() 
    {
    
    }

    public Operation(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }
}
