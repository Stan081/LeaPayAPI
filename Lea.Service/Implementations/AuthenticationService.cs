using System;
using Lea.Repository.Interfaces;
using Lea.Service.Interfaces;
using Lea.Service.Utils;

namespace Lea.Service.Implementations
{ 

public class AuthenticationService : IAuthenticationService
{
    private readonly IAuthenticationRepository _authenticationRepository;
    private readonly Authentication _authentication;

    public AuthenticationService(IAuthenticationRepository authenticationRepository, Authentication authentication)
    {
        _authenticationRepository = authenticationRepository;
        _authentication = authentication;
    }

        public async Task<bool> SendOtpAsync(string email)
        {
            var token = _authentication.GenerateOTP();
            var response = _authenticationRepository.SaveOtpAsync(email, token);
            return true;
        }

        public Task<bool> VerifyOtpAsync(string email, string otp)
        {
            throw new NotImplementedException();
        }
    }
}