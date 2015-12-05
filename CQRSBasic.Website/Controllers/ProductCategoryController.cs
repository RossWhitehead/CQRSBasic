using CQRS.QueryStack.Queries;
using CQRSBasic.CommandStack.CommandHandlers;
using CQRSBasic.CommandStack.Commands;
using CQRSBasic.QueryStack.Queries;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CQRS.Website.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory
        public async Task<ActionResult> Index()
        {
            return View(await new ProductCategoriesQueryHandler().RetrieveAsync(new ProductCategoriesQuery()));
        }

        // GET: ProductCategory/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            //using (queryDb = new QueryDbContext())
            //{
            //    var queryResult = await queryDb.ProductCategoryViews.Where(pc => pc.ProductCategoryId == id).FirstOrDefaultAsync();
            //    if (queryResult == null)
            //    {
            //        return HttpNotFound();
            //    }

            //    return View(queryResult);
            //}    

            return null;
        }

        // GET: ProductCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductCategoryId, ProductCategoryName")] AddOrEditProductCategoryCommand command)
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

            return View(command);
        }

        // GET: ProductCategory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //using (queryDb = new QueryDbContext())
            //{
            //    var queryResult = await queryDb.ProductCategoryViews.Where(pc => pc.ProductCategoryId == id).FirstOrDefaultAsync();
            //    if (queryResult == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(queryResult);
            //}

            return null;
        }

        // POST: ProductCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductCategoryId,ProductCategoryName")] AddOrEditProductCategoryCommand command)
        {
            //if (ModelState.IsValid)
            //{
            //    using (commandDb = new CommandDbContext())
            //    {
            //        commandDb.Entry(productCategory).State = EntityState.Modified;
            //        await commandDb.SaveChangesAsync();
            //    }
            //    return RedirectToAction("Index");
            //}
            //return View(productCategory);

            return null;
        }

        // GET: ProductCategory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //using (queryDb = new QueryDbContext())
            //{
            //    var queryResult = await queryDb.ProductCategoryViews.Where(pc => pc.ProductCategoryId == id).FirstOrDefaultAsync();
            //    if (queryResult == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(queryResult);
            //}

            return null;
        }
  
        // POST: ProductCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            //using (commandDb = new CommandDbContext())
            //{
            //    ProductCategory productCategory = await commandDb.ProductCategories.FindAsync(id);
            //    commandDb.ProductCategories.Remove(productCategory);
            //    await commandDb.SaveChangesAsync();
            //}
            //return RedirectToAction("Index");

            return null;
        }
    }
}
