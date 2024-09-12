using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lea.Data.Models;

public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public required string EmailAddress { get; set; }
        public required string Password { get; set; }
        public required string PasswordKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Token { get; set; }
        public int? Passrecoverytoken { get; set; }
        public DateTime? TokenTimeout { get; set; }
        public DateTime? Passrecoverytokentimeout { get; set; }
        public bool? Deleted { get; set; }
        public string? RecoveryEmail { get; set; }
        public required string FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public int AccountId { get; set; }
        // [JsonIgnore]
        // public virtual AccountOpening Account { get; set; }

    }
