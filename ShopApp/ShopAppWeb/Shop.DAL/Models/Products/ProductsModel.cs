
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Products
{
    public class ProductsModel : ProductsBaseModel
    {
        public int productid { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user {  get; set; }
    }
}
