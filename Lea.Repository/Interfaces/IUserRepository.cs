using System;
using Lea.Data.DTOs;
using Lea.Data.Models;

namespace Lea.Repository.Interfaces;

public interface IUserRepository
{
    Task<UserDetailsDTO> UpdateUserdetails(int id, CreateUserDTO user);
    Task<bool> UpdateUserdetails(int id, UpdateUserDTO user);
    Task<User> GetUserByIdAsync(int id);
    Task<List<User>> GetUsersAsync();
}
