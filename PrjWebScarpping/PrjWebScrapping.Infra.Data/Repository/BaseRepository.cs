using PrjWebScrapping.Domain.Interfaces;
using PrjWebScrapping.Domain.Model;
using PrjWebScrapping.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace PrjWebScrapping.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly EntityContext _entityContext;

        public BaseRepository(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public void Insert(TEntity obj)
        {
            _entityContext.Set<TEntity>().Add(obj);
            _entityContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _entityContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _entityContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _entityContext.Set<TEntity>().Remove(Select(id));
            _entityContext.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _entityContext.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _entityContext.Set<TEntity>().Find(id);

    }
}
