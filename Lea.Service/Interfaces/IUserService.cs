using Lea.Service.DTOs;
namespace Lea.Service.Interfaces
{ 

    public interface IUserService
    {
        Task<UserDto> RegisterUserAsync(CreateUserDto createUserDto);
        Task<UserDto> LoginUserAsync(LoginUserDto loginUserDto);
        Task<UserDto> GetUserByEmailAsync(string email);
    }
}