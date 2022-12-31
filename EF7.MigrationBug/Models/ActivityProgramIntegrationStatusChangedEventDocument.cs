namespace EF7.MigrationBug.Models;

public class ActivityProgramIntegrationStatusChangedEventDocument : ActivityIntegrationEventDocument
{
    public int Status { get; init; }
}