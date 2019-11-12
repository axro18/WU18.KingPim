using System;
using System.Collections.Generic;
using System.Text;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubCategoryViewModel> SubCategories { get; set; }
    }
}
