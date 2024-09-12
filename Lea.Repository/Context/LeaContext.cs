using Lea.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lea.Repository.Context;

public class LeaContext : DbContext
{
    public LeaContext(DbContextOptions<LeaContext> options) : base(options){

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<CardMerchant> CardMerchants { get; set; } 
    public DbSet<CreditPoint> CreditPoints { get; set; }
}
