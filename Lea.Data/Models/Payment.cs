using System;

namespace Lea.Data.Models;

public class Payment
{
    public Guid Id { get; set; }
    public int PaymentId { get; set; }
    public int UserId { get; set; }
    public int CardId { get; set; }
    public double Amount { get; set; }
    public int PaymentType { get; set; }
}
