

using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Products;

namespace Shop.DAL.Daos
{
    public class ProductsDb : IProductsDb
    {
        private readonly ShopContext context;

        public ProductsDb(ShopContext context)
        {
            this.context = context;
        }
        public List<ProductsModel> GetProducts()
        {
            throw new NotImplementedException();
        }

        public ProductsModel GetProducts(int productid)
        {
            throw new NotImplementedException();
        }

        public void RemoveProducts(ProductsRemoveModel productsRemove)
        {
            throw new NotImplementedException();
        }

        public void SaveProducts(ProductsAddModel productsAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateProducts(ProductsUpdateModel productsUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
