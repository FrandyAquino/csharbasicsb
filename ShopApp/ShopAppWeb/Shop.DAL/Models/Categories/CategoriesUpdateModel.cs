
using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Categories
{
    public class CategoriesUpdateModel : CategoriesBaseModel
    {
        public int categoryid { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser { get; set; }
    }
}
