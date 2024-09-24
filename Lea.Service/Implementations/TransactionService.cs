using System;
using Lea.Service.Interfaces;

namespace Lea.Service.Implementations;

public class TransactionService : ITransactionService
{
    private readonly ITransactionService _transactionService;
    public TransactionService( ITransactionService transactionService )
    {
        _transactionService = transactionService;
    }
}
