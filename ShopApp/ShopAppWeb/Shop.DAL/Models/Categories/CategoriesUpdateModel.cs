
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Categories
{
    public class CategoriesUpdateModel : CategoriesBaseModel
    {
        public int categoryid { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
    }
}
