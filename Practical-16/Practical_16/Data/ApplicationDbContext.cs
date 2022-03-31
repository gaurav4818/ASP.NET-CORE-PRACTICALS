using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practical_16.Configuartions.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_16.Data
{
    public class ApplicationDbContext : IdentityDbContext<User_Admin>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

        }
        public DbSet<Student> Students { get; set; }
    }
}
