
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Products
{
    public class ProductsUpdateModel : ProductsBaseModel
    {
        public int productid { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser { get; set; }
    }
}
