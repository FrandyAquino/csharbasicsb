

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Customers : ContactInfo
    {
        public int custid { get; set; }
        public string? Email { get; set; }
    }
}
