using System;

namespace Lea.Data.Models;

public class CreditPoint
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public double Point { get; set; }
    public int IssueType { get; set; }
    public DateTime DateIssued { get; set; }   
    public int PaymentId { get; set; } 


}
