
using Shop.DAL.Context;
using Shop.DAL.Entities;
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
            return context.Customers
                .Select(c => new CustomersModel
                {
                    custid = c.custid,
                    ContactName = c.ContactName,
                    Address = c.Address,
                    Phone = c.Phone
                })
                .ToList();
        }

        public CustomersModel GetCustomers(int custId)
        {
            if (custId <= 0)
                throw new ArgumentException("El ID del Customer es Invalido");

            var customer = context.Customers.Find(custId);
            if (customer == null)
                throw new KeyNotFoundException("Customer no encontrado");

            return new CustomersModel
            {
                custid = customer.custid,
                ContactName = customer.ContactName,
                Address = customer.Address,
                Phone = customer.Phone
            };
        }

        public void RemoveCustomers(CustomersRemoveModel customersRemove)
        {
            if (customersRemove == null || customersRemove.custid <= 0)
                throw new ArgumentException("El ID del Customer es Invalido");

            var customer = context.Customers.Find(customersRemove.custid);
            if (customer == null)
                throw new KeyNotFoundException("Customer no encontrado");

            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public void SaveCustomers(CustomersAddModel customersAdd)
        {
            if (customersAdd == null)
                throw new ArgumentException("El Customer no puede ser NULL");

            var newCustomer = new Customers
            {
                ContactName = customersAdd.ContactName,
                Address = customersAdd.Address,
                Phone = customersAdd.Phone
            };

            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void UpdateCustomers(CustomersUpdateModel customersUpdate)
        {
            if (customersUpdate == null || customersUpdate.custid <= 0)
                throw new ArgumentException("El ID del Customer es Invalido");

            var customer = context.Customers.Find(customersUpdate.custid);
            if (customer == null)
                throw new KeyNotFoundException("Customer no encontrado");

            customer.ContactName = customersUpdate.ContactName;
            customer.Address = customersUpdate.Address;
            customer.Phone = customersUpdate.Phone;

            context.SaveChanges();
        }
    }
}
