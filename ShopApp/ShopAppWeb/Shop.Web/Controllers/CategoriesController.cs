using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Categories;

namespace Shop.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesDb categoriesDb;

        public CategoriesController(ICategoriesDb categoriesDb)
        {
            this.categoriesDb = categoriesDb;
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            var categories = categoriesDb.GetCategories();

            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var category = this.categoriesDb.GetCategories(id);
            return View(category);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesAddModel addModel)
        {
            try
            {
                addModel.creation_date = DateTime.Now;
                addModel.creation_user = 1;
                this.categoriesDb.SaveCategories(addModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var categories = this.categoriesDb.GetCategories(id);
            return View(categories);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesUpdateModel updateModel)
        {
            try
            {
                updateModel.modify_date = DateTime.Now;
                updateModel.modify_user = 1;

                this.categoriesDb.UpdateCategories(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } 
    }
}
