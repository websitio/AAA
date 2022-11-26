using Microsoft.EntityFrameworkCore;
using Server.DataServices;
using Server.Entities;
using Server.Interfaces;
                                // PERHAPS I SHOULD ALSO HAVE A SEPERATE COSTS DATASET FOR THE COSTS REPOSITORY
namespace Server.DataServices
{
    public class CostsRepository : ICostAmountRepository
    {
     
        private readonly CostsContext _context;
            
        public CostsRepository(CostsContext context)
        {  _context = context;}

       /**/
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