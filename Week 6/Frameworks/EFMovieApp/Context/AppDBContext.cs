using Microsoft.EntityFrameworkCore;

class AppDBContext:DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Read in our Connection String from our txt file
        string connectionString = File.ReadAllText(@"C:\Users\A140953\OneDrive - Government Employees Insurance Company\Documents\RevatureTraining\DotNetBootCamp\Connection Strings\MovieAppDBcs.txt");
        optionsBuilder.UseSqlServer(connectionString);
    }


}