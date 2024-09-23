
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Categories
{
    public class CategoriesModel : CategoriesBaseModel
    {
        public int categoryid { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser {  get; set; }
    }
}
