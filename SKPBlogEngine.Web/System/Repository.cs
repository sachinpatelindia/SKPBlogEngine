using Microsoft.EntityFrameworkCore;
using SKPBlogEngine.Base.Domain;

namespace SKPBlogEngine.Web.System
{
    public class Repository<T>:IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _dbContext;
        private DbSet<T> _dbSet;

        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Table => this.Entities;

        public T GetById(object id)
        {
            if(id == null)
                throw new ArgumentNullException("id");
            return this.Entities.Find(id);
        }

        public T Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            try
            {
                this.Entities.Add(entity);
                _dbContext.SaveChanges();
            }
            catch(DbUpdateException exception)
            {
                throw new Exception(exception.Message);
            }
            return entity;
        }

        public T Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            this.Entities.Remove(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        private DbSet<T> Entities
        {
            get
            {
                if(_dbSet==null)
                    _dbSet = _dbContext.Set<T>();
                return _dbSet;
            }
        }
    }
}
