

using Shop.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Entities
{
    public class Categories : BaseEntity
    {
        [Key]
        public int categoryid { get; set; }
        public string? categoryname {  get; set; }
        public string? description { get; set; }
    }
}
