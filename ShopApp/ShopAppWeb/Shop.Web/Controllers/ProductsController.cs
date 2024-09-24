using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Daos;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Products;

namespace Shop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsDb productsDb;

        public ProductsController(IProductsDb productsDb)
        {
            this.productsDb = productsDb;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            var products = productsDb.GetProducts();

            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product = this.productsDb.GetProducts(id);
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductsAddModel addModel)
        {
            try
            {
                addModel.creation_date = DateTime.Now;
                addModel.creation_user = 1;
                this.productsDb.SaveProducts(addModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            var products = this.productsDb.GetProducts(id);
            return View(products);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductsUpdateModel updateModel)
        {
            try
            {
                updateModel.modify_date = DateTime.Now;
                updateModel.modify_user = 1;

                this.productsDb.UpdateProducts(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
