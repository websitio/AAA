using Microsoft.EntityFrameworkCore;
using Server.DataServices;
using Server.Entities;
using Server.Interfaces;

namespace Server.DataServices
{
    public class CostsRepository : ICostAmountRepository
    {
     
        private readonly DataContext _context;
            
        public CostsRepository(DataContext context)
        {  _context = context;}

    
   
       public async Task<CostAmount> GetCostAmountByIdAsync(int id)
       {
           return await _context.CostAmounts.FindAsync(id);
       }

       public async Task<IEnumerable<CostAmount>> GetCostAmountsAsync()
       {
          return await _context.CostAmounts.ToListAsync();
       }





    }
}