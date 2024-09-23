
using Shop.DAL.Models.Suppliers;

namespace Shop.DAL.Interfaces
{
    public interface ISuppliersDb
    {
        List<SuppliersModel> GetSuppliers();
        SuppliersModel GetSuppliers(int supplierid);
        void SaveSuppliers(SuppliersAddModel suppliersAdd);
        void UpdateSuppliers(SuppliersUpdateModel suppliersUpdate);
        void RemoveSuppliers(SuppliersRemoveModel suppliersRemove);
    }
}
