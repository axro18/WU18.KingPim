using System.Collections.Generic;
using System.Linq;
using WU18.KingPim.Data.DataAccess;

namespace WU18.KingPim.Entities.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class /*IEntity*/
    {
        private readonly KingPimContext _ctx;

        public GenericRepository(KingPimContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<TEntity> FindAll()
        {
            return _ctx.Set<TEntity>().ToList();
        }
    }
}