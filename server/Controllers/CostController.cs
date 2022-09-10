using Microsoft.AspNetCore.Mvc;
using Server.Interfaces;

namespace server
{

    [Route("api/[controller]")]
    public class CostController : Controller
    {
        private readonly ICostAmountRepository _repo;
       
         public CostController(ICostAmountRepository repo)
         {
           _repo = repo;
        }

   






    }
}
