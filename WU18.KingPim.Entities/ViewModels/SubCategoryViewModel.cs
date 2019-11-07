using System;
using System.Collections.Generic;
using System.Text;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.ViewModels
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public int CategoryId { get; set; }
    }
}
