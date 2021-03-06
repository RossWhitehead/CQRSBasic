﻿using System.Web.Mvc;

namespace CQRS.Website.Controllers
{
    public class ProductController : Controller
    {
        //private CommandDbContext db = new CommandDbContext();

        //// GET: Product
        //public async Task<ActionResult> Index()
        //{
        //    var products = db.Products.Include(p => p.ProductCategory);
        //    return View(await products.ToListAsync());
        //}

        //// GET: Product/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = await db.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        //// GET: Product/Create
        //public ActionResult Create()
        //{
        //    ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "ProductCategoryId", "ProductCategoryName");
        //    return View();
        //}

        //// POST: Product/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "ProductId,ProductName,ProductCategoryId")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Products.Add(product);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Details", product.ProductId);
        //    }

        //    ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "ProductCategoryId", "ProductCategoryName", product.ProductCategoryId);
        //    return View(product);
        //}

        //// GET: Product/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = await db.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "ProductCategoryId", "ProductCategoryName", product.ProductCategoryId);
        //    return View(product);
        //}

        //// POST: Product/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "ProductId,ProductName,ProductCategoryId")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(product).State = EntityState.Modified;
        //        await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "ProductCategoryId", "ProductCategoryName", product.ProductCategoryId);
        //    return View(product);
        //}

        //// GET: Product/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = await db.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        //// POST: Product/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Product product = await db.Products.FindAsync(id);
        //    db.Products.Remove(product);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
