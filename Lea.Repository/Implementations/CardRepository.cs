using Lea.Data.Models;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lea.Repository.Implementations;

public class CardRepository : ICardRepository
{
    private readonly LeaContext _context;

    public CardRepository( LeaContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Card>> GetAllCardsAsync()
    {
        return await _context.Set<Card>().ToListAsync();
    }

    public async Task<Card?> GetCardByIdAsync(int id)
    {
        return await _context.Cards.FindAsync(id);
    }

    public async Task<Card> CreateCardAsync(Card card)
    {
        _context.Set<Card>().Add(card);
        await _context.SaveChangesAsync();
        return card;
    }

    public async Task<Card> AddCardAsync(Card card)
    {
        _context.Entry(card).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return card;
    } 

    public async Task<bool> DeleteCardAsync(int id)
    {
        var card = await _context.Set<Card>().FindAsync(id);
        if (card == null)
        {
            return false;
        }

        _context.Set<Card>().Remove(card);
        await _context.SaveChangesAsync();
        return true;
    }
}
