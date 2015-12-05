namespace CQRSBasic.QueryStack.Queries
{
    public class ProductCategoryQuery
    {
        public int ProductCategoryId { get; }

        public ProductCategoryQuery(int productCategoryId)
        {
            this.ProductCategoryId = productCategoryId;
        }
    }
}
