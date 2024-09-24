

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Customers
{
    public class CustomersUpdateModel : CustomersBaseModel
    {
        public int custid { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
    }
}
