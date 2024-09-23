

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Customers
{
    public class CustomersUpdateModel : CustomersBaseModel
    {
        public int custid { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
    }
}
