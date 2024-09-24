

using Shop.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Entities
{
    public class Products : BaseEntity
    {
        [Key]
        public int productid { get; set; }
        public string? ProductName { get; set; }
        public int? supplierid { get; set; }
        public int? categoryid { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool? Discontinued { get; set; }

    }
}
