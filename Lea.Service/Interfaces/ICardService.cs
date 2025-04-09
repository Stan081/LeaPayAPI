using Lea.Service.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lea.Service.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<CardDto>> GetAllCardsAsync();
        Task<CardDto?> GetCardByIdAsync(int id);
        Task<CardDto> CreateCardAsync(CreateCardDto createCardDto);
        Task<CardDto> AddCardAsync(int id, CreateCardDto updateCardDto);
        Task<bool> DeleteCardAsync(int id);
        Task<CardDto> LinkExistingCardAsync(CreateCardDto createCardDto);
    }
}
