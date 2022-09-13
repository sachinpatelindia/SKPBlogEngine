using Microsoft.EntityFrameworkCore;
using SKPBlogEngine.Base.Domain;

namespace SKPBlogEngine.Web.System
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
