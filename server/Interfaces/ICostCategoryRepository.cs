using Server.Entities;


namespace Server.Interfaces
{


    public interface ICostCategoryRepository
    {

        Task<Category> GetCostCategoryByIdAsync(int id);

        Task<IEnumerable<Category>> GetCostCategoriesAsync();

    }

}