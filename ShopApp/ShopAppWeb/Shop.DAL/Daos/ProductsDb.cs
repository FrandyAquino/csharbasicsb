using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Products;
using Shop.DAL.Entities; 

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
            return context.Products
                .Select(p => new ProductsModel
                {
                    productid = p.productid,
                    ProductName = p.ProductName,
                    supplierid = p.supplierid,
                    categoryid = p.categoryid,
                    UnitPrice = p.UnitPrice,
                    Discontinued = p.Discontinued
                })
                .ToList();
        }

        public ProductsModel GetProducts(int productid)
        {
            if (productid <= 0)
                throw new ArgumentException("El ID del Producto es Invalido");

            var product = context.Products.Find(productid);
            if (product == null)
                throw new KeyNotFoundException("Producto no encontrado");

            return new ProductsModel
            {
                productid = product.productid,
                ProductName = product.ProductName,
                supplierid = product.supplierid,
                categoryid = product.categoryid,
                UnitPrice = product.UnitPrice,
                Discontinued = product.Discontinued
            };
        }

        public void RemoveProducts(ProductsRemoveModel productsRemove)
        {
            if (productsRemove == null || productsRemove.productid <= 0)
                throw new ArgumentException("El ID del Producto es Invalido");

            var product = context.Products.Find(productsRemove.productid);
            if (product == null)
                throw new KeyNotFoundException("Producto no encontrado");

            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void SaveProducts(ProductsAddModel productsAdd)
        {
            if (productsAdd == null)
                throw new ArgumentException("El producto no puede ser NULL");

            var newProduct = new Products
            {
                ProductName = productsAdd.ProductName,
                supplierid = productsAdd.supplierid,
                categoryid = productsAdd.categoryid,
                UnitPrice = productsAdd.UnitPrice,
                Discontinued = productsAdd.Discontinued
            };

            context.Products.Add(newProduct);
            context.SaveChanges();
        }

        public void UpdateProducts(ProductsUpdateModel productsUpdate)
        {
            if (productsUpdate == null || productsUpdate.productid <= 0)
                throw new ArgumentException("El ID del Producto es Invalido");

            var product = context.Products.Find(productsUpdate.productid);
            if (product == null)
                throw new KeyNotFoundException("Producto no encontrado");

            product.ProductName = productsUpdate.ProductName;
            product.supplierid = productsUpdate.supplierid;
            product.categoryid = productsUpdate.categoryid;
            product.UnitPrice = productsUpdate.UnitPrice;
            product.Discontinued = productsUpdate.Discontinued;

            context.SaveChanges();
        }
    }
}
