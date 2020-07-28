using finalsolution.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace finalsolution.Database
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        public Context(DbContextOptions dbContextOptions)
            : base(dbContextOptions) { }

        public DbSet<User> MyUsers { get; set; }
    }
}
