
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Categories
{
    public class CategoriesModel : CategoriesBaseModel
    {
        public int categoryid { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user {  get; set; }
    }
}
