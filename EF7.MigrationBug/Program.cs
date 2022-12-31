// See https://aka.ms/new-console-template for more information

using EF7.MigrationBug.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello World");

class DbCtx : DbContext
{
    public DbSet<ActivityEventDocument> ActivityEventDocuments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionsString =
            "Host=localhost;Port=5432;User Id=postgres;Password=XXXXXXX;Database=migration_bug";

        optionsBuilder.UseNpgsql(connectionsString, o => { o.SetPostgresVersion(new Version("14.4")); });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivityEventDocument>();
        modelBuilder.Entity<ActivityProgramEventDocument>();
        modelBuilder.Entity<ActivityIntegrationEventDocument>();
        modelBuilder.Entity<ActivityProgramIntegrationDeletedEventDocument>();
        modelBuilder.Entity<ActivityProgramIntegrationStatusChangedEventDocument>();
        modelBuilder.Entity<ActivitySubmissionEventDocument>();
        modelBuilder.Entity<ActivitySubmissionIntegrationEventDocument>();
        modelBuilder.Entity<ActivitySubmissionIntegrationDeletedEventDocument>();
        modelBuilder.Entity<ActivitySubmissionIntegrationCreatedEventDocument>();
    }
}