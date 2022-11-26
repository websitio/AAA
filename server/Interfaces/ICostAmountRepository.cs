using Server.Entities;

namespace Server.Interfaces
{
    public interface ICostAmountRepository
    {
        Task<Cost> GetCostAmountByIdAsync(int id);
        Task<IEnumerable<Cost>> GetCostAmountsAsync();
    }
}

