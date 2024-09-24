using System;
using Lea.Service.Interfaces;
using Microsoft.Identity.Client;

namespace Lea.Service.Implementations;

public class AccountService : IAccountService
{
    private readonly IAccountService _accountService;
    public AccountService(IAccountService accountService)
    {
        _accountService = accountService;
    }
}
