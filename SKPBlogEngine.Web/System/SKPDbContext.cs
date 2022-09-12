using Microsoft.EntityFrameworkCore;
using SKPBlogEngine.Web.System.Entities;
using System;
using System.IO;
namespace SKPBlogEngine.Web.System
{
    public class SKPDbContext:DbContext, IDbContext
    {
      
        private readonly IConfiguration _configuration;
        public SKPDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity:BaseEntity
        {
            return base.Set<TEntity>();
        }
        private string DbPath => _configuration.GetValue<string>("Database:FilePath");

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable(nameof(Member));
            modelBuilder.Entity<Member>().HasKey(m=>m.Id);
        }
    }
}
