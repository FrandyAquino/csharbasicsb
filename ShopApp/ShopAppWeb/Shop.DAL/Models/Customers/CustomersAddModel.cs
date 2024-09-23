

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Customers 
{
    public class CustomersAddModel : CustomersBaseModel
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
    }
}
