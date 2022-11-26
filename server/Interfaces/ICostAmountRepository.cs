using Server.Entities;

namespace Server.Interfaces
{
public interface ICostAmountRepository
{
    Task<CostAmount> GetCostAmountByIdAsync(int id);
    Task<IEnumerable<CostAmount>> GetCostAmountsAsync();
}
}

