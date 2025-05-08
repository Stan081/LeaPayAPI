using Lea.Data.Enums;
using System;

namespace Lea.Service.DTOs
{

    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
    }
    public class CreateUserDto
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
        public DateTime TokenExpiration { get; set; }
    }

    public class LoginUserDto
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}