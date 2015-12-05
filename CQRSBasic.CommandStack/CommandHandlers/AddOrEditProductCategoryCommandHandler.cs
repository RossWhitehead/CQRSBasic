using AutoMapper;
using CQRSBasic.CommandData;
using CQRSBasic.CommandStack.Commands;
using CQRSBasic.DataModel;
using System.Threading.Tasks;

namespace CQRSBasic.CommandStack.CommandHandlers
{
    public class AddOrEditProductCategoryCommandHandler 
    {
        public async Task<CommandResult> ExecuteAsync(AddOrEditProductCategoryCommand command)
        {
            // TODO Add validation
            CommandResult result = new CommandResult() { Success = true };

            using (CommandDbContext db = new CommandDbContext())
            {
                // If a new record, create a new entity, map the command to the domain object and add it to the context
                if (command.ProductCategoryId == 0)
                {
                    db.ProductCategories.Add(Mapper.Map<ProductCategory>(command));
                }
                else
                {
                    // If an updated record, retrieve it from the context and apply the updates
                    ProductCategory productCategory = await db.ProductCategories.FindAsync(command.ProductCategoryId);
                    if (productCategory != null)
                    {
                        Mapper.Map(command, productCategory);
                    }
                    else
                    {
                        result.Success = false;
                        result.Message = "Product Category not found.";
                    }
                }

                if (result.Success)
                {
                    // Commit data  changes
                    await db.SaveChangesAsync();
                }
            }

            return result;
        }
    }
}
