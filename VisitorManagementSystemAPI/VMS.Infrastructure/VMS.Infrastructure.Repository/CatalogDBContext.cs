using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using VMS.Core.Domain.Models.Admin;
using VMS.Core.Domain.Models.VisitorForm;


namespace VMS.Infrastructure.VMS.Infrastructure.Repository
{
    public class CatalogDBContext : DbContext
    {

        public CatalogDBContext(DbContextOptions<CatalogDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Visitor> Visitor { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}

