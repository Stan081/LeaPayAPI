using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lea.Data.Models;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Name { get; set; }
    public string PasswordlessToken { get; set; }
    public DateTime TokenExpiration { get; set; }
}
