using System.Collections.Generic;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly KingPimContext ctx;

        public CategoryRepository(KingPimContext context)
        {
            this.ctx = context;
        }

        public IEnumerable<Category> Categories => ctx.Categories;
    }
}