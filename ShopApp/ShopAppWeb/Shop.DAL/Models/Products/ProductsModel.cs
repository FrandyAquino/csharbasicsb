
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Products
{
    public class ProductsModel : ProductsBaseModel
    {
        public int productid { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser {  get; set; }
    }
}
