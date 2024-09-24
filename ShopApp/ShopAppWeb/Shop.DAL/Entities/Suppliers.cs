
using Shop.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Entities
{
    public class Suppliers : ContactInfo
    {
        [Key]
        public int supplierid { get; set; }
    }
}
