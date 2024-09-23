

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Products : BaseEntity
    {
        public int productid { get; set; }
        public string? ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? Discontinued { get; set; }

    }
}
