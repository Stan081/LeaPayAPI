using Lea.Data.DTOs;
using Lea.Data.Models;
using Lea.Repository.Context;
using Lea.Repository.Interfaces;

namespace Lea.Repository.Implementations;

public class UserRepository : IUserRepository
{
    private readonly LeaContext _dbContext;

    public UserRepository(LeaContext dbContext)
    {
        _dbContext = dbContext;
    }

    public  Task<User> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUserdetails(int id, UpdateUserDTO user)
    {
        throw new NotImplementedException();
    }

    public Task<UserDetailsDTO> UpdateUserdetails(int id, CreateUserDTO user)
    {
        throw new NotImplementedException();
    }
}
