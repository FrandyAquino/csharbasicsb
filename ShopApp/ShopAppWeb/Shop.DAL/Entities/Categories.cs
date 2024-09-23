

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Categories : BaseEntity
    {
        public int categoryid { get; set; }
        public string? CategoryName {  get; set; }
        public string? Description { get; set; }
    }
}
