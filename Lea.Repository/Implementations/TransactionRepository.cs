using System;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;

namespace Lea.Repository.Implementations;

public class TransactionRepository : ITransactionRepository
{
    private readonly LeaContext _dbContext;
    private readonly ITransactionRepository _transactionRepository;
    public TransactionRepository( LeaContext dbContext, ITransactionRepository transactionRepository)
    {
        _dbContext = dbContext;
        _transactionRepository = transactionRepository;
    }
}
