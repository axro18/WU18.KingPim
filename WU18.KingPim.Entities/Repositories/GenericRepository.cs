using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly KingPimContext _ctx;

        protected GenericRepository(KingPimContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<TEntity> FindAll()
        {
            return _ctx.Set<TEntity>().AsNoTracking();
        }

        public void AddItem(TEntity entity)
        {
            _ctx.Add(entity);
            _ctx.SaveChanges();
        }

        public void RemoveItem(int id)
        {
            var entity = FindById(id);
            _ctx.Set<TEntity>().Remove(entity);
            _ctx.SaveChanges();
        }

        public TEntity FindById(int id)
        {
            return _ctx.Set<TEntity>().AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public void EditItem(TEntity entity)
        {
            _ctx.Set<TEntity>().Update(entity);
            _ctx.SaveChanges();
        }
    }
}