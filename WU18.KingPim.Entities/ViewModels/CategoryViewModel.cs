using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WU18.KingPim.Entities.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<SubCategoryViewModel> SubCategories { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public int SelectedCategory { get; set; }
    }
}
