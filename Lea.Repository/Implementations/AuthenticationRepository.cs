using System;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;

namespace Lea.Repository.Implementations;

public class AuthenticationRepository : IAuthenticationRepository
{
    private readonly LeaContext _dbContext;
    private readonly IAuthenticationRepository _authenticationRepository;
    public AuthenticationRepository(LeaContext dbContext, IAuthenticationRepository authenticationRepository)
    {
        _authenticationRepository = authenticationRepository;
        _dbContext = dbContext;
    }
    
}
