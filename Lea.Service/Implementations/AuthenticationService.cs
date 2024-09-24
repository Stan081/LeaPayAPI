using System;
using Lea.Service.Interfaces;

namespace Lea.Service.Implementations;

public class AuthenticationService : IAuthenticationService
{
    private readonly IAuthenticationService _authenticationService;
    public AuthenticationService(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
}
