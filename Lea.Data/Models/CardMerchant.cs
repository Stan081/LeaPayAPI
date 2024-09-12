using System;

namespace Lea.Data.Models;

public class CardMerchant
{
    public Guid Id { get; set; }   
    public int MerchantId { get; set; } 
    public required string MerchantReference { get; set; }   
}
