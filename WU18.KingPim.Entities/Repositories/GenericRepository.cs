using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.DataAccess;

namespace WU18.KingPim.Entities.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class /*IEntity*/
    {
        protected readonly KingPimContext _ctx;

        public GenericRepository(KingPimContext ctx)
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
    }
}