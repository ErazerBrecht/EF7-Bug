﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EF7.MigrationBug.Migrations
{
    [DbContext(typeof(DbCtx))]
    [Migration("20221231100635_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivityEventDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("CreatedAt")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ActivityEventDocuments");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ActivityEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivityProgramEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivityEventDocument");

                    b.Property<Guid>("ProgramId")
                        .HasColumnType("uuid");

                    b.HasDiscriminator().HasValue("ActivityProgramEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivityIntegrationEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivityProgramEventDocument");

                    b.Property<Guid>("IntegrationId")
                        .HasColumnType("uuid");

                    b.Property<string>("IntegrationName")
                        .HasColumnType("text");

                    b.Property<int>("IntegrationType")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("ActivityIntegrationEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivitySubmissionEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivityProgramEventDocument");

                    b.Property<string>("SubmissionCode")
                        .HasColumnType("text");

                    b.Property<string>("SubmissionTitle")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("ActivitySubmissionEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivityProgramIntegrationDeletedEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivityIntegrationEventDocument");

                    b.HasDiscriminator().HasValue("ActivityProgramIntegrationDeletedEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivityProgramIntegrationStatusChangedEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivityIntegrationEventDocument");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("ActivityProgramIntegrationStatusChangedEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivitySubmissionIntegrationEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivitySubmissionEventDocument");

                    b.Property<Guid>("IntegrationId")
                        .HasColumnType("uuid")
                        .HasColumnName("ActivitySubmissionIntegrationEventDocument_IntegrationId");

                    b.Property<string>("IntegrationName")
                        .HasColumnType("text")
                        .HasColumnName("ActivitySubmissionIntegrationEventDocument_IntegrationName");

                    b.Property<int>("IntegrationType")
                        .HasColumnType("integer")
                        .HasColumnName("ActivitySubmissionIntegrationEventDocument_IntegrationType");

                    b.HasDiscriminator().HasValue("ActivitySubmissionIntegrationEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivitySubmissionIntegrationCreatedEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivitySubmissionIntegrationEventDocument");

                    b.HasDiscriminator().HasValue("ActivitySubmissionIntegrationCreatedEventDocument");
                });

            modelBuilder.Entity("EF7.MigrationBug.Models.ActivitySubmissionIntegrationDeletedEventDocument", b =>
                {
                    b.HasBaseType("EF7.MigrationBug.Models.ActivitySubmissionIntegrationEventDocument");

                    b.HasDiscriminator().HasValue("ActivitySubmissionIntegrationDeletedEventDocument");
                });
#pragma warning restore 612, 618
        }
    }
}