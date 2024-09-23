

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Suppliers
{
    public class SuppliersUpdateModel : SuppliersBaseModel
    {
        public int supplierid { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser { get; set; }
    }
}
