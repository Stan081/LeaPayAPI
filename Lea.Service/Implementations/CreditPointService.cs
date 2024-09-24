using System;
using Lea.Service.Interfaces;

namespace Lea.Service.Implementations;

public class CreditPointService : ICreditPointService
{
    private readonly ICreditPointService _creditPointService;
    public CreditPointService(  ICreditPointService creditPointService )
    {
        _creditPointService = creditPointService;
    }
}
