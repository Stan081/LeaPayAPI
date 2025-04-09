namespace Lea.Service.DTOs
{
    public class CardDto
    {
        public int Id { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardType { get; set; } // e.g., Virtual, Physical, Linked
        public decimal Balance { get; set; } // For prepaid cards
        public string WalletId { get; set; } // Link to app's wallet
        public string CardIssuer { get; set; } // Card issuer information
    }
    public class CreateCardDto
    {
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardType { get; set; } // e.g., Virtual, Physical, Linked
        public bool IsLinkedToBankAccount { get; set; }
        public decimal Balance { get; set; } // For prepaid cards
        public string WalletId { get; set; } // Link to app's wallet
        public string ComplianceInfo { get; set; } // Compliance-related information
        public string CardIssuer { get; set; } // Card issuer information
    }

    public class CardRequestDto
    {
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CardType { get; set; }
        public decimal InitialBalance { get; set; }
        public string WalletId { get; set; }
        public string CardIssuer { get; set; } // Card issuer information
    }
}
