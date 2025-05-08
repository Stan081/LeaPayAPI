namespace Lea.Data.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public required string CardNumber { get; set; }
        public required string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public required string CVV { get; set; }
        public required string CardType { get; set; } // e.g., Virtual, Physical, Linked
        public bool IsLinkedToBankAccount { get; set; }
        public decimal Balance { get; set; } // For prepaid cards
        public required string WalletId { get; set; } // Link to app's wallet
        public required string ComplianceInfo { get; set; } // Compliance-related information
        public required string CardIssuer { get; set; } // Card issuer information
    }
}
