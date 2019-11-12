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
        public CategoryViewModel Category { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        public int CategoryId { get; set; }
    }
}
