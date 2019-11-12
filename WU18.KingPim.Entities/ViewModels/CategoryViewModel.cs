using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubCategoryViewModel> SubCategories { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
