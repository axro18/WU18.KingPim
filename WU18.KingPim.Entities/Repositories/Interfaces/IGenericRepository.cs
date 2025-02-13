﻿using System.Linq;

namespace WU18.KingPim.Entities.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> FindAll();
        void AddItem(TEntity entity);
        void RemoveItem(int id);
        TEntity FindById(int id);
        void EditItem(TEntity entity);
    }
}