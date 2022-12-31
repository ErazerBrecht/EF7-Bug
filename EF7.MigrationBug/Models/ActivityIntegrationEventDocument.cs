namespace EF7.MigrationBug.Models;

public abstract class ActivityIntegrationEventDocument : ActivityProgramEventDocument
{
    public Guid IntegrationId { get; init; }
    public string IntegrationName { get; set; }
    public int IntegrationType { get; init; }
}