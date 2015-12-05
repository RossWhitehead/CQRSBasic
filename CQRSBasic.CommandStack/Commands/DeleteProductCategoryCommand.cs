using System.ComponentModel.DataAnnotations;

namespace CQRSBasic.CommandStack.Commands
{
    public class DeleteProductCategoryCommand
    {
        public int ProductCategoryId { get; }

        public DeleteProductCategoryCommand(int productCategoryId)
        {
            this.ProductCategoryId = productCategoryId;
        }
    }
}
