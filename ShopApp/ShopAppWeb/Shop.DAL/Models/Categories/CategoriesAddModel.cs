

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Categories
{
    public class CategoriesAddModel : CategoriesBaseModel
    {
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }

    }
}
