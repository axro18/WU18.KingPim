using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<SubCategory, SubCategoryViewModel>().ReverseMap();
            CreateMap<SubCategoryViewModel, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));
            CreateMap<CategoryViewModel, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));
        }
    }
}
