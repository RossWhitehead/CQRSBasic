using CQRSBasic.CommandData;
using CQRSBasic.CommandStack.Commands;
using CQRSBasic.DataModel;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CQRSBasic.CommandStack.CommandHandlers
{
    public class DeleteProductCategoryCommandHandler
    {
        public async Task<CommandResult> ExecuteAsync(DeleteProductCategoryCommand command)
        {
            CommandResult result = new CommandResult();

            using (CommandDbContext db = new CommandDbContext())
            {
                // If an updated record, retrieve it from the context and apply the updates
                ProductCategory productCategory = await db.ProductCategories.FindAsync(command.ProductCategoryId);
                if (productCategory != null)
                {
                    db.Entry(productCategory).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                    result.Success = true;
                }
                else
                {
                    result.Message = "Product Category not found.";
                }
            }

            return result;
        }
    }
}
