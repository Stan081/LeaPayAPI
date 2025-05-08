using Lea.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lea.Data.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Name { get; set; }
    public required UserRole Role { get; set; }
    public required string PasswordToken { get; set; }
    public DateTime TokenExpiration { get; set; }
}
