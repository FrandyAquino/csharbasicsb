

using Shop.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Entities
{
    public class Customers : ContactInfo
    {
        [Key]
        public int custid { get; set; }
        public string? Email { get; set; }
    }
}
