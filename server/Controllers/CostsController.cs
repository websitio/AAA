using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Interfaces;

namespace Server.Controllers
{

    [Route("api/[controller]")]
    public class CostsController : Controller
    {
        private readonly ICostAmountRepository _repo;
       
         public CostsController(ICostAmountRepository repo)
         {
           _repo = repo;
        }

   
   [HttpGet]
   public async Task<ActionResult<List<CostAmount>>> GetCosts()
   {
    var usercosts = await _repo.GetCostAmountsAsync();
    return Ok(usercosts);
   }


[HttpGet("{id}")]
public async Task<ActionResult<CostAmount>> GetCost(int id)
{
return await _repo.GetCostAmountByIdAsync(id);
}
    }
}
