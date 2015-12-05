using CQRSBasic.QueryData;
using CQRSBasic.QueryStack.Queries;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CQRS.QueryStack.Queries
{
    public class ProductCategoriesQueryHandler
    {
        public async Task<ProductCategoriesQueryResult> RetrieveAsync(ProductCategoriesQuery query)
        {
            using (QueryDbContext db = new QueryDbContext())
            {
                return new ProductCategoriesQueryResult() { ProductCategories = await db.ProductCategories.ToListAsync() };
            }
        }
    }
}
