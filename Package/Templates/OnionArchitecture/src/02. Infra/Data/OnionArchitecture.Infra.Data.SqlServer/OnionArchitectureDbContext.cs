using Microsoft.EntityFrameworkCore;
using System;

namespace OnionArchitecture.Infra.Data.SqlServer
{
    public class OnionArchitectureDbContext : DbContext
    {
        public OnionArchitectureDbContext(DbContextOptions<OnionArchitectureDbContext> options) : base(options)
        {
        }
    }
}
