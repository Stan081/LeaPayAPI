using System;

namespace Lea.Service.Interfaces;

public interface IAuthenticationService
{
    public Task<bool> SendOtpAsync(String email);
    public Task<bool> VerifyOtpAsync(String email, String otp);

}