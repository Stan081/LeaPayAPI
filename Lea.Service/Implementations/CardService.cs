using Lea.Data.Models;
using Lea.Data.Utils;
using Lea.Repository.Interfaces;
using Lea.Service.DTOs;
using Lea.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lea.Service
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<IEnumerable<CardDto>> GetAllCardsAsync()
        {
            var cards = await _cardRepository.GetAllCardsAsync();
            return cards.Select(card => new CardDto
            {
                Id = card.Id,
                CardHolderName = card.CardHolderName,
                ExpiryDate = card.ExpiryDate,
                CardType = card.CardType,
                Balance = card.Balance,
                WalletId = card.WalletId,
                CardIssuer = card.CardIssuer
            });
        }

        public async Task<CardDto?> GetCardByIdAsync(Guid id)
        {
            var card = await _cardRepository.GetCardByIdAsync(id);
            if (card == null) return null;

            return new CardDto
            {
                Id = card.Id,
                CardHolderName = card.CardHolderName,
                ExpiryDate = card.ExpiryDate,
                CardType = card.CardType,
                Balance = card.Balance,
                WalletId = card.WalletId,
                CardIssuer = card.CardIssuer,
                // ComplianceInfo = SecurityUtils.Decrypt(card.ComplianceInfo) // Decrypt compliance info
            };
        }

        public async Task<CardDto> CreateCardAsync(CreateCardDto createCardDto)
        {
            var card = new Card
            {
                CardHolderName = createCardDto.CardHolderName,
                ExpiryDate = createCardDto.ExpiryDate,
                CardType = createCardDto.CardType,
                IsLinkedToBankAccount = createCardDto.IsLinkedToBankAccount,
                Balance = createCardDto.Balance,
                WalletId = createCardDto.WalletId,
                ComplianceInfo = SecurityUtils.Encrypt(createCardDto.ComplianceInfo), // Encrypt compliance info
                CardIssuer = createCardDto.CardIssuer,
                CardNumber = "GenerateCardNumber(createCardDto.CardIssuer)",
                CVV = "GenerateCVV(createCardDto.CardIssuer)"
            };

            var createdCard = await _cardRepository.CreateCardAsync(card);

            return new CardDto
            {
                Id = createdCard.Id,
                CardHolderName = createdCard.CardHolderName,
                ExpiryDate = createdCard.ExpiryDate,
                CardType = createdCard.CardType,
                Balance = createdCard.Balance,
                WalletId = createdCard.WalletId,
                CardIssuer = createdCard.CardIssuer
            };
        }

        public async Task<CardDto> AddCardAsync(Guid id, CreateCardDto updateCardDto)
        {
            var card = new Card
            {
                Id = id,
                CardHolderName = updateCardDto.CardHolderName,
                ExpiryDate = updateCardDto.ExpiryDate,
                CardType = updateCardDto.CardType,
                IsLinkedToBankAccount = updateCardDto.IsLinkedToBankAccount,
                Balance = updateCardDto.Balance,
                WalletId = updateCardDto.WalletId,
                ComplianceInfo = SecurityUtils.Encrypt(updateCardDto.ComplianceInfo), // Encrypt compliance info
                CardIssuer = updateCardDto.CardIssuer,
                CardNumber = "GenerateCardNumber(updateCardDto.CardIssuer)",
                CVV = "GenerateCVV(updateCardDto.CardIssuer)"
            };

            var updatedCard = await _cardRepository.AddCardAsync(card);

            return new CardDto
            {
                Id = updatedCard.Id,
                CardHolderName = updatedCard.CardHolderName,
                ExpiryDate = updatedCard.ExpiryDate,
                CardType = updatedCard.CardType,
                Balance = updatedCard.Balance,
                WalletId = updatedCard.WalletId,
                CardIssuer = updatedCard.CardIssuer
            };
        }

        public async Task<bool> DeleteCardAsync(Guid id)
        {
            return await _cardRepository.DeleteCardAsync(id);
        }

        public async Task<CardDto> LinkExistingCardAsync(CreateCardDto createCardDto)
        {
            var card = new Card
            {
                CardHolderName = createCardDto.CardHolderName,
                ExpiryDate = createCardDto.ExpiryDate,
                CardType = "Linked",
                IsLinkedToBankAccount = createCardDto.IsLinkedToBankAccount,
                Balance = createCardDto.Balance,
                WalletId = createCardDto.WalletId,
                ComplianceInfo = SecurityUtils.Encrypt(createCardDto.ComplianceInfo), // Encrypt compliance info
                CardIssuer = createCardDto.CardIssuer,
                CardNumber = "GenerateCardNumber(createCardDto.CardIssuer)",
                CVV = "GenerateCVV(createCardDto.CardIssuer)"
            };

            var linkedCard = await _cardRepository.CreateCardAsync(card);

            return new CardDto
            {
                Id = linkedCard.Id,
                CardHolderName = linkedCard.CardHolderName,
                ExpiryDate = linkedCard.ExpiryDate,
                CardType = linkedCard.CardType,
                Balance = linkedCard.Balance,
                WalletId = linkedCard.WalletId,
                CardIssuer = linkedCard.CardIssuer
            };
        }

      
    }
}
