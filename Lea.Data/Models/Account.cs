using System;

namespace Lea.Data.Models;

public class Account
{
    public Guid Id { get; set; }
    public int AccountId { get; set; }
    public int UserTypeId { get; set; } 
    public double Balance { get; set; }
    public int AccountType { get; set; }
    public DateTime CreatedAt { get; set; } 

}
