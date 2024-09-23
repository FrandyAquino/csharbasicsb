
using Shop.DAL.Models.Products;

namespace Shop.DAL.Interfaces
{
    public interface IProductsDb
    {
        List<ProductsModel> GetProducts();
        ProductsModel GetProducts(int productid);
        void SaveProducts(ProductsAddModel productsAdd);
        void UpdateProducts(ProductsUpdateModel productsUpdate);
        void RemoveProducts(ProductsRemoveModel productsRemove);
    }
}
