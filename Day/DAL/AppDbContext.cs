using Day.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.DAL
{
    public class AppDbContext:DbIdentity
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
