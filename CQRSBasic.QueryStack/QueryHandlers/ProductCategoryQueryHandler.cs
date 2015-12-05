using AutoMapper;
using CQRSBasic.DataModel;
using CQRSBasic.QueryData;
using CQRSBasic.QueryStack.Queries;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CQRS.QueryStack.Queries
{
    public class ProductCategoryQueryHandler
    {
        public async Task<ProductCategoryQueryResult> RetrieveAsync(ProductCategoryQuery query)
        {
            using (QueryDbContext db = new QueryDbContext())
            {
                var productCategory = await db.ProductCategories.FirstOrDefaultAsync(pc => pc.ProductCategoryId == query.ProductCategoryId);
                return Mapper.Map<ProductCategoryQueryResult>(productCategory);
            }
        }
    }
}
