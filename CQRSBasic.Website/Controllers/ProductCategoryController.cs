using AutoMapper;
using CQRS.QueryStack.Queries;
using CQRSBasic.CommandStack.CommandHandlers;
using CQRSBasic.CommandStack.Commands;
using CQRSBasic.QueryStack.Queries;
using CQRSBasic.Website.Models;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CQRS.Website.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory
        public async Task<ActionResult> Index()
        {
            var vm = Mapper.Map<ProductCategoryIndexViewModel>(await new ProductCategoriesQueryHandler().RetrieveAsync(new ProductCategoriesQuery()));
            return View("Index", vm);
        }

        // GET: ProductCategory/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            return await GetByIdAsync("Details", id);
        }

        // GET: ProductCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductCategoryId, ProductCategoryName")] AddOrEditProductCategoryCommand command)
        {
            return await AddOrEditAsync("Create", command);
        }

        // GET: ProductCategory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            return await GetByIdAsync("Edit", id);
        }

        // POST: ProductCategory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductCategoryId,ProductCategoryName")] AddOrEditProductCategoryCommand command)
        {
            return await AddOrEditAsync("Edit", command);
        }

        // GET: ProductCategory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            return await GetByIdAsync("Delete", id);
        }

        // POST: ProductCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var commandResult = await new DeleteProductCategoryCommandHandler().ExecuteAsync(new DeleteProductCategoryCommand((int)id));
            return RedirectToAction("Index");
        }

        #region Helpers
        private async Task<ActionResult> GetByIdAsync(string viewName, int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var queryResult = await new ProductCategoryQueryHandler().RetrieveAsync(new ProductCategoryQuery((int)id));

            if (queryResult == null)
            {
                return HttpNotFound();
            }

            return View(viewName, Mapper.Map<ProductCategoryViewModel>(queryResult));
        }

        private async Task<ActionResult> AddOrEditAsync(string viewName, AddOrEditProductCategoryCommand command)
        {
            if (ModelState.IsValid)
            {
                var commandResult = await new AddOrEditProductCategoryCommandHandler().ExecuteAsync(command);
                if (commandResult.Success)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(null, commandResult.Message);
                }
            }

            return View(viewName, Mapper.Map<ProductCategoryViewModel>(command));
        }
        #endregion
    }


}
