namespace Lea.Data.Models;

public class Card
{
    public Guid Id { get; set; }
    public int CardId { get; set; }
    public int MerchantId { get; set; }
    public int UserId { get; set; }
    public DateOnly IssueDate { get; set; } 
    public int CurrencyId { get; set; }
    public int AccountId { get; set; }
    public int CardType { get; set; }
    public Guid CardReference { get; set; }
}
