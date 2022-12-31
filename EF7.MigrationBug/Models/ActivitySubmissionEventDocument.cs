namespace EF7.MigrationBug.Models;

public abstract class ActivitySubmissionEventDocument : ActivityProgramEventDocument
{
    public string SubmissionCode { get; init; }
    public string SubmissionTitle { get; set; }
}