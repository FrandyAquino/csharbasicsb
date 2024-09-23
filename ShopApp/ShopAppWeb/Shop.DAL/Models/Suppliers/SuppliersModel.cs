
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Suppliers
{
    public class SuppliersModel : SuppliersBaseModel
    {
        public int supplierid { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
