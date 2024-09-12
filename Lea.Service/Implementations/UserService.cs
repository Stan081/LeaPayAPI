using System;
using Lea.Repository.Interfaces;
using Lea.Service.Interfaces;

namespace Lea.Service.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService( IUserRepository userRepository )
    {
        _userRepository = userRepository;
    }
}
