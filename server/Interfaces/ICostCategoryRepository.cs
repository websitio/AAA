using Server.Entities;


namespace Server.Interfaces
{


public interface ICostCategoryRepository
{
    
    Task<CostCategory> GetCostCategoryByIdAsync(int id);

    Task<IEnumerable<CostCategory>> GetCostCategoriesAsync();

}

}