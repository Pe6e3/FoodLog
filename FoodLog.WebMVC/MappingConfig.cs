using AutoMapper;
using FoodLog.DAL.Entities;
using FoodLog.WebMVC.ViewModels;

namespace Portal.Web
{
    public class MappingConfig : Profile
    {

        public MappingConfig()
        {
            CreateMap<StorageLineVM, ProductStorage>()
                .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.Guid))
                .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
                .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.CurrentWeight))
                .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.GuidOfPurchase))
                .ForMember(dest => dest.ProductGuid, opt => opt.MapFrom(src => src.ProductGuid));

            CreateMap<ProductStorage, StorageLineVM>()
               .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
               .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.Purchase.Price * src.CurrentWeight / 1000))
               .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.CurrentWeight))
               .ForMember(dest => dest.ProductGuid, opt => opt.MapFrom(src => src.ProductGuid))
               .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.GuidOfPurchase))
               .ForPath(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));



            CreateMap<Product, ProductCatPercentVM>()
               .ForMember(dest => dest.ProductGuid, opt => opt.MapFrom(src => src.Guid))
               .ForMember(dest => dest.PercentSum, opt => opt.Ignore())
               .ForMember(dest => dest.CategoryList, opt => opt.Ignore());




        }
    }
}
