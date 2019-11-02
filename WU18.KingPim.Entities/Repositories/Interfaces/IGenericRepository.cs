using System.Collections.Generic;

namespace WU18.KingPim.Entities.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();
    }
}