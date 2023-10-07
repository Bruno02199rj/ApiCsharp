
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class AppDbContext  : DbContext
{ 
    public DbSet <Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=tcp:as45484846se.database.windows.net,1433;Initial Catalog=AppDb;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\"");
    }

}