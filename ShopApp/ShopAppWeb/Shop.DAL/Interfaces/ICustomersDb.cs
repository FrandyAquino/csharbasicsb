

using Shop.DAL.Models.Customers;

namespace Shop.DAL.Interfaces
{
    public interface ICustomersDb
    {
        List<CustomersModel> GetCustomers();
        CustomersModel GetCustomers(int custid);
        void SaveCustomers(CustomersAddModel customersAdd);
        void UpdateCustomers(CustomersUpdateModel customersUpdate);
        void RemoveCustomers(CustomersRemoveModel customersRemove);
    }
}
