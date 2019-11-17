using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WU18.KingPim.Entities.ViewModels
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public CategoryViewModel Category { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> SubCategorySelectList { get; set; }
        public int SelectedSubCategoryId { get; set; }
    }
}
