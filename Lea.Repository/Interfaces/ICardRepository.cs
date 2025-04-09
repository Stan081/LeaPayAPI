using Lea.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lea.Repository.Interfaces
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> GetAllCardsAsync();
        Task<Card?> GetCardByIdAsync(int id); // Update the interface to match the implementation
        Task<Card> CreateCardAsync(Card card);
        Task<Card> AddCardAsync(Card card);
        Task<bool> DeleteCardAsync(int id);
    }
}
