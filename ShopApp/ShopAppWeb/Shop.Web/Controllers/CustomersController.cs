using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.DAL.Daos;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Customers;

namespace Shop.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersDb customersDb;

        public CustomersController(ICustomersDb customersDb)
        {
            this.customersDb = customersDb;
        }
        // GET: CustomersController
        public ActionResult Index()
        {
            var customers = customersDb.GetCustomers();

            return View(customers);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            var customer = this.customersDb.GetCustomers(id);
            return View(customer);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomersAddModel addModel)
        {
            try
            {
                addModel.creation_date = DateTime.Now;
                addModel.creation_user = 1;
                this.customersDb.SaveCustomers(addModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomersUpdateModel updateModel)
        {
            try
            {
                updateModel.modify_date = DateTime.Now;
                updateModel.modify_user = 1;

                this.customersDb.UpdateCustomers(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
