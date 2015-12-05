using AutoMapper;
using CQRS.QueryStack.Queries;
using CQRSBasic.DataModel;

namespace CQRS.QueryStack
{
    public class QueryStackMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProductCategory, ProductCategoryQueryResult>();
            base.Configure();
        }
    }
}
