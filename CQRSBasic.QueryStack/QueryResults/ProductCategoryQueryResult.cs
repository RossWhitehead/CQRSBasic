using CQRSBasic.DataModel;
using System.Collections.Generic;

namespace CQRS.QueryStack.Queries
{
    public class ProductCategoryQueryResult
    {
        public int ProductCategoryId { get; internal set; }

        public string ProductCategoryName { get; internal set; }
    }
}
