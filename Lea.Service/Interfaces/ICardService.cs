using Lea.Service.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lea.Service.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<CardDto>> GetAllCardsAsync();
        Task<CardDto?> GetCardByIdAsync(Guid id);
        Task<CardDto> CreateCardAsync(CreateCardDto createCardDto);
        Task<CardDto> AddCardAsync(Guid id, CreateCardDto updateCardDto);
        Task<bool> DeleteCardAsync(Guid id);
        Task<CardDto> LinkExistingCardAsync(CreateCardDto createCardDto);
    }
}
