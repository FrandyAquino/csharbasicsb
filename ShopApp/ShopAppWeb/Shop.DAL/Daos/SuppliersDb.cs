using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Suppliers;
using Shop.DAL.Entities; 

namespace Shop.DAL.Daos
{
    public class SuppliersDb : ISuppliersDb
    {
        private readonly ShopContext context;

        public SuppliersDb(ShopContext context)
        {
            this.context = context;
        }

        public List<SuppliersModel> GetSuppliers()
        {
            return context.Suppliers
                .Select(s => new SuppliersModel
                {
                    supplierid = s.supplierid,
                    ContactName = s.ContactName, 
                    Address = s.Address, 
                    Phone = s.Phone 
                })
                .ToList();
        }

        public SuppliersModel GetSuppliers(int supplierid)
        {
            if (supplierid <= 0)
                throw new ArgumentException("ID de Supplier no encontrada");

            var supplier = context.Suppliers.Find(supplierid);
            if (supplier == null)
                throw new KeyNotFoundException("Supplier no encontrado");

            return new SuppliersModel
            {
                supplierid = supplier.supplierid,
                ContactName = supplier.ContactName,
                Address = supplier.Address,
                Phone = supplier.Phone
            };
        }

        public void RemoveSuppliers(SuppliersRemoveModel suppliersRemove)
        {
            if (suppliersRemove == null || suppliersRemove.supplierid <= 0)
                throw new ArgumentException("ID de Supplier no encontrada");

            var supplier = context.Suppliers.Find(suppliersRemove.supplierid);
            if (supplier == null)
                throw new KeyNotFoundException("Supplier no encontrado");

            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }

        public void SaveSuppliers(SuppliersAddModel suppliersAdd)
        {
            if (suppliersAdd == null)
                throw new ArgumentException("No puede ser null");

            var newSupplier = new Suppliers
            {
                ContactName = suppliersAdd.ContactName,
                Address = suppliersAdd.Address,
                Phone = suppliersAdd.Phone
            };

            context.Suppliers.Add(newSupplier);
            context.SaveChanges();
        }

        public void UpdateSuppliers(SuppliersUpdateModel suppliersUpdate)
        {
            if (suppliersUpdate == null || suppliersUpdate.supplierid <= 0)
                throw new ArgumentException("ID de Supplier no encontrada");

            var supplier = context.Suppliers.Find(suppliersUpdate.supplierid);
            if (supplier == null)
                throw new KeyNotFoundException("Supplier no encontrado");

            supplier.ContactName = suppliersUpdate.ContactName;
            supplier.Address = suppliersUpdate.Address;
            supplier.Phone = suppliersUpdate.Phone;

            context.SaveChanges();
        }
    }
}
