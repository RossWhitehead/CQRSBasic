using System.ComponentModel.DataAnnotations;

namespace CQRSBasic.CommandStack.Commands
{
    public class DeleteProductCategoryCommand
    {
        [Required]
        public int ProductCategoryId { get; set; }
    }
}
