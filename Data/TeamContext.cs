using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CAP2.Models;

namespace CAP2.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext (DbContextOptions<TeamContext> options)
            : base(options)
        {
        }

        public DbSet<CAP2.Models.Team> Teams { get; set; }
        public DbSet<CAP2.Models.Client> Clients { get; set; }

        // protected override void OnModelingCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Team>().ToTable("Team");
        //     modelBuilder.Entity<Client>().ToTable("Client");

        // }
    }
}
