using System;

namespace Lea.Repository.Interfaces;

public interface IAuthenticationRepository
{
    public Task<string> GetOtpAsync(string email);
    public Task<bool> SaveOtpAsync(string email, string otp);

}
