

namespace Shop.DAL.Models.BaseModels
{
    public class ProductsBaseModel
    {
        public string? ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}
