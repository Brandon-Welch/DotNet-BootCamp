using LoginAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Data;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}

    public DbSet<User> Users {get;set;}
}