using System;
using System.Collections.Generic;
using System.Text;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
