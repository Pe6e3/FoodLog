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
                .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.Guid))
                .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
                .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.CurrentWeight))
                .ForMember(dest => dest.WeightConsume, opt => opt.MapFrom(src => src.WeightConsume))
                .ForMember(dest => dest.WeightRemainsAfter, opt => opt.MapFrom(src => src.WeightRemainsAfter))
                .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.GuidOfPurchase))
                .ForMember(dest => dest.ProductGuid, opt => opt.MapFrom(src => src.ProductGuid));

            CreateMap<StorageProduct, StorageLineVM>()
               .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
               .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.CurrentCost))
               .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.CurrentWeight))
               .ForMember(dest => dest.ProductGuid, opt => opt.MapFrom(src => src.ProductGuid))
               .ForMember(dest => dest.WeightConsume, opt => opt.MapFrom(src => src.WeightConsume))
                .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.GuidOfPurchase))
               .ForMember(dest => dest.WeightRemainsAfter, opt => opt.MapFrom(src => src.WeightRemainsAfter))
               .ForPath(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));

            //CreateMap<Purchase, StorageProduct>()
            //    .ForMember(dest => dest.ProductGuid, opt => opt.MapFrom(src => src.ProductGuid))
            //    .ForMember(dest => dest.CurrentWeight, opt => opt.MapFrom(src => src.Weight))
            //    .ForMember(dest => dest.GuidOfPurchase, opt => opt.MapFrom(src => src.Guid))
            //    .ForMember(dest => dest.CurrentCost, opt => opt.MapFrom(src => src.Cost));

        }
    }
}
