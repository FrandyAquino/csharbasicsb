

using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Suppliers;

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
            throw new NotImplementedException();
        }

        public SuppliersModel GetSuppliers(int supplierid)
        {
            throw new NotImplementedException();
        }

        public void RemoveSuppliers(SuppliersRemoveModel suppliersRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveSuppliers(SuppliersAddModel suppliersAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateSuppliers(SuppliersUpdateModel suppliersUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
