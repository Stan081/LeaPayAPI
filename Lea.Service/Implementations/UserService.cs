using Lea.Data.Models;
using Lea.Repository.Interfaces;
using Lea.Service.DTOs;
using Lea.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace Lea.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> RegisterUserAsync(CreateUserDto createUserDto)
        {
            var user = new User
            {
                Email = createUserDto.Email,
                PhoneNumber = createUserDto.PhoneNumber,
                Name = createUserDto.Name,
                PasswordlessToken = GenerateToken(),
                TokenExpiration = DateTime.UtcNow.AddMinutes(15)
            };

            var createdUser = await _userRepository.CreateUserAsync(user);

            return new UserDto
            {
                Id = createdUser.Id,
                Email = createdUser.Email,
                PhoneNumber = createdUser.PhoneNumber,
                Name = createdUser.Name
            };
        }

        public async Task<UserDto> LoginUserAsync(LoginUserDto loginUserDto)
        {
            var user = await _userRepository.GetUserByEmailAsync(loginUserDto.Email);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.PasswordlessToken = GenerateToken();
            user.TokenExpiration = DateTime.UtcNow.AddMinutes(15);
            await _userRepository.UpdateUserAsync(user);

            // Send token to user's email or phone number

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Name = user.Name
            };
        }

        public async Task<UserDto> GetUserByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Name = user.Name
            };
        }

        private string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
