

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Categories
{
    public class CategoriesAddModel : CategoriesBaseModel
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }

    }
}
