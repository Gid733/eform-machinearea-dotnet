﻿/*
The MIT License (MIT)
Copyright (c) 2007 - 2019 Microting A/S
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microting.eFormOuterInnerResourceBase.Infrastructure.Data;

namespace Microting.eFormOuterInnerResourceBase.Infrastructure.Migrations
{
    [DbContext(typeof(OuterInnerResourcePnDbContext))]
    [Migration("20190403141554_UpdateSettingsTables")]
    partial class UpdateSettingsTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            string autoIDGenStrategy = "SqlServer:ValueGenerationStrategy";
            object autoIDGenStrategyValue = SqlServerValueGenerationStrategy.IdentityColumn;
            if (DbConfig.IsMySQL)
            {
                autoIDGenStrategy = "MySql:ValueGenerationStrategy";
                autoIDGenStrategyValue = MySqlValueGenerationStrategy.IdentityColumn;
            }

            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

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
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

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

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

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

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.AreaVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

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

                    b.HasIndex("AreaId");

                    b.ToTable("AreaVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

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

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreas");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MachineAreaSettings");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSettingVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaSettingId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MachineAreaSettingVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaId");

                    b.Property<int>("MicrotingSdkCaseId");

                    b.Property<int>("MicrotingSdkSiteId");

                    b.Property<int>("MicrotingSdkeFormId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MachineAreaId");

                    b.ToTable("MachineAreaSites");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSiteVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaId");

                    b.Property<int>("MachineAreaSiteId");

                    b.Property<int>("MicrotingSdkCaseId");

                    b.Property<int>("MicrotingSdkSiteId");

                    b.Property<int>("MicrotingSdkeFormId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MachineAreaSiteVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("DoneAt");

                    b.Property<int>("MachineId");

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

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreaTimeRegistrations");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistrationVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("DoneAt");

                    b.Property<int>("MachineAreaTimeRegistrationId");

                    b.Property<int>("MachineId");

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

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineAreaTimeRegistrationId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreaTimeRegistrationVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineAreaId");

                    b.Property<int>("MachineId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("MachineAreaId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineAreaVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("MachineId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.ToTable("MachineVersions");
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.AreaVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany("MachineAreas")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany("MachineAreas")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaSite", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", "MachineArea")
                        .WithMany("MachineAreaSites")
                        .HasForeignKey("MachineAreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistration", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistrationVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaTimeRegistration", "MachineAreaTimeRegistration")
                        .WithMany()
                        .HasForeignKey("MachineAreaTimeRegistrationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineAreaVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineArea", "MachineArea")
                        .WithMany()
                        .HasForeignKey("MachineAreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.MachineVersion", b =>
                {
                    b.HasOne("Microting.eFormMachineAreaBase.Infrastructure.Data.Entities.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
