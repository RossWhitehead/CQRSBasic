using CQRSBasic.DataModel;
using System.Collections.Generic;

namespace CQRS.QueryStack.Queries
{
    public class ProductCategoriesQueryResult
    {
        public List<ProductCategory> ProductCategories { get; internal set; }
    }
}
