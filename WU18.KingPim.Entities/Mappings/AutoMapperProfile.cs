using AutoMapper;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
