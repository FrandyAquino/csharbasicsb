

using Shop.DAL.Context;
using Shop.DAL.Interfaces;
using Shop.DAL.Models.Categories;

namespace Shop.DAL.Daos
{
    public class CategoriesDb : ICategoriesDb
    {
        private readonly ShopContext context;

        public CategoriesDb(ShopContext context)
        {
            this.context = context;
        }
        public void DeleteCategories(CategoriesRemoveModel categoriesRemove)
        {
            throw new NotImplementedException();
        }

        public List<CategoriesModel> GetCategories()
        {
            throw new NotImplementedException();
        }

        public CategoriesModel GetCategories(int categoryid)
        {
            throw new NotImplementedException();
        }

        public void SaveCategories(CategoriesAddModel categoriesAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategories(CategoriesUpdateModel categoriesUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
