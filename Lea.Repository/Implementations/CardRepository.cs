using System;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;

namespace Lea.Repository.Implementations;

public class CardRepository : ICardRepository
{
    private readonly LeaContext _dbContext;
    private readonly ICardRepository _cardRepository;

    public CardRepository( LeaContext dbContext, ICardRepository cardRepository)
    {
        _dbContext = dbContext;
        _cardRepository = cardRepository;
    }
}
