using System.Collections.Generic;

namespace WU18.KingPim.Data.Models
{
    public class SubCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public int CategoryId { get; set; }
    }
}
