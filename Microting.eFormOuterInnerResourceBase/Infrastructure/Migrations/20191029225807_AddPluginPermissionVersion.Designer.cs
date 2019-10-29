﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microting.eFormOuterInnerResourceBase.Infrastructure.Data;

namespace Microting.eFormOuterInnerResourceBase.Infrastructure.Migrations
{
    [DbContext(typeof(OuterInnerResourcePnDbContext))]
    [Migration("20191029225807_AddPluginPermissionVersion")]
    partial class AddPluginPermissionVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValues");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValueVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("PermissionId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.ToTable("PluginGroupPermissions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermissionVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("PermissionId");

                    b.Property<int>("PluginGroupPermissionId");

                    b.Property<int?>("PluginGroupPermissionId1");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("PluginGroupPermissionId");

                    b.HasIndex("PluginGroupPermissionId1");

                    b.ToTable("PluginGroupPermissionVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("PermissionName");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginPermissions");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("Name");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("InnerResources");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResourceVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("InnerResourceId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("InnerResourceId");

                    b.ToTable("InnerResourceVersions");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("InnerResourceId");

                    b.Property<int>("OuterResourceId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("InnerResourceId");

                    b.HasIndex("OuterResourceId");

                    b.ToTable("OuterInnerResources");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResourceSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MicrotingSdkCaseId");

                    b.Property<int>("MicrotingSdkSiteId");

                    b.Property<int>("MicrotingSdkeFormId");

                    b.Property<int>("OuterInnerResourceId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("OuterInnerResourceId");

                    b.ToTable("OuterInnerResourceSites");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResourceSiteVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MicrotingSdkCaseId");

                    b.Property<int>("MicrotingSdkSiteId");

                    b.Property<int>("MicrotingSdkeFormId");

                    b.Property<int>("OuterInnerResourceId");

                    b.Property<int>("OuterInnerResourceSiteId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("OuterInnerResourceSiteVersions");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResourceVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("InnerResourceId");

                    b.Property<int>("OuterInnerResourceId");

                    b.Property<int>("OuterResourceId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("InnerResourceId");

                    b.HasIndex("OuterInnerResourceId");

                    b.HasIndex("OuterResourceId");

                    b.ToTable("OuterInnerResourceVersions");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("Name");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("OuterResources");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResourceVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<int>("OuterResourceId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("OuterResourceId");

                    b.ToTable("OuterResourceVersions");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.ResourceTimeRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("DoneAt");

                    b.Property<int>("InnerResourceId");

                    b.Property<int>("OuterResourceId");

                    b.Property<int>("SDKCaseId");

                    b.Property<int>("SDKFieldValueId");

                    b.Property<int>("SDKSiteId");

                    b.Property<int>("TimeInHours");

                    b.Property<int>("TimeInMinutes");

                    b.Property<int>("TimeInSeconds");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("InnerResourceId");

                    b.HasIndex("OuterResourceId");

                    b.ToTable("ResourceTimeRegistrations");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.ResourceTimeRegistrationVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("DoneAt");

                    b.Property<int>("InnerResourceId");

                    b.Property<int>("MachineAreaTimeRegistrationId");

                    b.Property<int>("OuterResourceId");

                    b.Property<int>("SDKCaseId");

                    b.Property<int>("SDKFieldValueId");

                    b.Property<int>("SDKSiteId");

                    b.Property<int>("TimeInHours");

                    b.Property<int>("TimeInMinutes");

                    b.Property<int>("TimeInSeconds");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("InnerResourceId");

                    b.HasIndex("MachineAreaTimeRegistrationId");

                    b.HasIndex("OuterResourceId");

                    b.ToTable("ResourceTimeRegistrationVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", b =>
                {
                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermissionVersion", b =>
                {
                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission")
                        .WithMany()
                        .HasForeignKey("PluginGroupPermissionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", "PluginGroupPermission")
                        .WithMany()
                        .HasForeignKey("PluginGroupPermissionId1");
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResourceVersion", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResource", "InnerResource")
                        .WithMany()
                        .HasForeignKey("InnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResource", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResource", "InnerResource")
                        .WithMany("OuterInnerResources")
                        .HasForeignKey("InnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResource", "OuterResource")
                        .WithMany("OuterInnerResources")
                        .HasForeignKey("OuterResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResourceSite", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResource", "OuterInnerResource")
                        .WithMany("OuterInnerResourceSites")
                        .HasForeignKey("OuterInnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResourceVersion", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResource", "InnerResource")
                        .WithMany()
                        .HasForeignKey("InnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterInnerResource", "OuterInnerResource")
                        .WithMany()
                        .HasForeignKey("OuterInnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResource", "OuterResource")
                        .WithMany()
                        .HasForeignKey("OuterResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResourceVersion", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResource", "OuterResource")
                        .WithMany()
                        .HasForeignKey("OuterResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.ResourceTimeRegistration", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResource", "InnerResource")
                        .WithMany()
                        .HasForeignKey("InnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResource", "OuterResource")
                        .WithMany()
                        .HasForeignKey("OuterResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.ResourceTimeRegistrationVersion", b =>
                {
                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.InnerResource", "InnerResource")
                        .WithMany()
                        .HasForeignKey("InnerResourceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.ResourceTimeRegistration", "ResourceTimeRegistration")
                        .WithMany()
                        .HasForeignKey("MachineAreaTimeRegistrationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormOuterInnerResourceBase.Infrastructure.Data.Entities.OuterResource", "OuterResource")
                        .WithMany()
                        .HasForeignKey("OuterResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
