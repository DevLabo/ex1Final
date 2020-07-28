using finalsolution.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace finalsolution.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions dbContextOptions)
            : base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
    }
}
