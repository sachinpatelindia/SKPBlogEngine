using SKPBlogEngine.Base.Domain;

namespace SKPBlogEngine.Web.System
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Insert(T entity);
        T Delete(T entity);
        T GetById(object id);
        IQueryable<T> Table { get; }
    }
}
