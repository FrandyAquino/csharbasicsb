using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Daos;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Suppliers;

namespace Shop.Web.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISuppliersDb suppliersDb;

        public SuppliersController(ISuppliersDb suppliersDb)
        {
            this.suppliersDb = suppliersDb;
        }
        // GET: SuppliersController
        public ActionResult Index()
        {
            var suppliers = suppliersDb.GetSuppliers();

            return View(suppliers);
        }

        // GET: SuppliersController/Details/5
        public ActionResult Details(int id)
        {
            var supplier = this.suppliersDb.GetSuppliers(id);
            return View(supplier);
        }

        // GET: SuppliersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuppliersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuppliersAddModel addModel)
        {
            try
            {
                addModel.creation_date = DateTime.Now;
                addModel.creation_user = 1;
                this.suppliersDb.SaveSuppliers(addModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuppliersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuppliersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SuppliersUpdateModel updateModel)
        {
            try
            {
                updateModel.modify_date = DateTime.Now;
                updateModel.modify_user = 1;

                this.suppliersDb.UpdateSuppliers(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
