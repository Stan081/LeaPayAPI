using System;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;

namespace Lea.Repository.Implementations;

public class CreditPointRepository : ICreditPointRepository
{
    private readonly LeaContext _dbContext;
    private readonly ICreditPointRepository _creditPointRepository;
    public CreditPointRepository( LeaContext dbContext, ICreditPointRepository creditPointRepository)
    {
        _dbContext = dbContext;
        _creditPointRepository = creditPointRepository;
    }
}
