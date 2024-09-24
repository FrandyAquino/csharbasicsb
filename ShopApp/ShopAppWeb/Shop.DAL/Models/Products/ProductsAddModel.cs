
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Products
{
    public class ProductsAddModel : ProductsBaseModel
    {

        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
