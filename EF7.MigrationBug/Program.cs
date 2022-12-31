// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello World");

class DbCtx : DbContext
{
    public DbSet<Root> Table { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionsString =
            "Host=localhost;Port=5432;User Id=postgres;Password=XXXXXX;Database=migration_bug";

        optionsBuilder.UseNpgsql(connectionsString, o => { o.SetPostgresVersion(new Version("14.4")); });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Root>();
        modelBuilder.Entity<Child>();
        modelBuilder.Entity<GrandChild>();
    }
}

abstract class Root
{
    public Guid Id { get; set; }
    public long CreatedAt { get; set; }
}

class Child : Root
{
}

class GrandChild : Child
{
    public Guid ParentUserId { get; init; }
}