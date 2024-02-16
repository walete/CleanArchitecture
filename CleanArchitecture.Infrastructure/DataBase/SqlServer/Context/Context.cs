using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.DataBase.SqlServer.Context
{
    public class Context(DbContextOptions<Context> options, IConfiguration config) : DbContext(options)
    {
        private readonly IConfiguration _configuration = config;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("CleanArchitecture"), b => b.MigrationsAssembly("CleanArchitecture.Api"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
