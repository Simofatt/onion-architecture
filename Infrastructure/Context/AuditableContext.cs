using Domain.Contracts;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{

    public  class AuditableContext : DbContext
    {
       // public DbSet<Author> Authors { get; set; }
       

        public AuditableContext(DbContextOptions<AuditableContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
