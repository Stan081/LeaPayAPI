using System;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;

namespace Lea.Repository.Implementations;

public class AccountRepository : IAccountRepository
{
    private readonly LeaContext _dbContext;
    private readonly IAccountRepository _accountRepository;
    public AccountRepository(LeaContext dbContext, IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
        _dbContext = dbContext;
    }
}
