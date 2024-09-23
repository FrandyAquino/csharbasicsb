
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Customers
{
    public class CustomersModel : CustomersBaseModel
    {
        public int custid { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
