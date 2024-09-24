
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Suppliers
{
    public class SuppliersModel : SuppliersBaseModel
    {
        public int supplierid { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
