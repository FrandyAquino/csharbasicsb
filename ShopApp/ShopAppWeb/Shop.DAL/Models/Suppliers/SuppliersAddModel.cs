

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Suppliers
{
    public class SuppliersAddModel : SuppliersBaseModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
