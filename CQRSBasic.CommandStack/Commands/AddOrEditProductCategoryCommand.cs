using System.ComponentModel.DataAnnotations;

namespace CQRSBasic.CommandStack.Commands
{
    public class AddOrEditProductCategoryCommand
    {
        [Required]
        public int ProductCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductCategoryName { get; set; }
    }
}
