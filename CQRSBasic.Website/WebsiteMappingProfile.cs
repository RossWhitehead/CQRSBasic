using AutoMapper;
using CQRS.QueryStack.Queries;
using CQRSBasic.CommandStack.Commands;
using CQRSBasic.Website.Models;

namespace CQRSBasic.Website
{
    public class WebsiteMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProductCategoriesQueryResult, ProductCategoryIndexViewModel>();
            Mapper.CreateMap<AddOrEditProductCategoryCommand, ProductCategoryViewModel>();
            Mapper.CreateMap<ProductCategoryQueryResult, ProductCategoryViewModel>();

            base.Configure();
        }
    }
}
