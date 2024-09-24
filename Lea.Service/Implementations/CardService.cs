using System;
using Lea.Service.Interfaces;

namespace Lea.Service.Implementations;

public class CardService : ICardService
{
    private readonly ICardService _cardService;
    public CardService( ICardService cardService )
    {
        _cardService = cardService;
    }
}
