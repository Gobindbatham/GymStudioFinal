using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace GymStudio.Data
{
    public class GymStudioContext : DbContext
    {
        public GymStudioContext (DbContextOptions<GymStudioContext> options)
            : base(options)
        {
        }

        public DbSet<Classes> Classes { get; set; }

        public DbSet<Schedules> Schedules { get; set; }

        public DbSet<Query> Query { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
