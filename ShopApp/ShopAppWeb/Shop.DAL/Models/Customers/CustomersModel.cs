
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Customers
{
    public class CustomersModel : CustomersBaseModel
    {
        public int custid { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
