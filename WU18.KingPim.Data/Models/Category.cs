using System.Collections.Generic;

namespace WU18.KingPim.Data.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
    }
}
