using Microsoft.EntityFrameworkCore;
using EFCoreExample.Models;

namespace EFCoreExample.Data
{
    //We use AppDbContext in our code to interact with our database
    //Previosuly, with ADO, we created a Data Access Object related to the entity in SQL 
    //Now we just need the AppDbContext Object
    public class AppDbContext : DbContext
    {
        //Constructor
        //Used by EF to create the needed DB Context based on our provided Models
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //We provide the models through DBSet<ModelName> fields
        //Convention dictates we make these PLURAL
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //HACK: In prior example, we added a connection string here (Week 6 > EFMovieApp > Context > AppDBContect.cs)
        //For this example, we updated appsettings.json with the connection string

        //We have to override the default behavior to ensure the Foreign Key Constraint is established
        //If we don't do this, the columns will still be created but the contraint is not enforced (i.e. could create a UserId even if it doesnt exist)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-one relationship
            //This Entity User has 1 Profile, with 1 User, with a Foreign Key of UserId
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);

            // One-to-many relationship
            //This Entity Category can have Many Products, Products can only have 1 Category, with a Foreigh Key of CatergoryId
            //However, 1 Product can only have 1 Category
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
