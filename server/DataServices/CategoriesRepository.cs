using Microsoft.EntityFrameworkCore;
using Server.DataServices;
using Server.Entities;
using Server.Interfaces;

namespace server.DataServices
{
    public class CategoriesRepository : ICostCategoryRepository
    {
        public DataContext _context { get; }

        public CategoriesRepository(DataContext context)
        {            _context = context;        }
        
             public async Task<CostCategory> GetCostCategoryByIdAsync(int id)
        {
                return await _context.CostCategories.FindAsync(id);
        } 
        
        
        public async Task<IEnumerable<CostCategory>> GetCostCategoriesAsync()
        {
            return await _context.CostCategories.
            Include(costs=>costs.CostAmounts).
            ToListAsync();
        }
    }
}