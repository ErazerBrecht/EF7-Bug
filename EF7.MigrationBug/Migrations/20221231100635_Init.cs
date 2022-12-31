using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF7.MigrationBug.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityEventDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ProgramId = table.Column<Guid>(type: "uuid", nullable: true),
                    IntegrationId = table.Column<Guid>(type: "uuid", nullable: true),
                    IntegrationName = table.Column<string>(type: "text", nullable: true),
                    IntegrationType = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    SubmissionCode = table.Column<string>(type: "text", nullable: true),
                    SubmissionTitle = table.Column<string>(type: "text", nullable: true),
                    ActivitySubmissionIntegrationEventDocument_IntegrationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ActivitySubmissionIntegrationEventDocument_IntegrationName = table.Column<string>(type: "text", nullable: true),
                    ActivitySubmissionIntegrationEventDocument_IntegrationType = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityEventDocuments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityEventDocuments");
        }
    }
}
