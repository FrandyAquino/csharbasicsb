

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Suppliers
{
    public class SuppliersAddModel : SuppliersBaseModel
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
