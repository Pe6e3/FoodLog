using AutoMapper;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;

namespace Portal.Web
{
    public class MappingConfig : Profile
    {

        public MappingConfig()
        {
            CreateMap<StorageLineVM, StorageProduct>()
                .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
                .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
                .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.CurrentWeight))
                .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
                .ForPath(dest => dest.Product.Name, opt => opt.MapFrom(src => src.ProductName));

            CreateMap<StorageProduct, StorageLineVM>()
               .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
               .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
               .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.CurrentWeight))
               .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
               .ForPath(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

        }
    }
}
