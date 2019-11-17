using System;
using System.ComponentModel.DataAnnotations;

namespace WU18.KingPim.Entities.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ArtNumber { get; set; }
        public int PackageWidth { get; set; }
        public int PackageHeight { get; set; }
        public int PackageDepth { get; set; }
        public int PackageWeight { get; set; }
        public string ModifiedBy { get; set; }
        public bool Publish { get; set; }
        public bool Discontinued { get; set; }
        public int StockBalance { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public decimal CampaignPrice { get; set; }
        public SubCategoryViewModel SubCategory { get; set; }
        public DateTime? StartCampaign { get; set; }
        public DateTime? EndCampaign { get; set; }
        public decimal PriceExVat { get; set; }
        public int SubCategoryId { get; set; }
    }
}
