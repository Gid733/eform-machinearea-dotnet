/*
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

using Microsoft.EntityFrameworkCore;
using Microting.eFormApi.BasePn.Abstractions;
using Microting.eFormApi.BasePn.Infrastructure.Database.Entities;
using Microting.eFormMachineAreaBase.Infrastructure.Data.Entities;

namespace Microting.eFormMachineAreaBase.Infrastructure.Data
{
    public class MachineAreaPnDbContext : DbContext, IPluginDbContext
    {

        public MachineAreaPnDbContext() { }

        public MachineAreaPnDbContext(DbContextOptions<MachineAreaPnDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineVersion> MachineVersions { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaVersion> AreaVersions { get; set; }
        public DbSet<MachineArea> MachineAreas { get; set; }
        public DbSet<MachineAreaSite> MachineAreaSites { get; set; }
        public DbSet<MachineAreaSiteVersion> MachineAreaSiteVersions { get; set; }
        public DbSet<MachineAreaVersion> MachineAreaVersions { get; set; }
        public DbSet<MachineAreaTimeRegistration> MachineAreaTimeRegistrations { get; set; }
        public DbSet<MachineAreaTimeRegistrationVersion> MachineAreaTimeRegistrationVersions { get; set; }
        
        // plugin settings
        public DbSet<PluginConfigurationValue> PluginConfigurationValues { get; set; }
        public DbSet<PluginConfigurationValueVersion> PluginConfigurationValueVersions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Machine>()
                .HasIndex(x => x.Name);
            modelBuilder.Entity<Machine>()
                .HasIndex(x => x.CreatedByUserId);
            modelBuilder.Entity<Machine>()
                .HasIndex(x => x.UpdatedByUserId);
            modelBuilder.Entity<Area>()
                .HasIndex(x => x.Name);
            modelBuilder.Entity<Area>()
                .HasIndex(x => x.CreatedByUserId);
            modelBuilder.Entity<Area>()
                .HasIndex(x => x.UpdatedByUserId);
        }
    }
}