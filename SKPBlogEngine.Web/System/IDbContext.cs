using Microsoft.EntityFrameworkCore;

namespace SKPBlogEngine.Web.System
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
