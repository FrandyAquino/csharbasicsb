

using Shop.DAL.Models.Categories;

namespace Shop.DAL.Interfaces
{
    public interface ICategoriesDb
    {
        List<CategoriesModel> GetCategories();
        CategoriesModel GetCategories(int CategoryId);
        void SaveCategories(CategoriesAddModel categoriesAdd);
        void UpdateCategories(CategoriesUpdateModel categoriesUpdate);
        void DeleteCategories(CategoriesRemoveModel categoriesRemove);
    }
}
