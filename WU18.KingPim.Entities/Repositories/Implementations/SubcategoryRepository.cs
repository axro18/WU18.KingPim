using System.Collections.Generic;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class SubcategoryRepository : ISubCategoryRepository
    {
        private readonly KingPimContext ctx;

        public SubcategoryRepository(KingPimContext context)
        {
            this.ctx = context;
        }

        public IEnumerable<SubCategory> SubCategories => ctx.SubCategories;
    }
}