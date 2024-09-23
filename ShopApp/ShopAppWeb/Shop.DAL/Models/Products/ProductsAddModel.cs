
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Products
{
    public class ProductsAddModel : ProductsBaseModel
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
