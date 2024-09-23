
using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Customers;

namespace Shop.DAL.Daos
{
    public class CustomersDb : ICustomersDb
    {
        private readonly ShopContext context;

        public CustomersDb(ShopContext context)
        {
            this.context = context;
        }
        public List<CustomersModel> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public CustomersModel GetCustomers(int custid)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomers(CustomersRemoveModel customersRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveCustomers(CustomersAddModel customersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomers(CustomersUpdateModel customersUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
