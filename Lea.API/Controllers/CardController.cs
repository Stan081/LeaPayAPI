using Lea.Service.DTOs;
using Lea.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lea.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardsController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetCards()
        {
            var cards = await _cardService.GetAllCardsAsync();
            return Ok(cards);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CardDto>> GetCard(int id)
        {
            var card = await _cardService.GetCardByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            return Ok(card);
        }

        [HttpPost]
        public async Task<ActionResult<CardDto>> CreateCard(CreateCardDto createCardDto)
        {
            var createdCard = await _cardService.CreateCardAsync(createCardDto);
            return CreatedAtAction(nameof(GetCard), new { id = createdCard.Id }, createdCard);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AddCard(int id, CreateCardDto updateCardDto)
        {
            var updatedCard = await _cardService.AddCardAsync(id, updateCardDto);
            if (updatedCard == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var deleted = await _cardService.DeleteCardAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost("link")]
        public async Task<ActionResult<CardDto>> LinkExistingCard(CreateCardDto createCardDto)
        {
            var linkedCard = await _cardService.LinkExistingCardAsync(createCardDto);
            return CreatedAtAction(nameof(GetCard), new { id = linkedCard.Id }, linkedCard);
        }
    }
}
