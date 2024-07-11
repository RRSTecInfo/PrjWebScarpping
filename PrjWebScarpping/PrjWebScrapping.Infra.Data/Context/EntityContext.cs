using Microsoft.EntityFrameworkCore;
using PrjWebScrapping.Domain.Model;
using PrjWebScrapping.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjWebScrapping.Infra.Data.Context
{
    public class EntityContext: DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {

        }

        public DbSet<SitioInternet> SitioInternet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SitioInternet>(new SitioInternetMapping().Configure);
        }
    }
}
