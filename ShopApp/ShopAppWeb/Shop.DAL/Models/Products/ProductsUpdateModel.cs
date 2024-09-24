
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Products
{
    public class ProductsUpdateModel : ProductsBaseModel
    {
        public int productid { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
    }
}
