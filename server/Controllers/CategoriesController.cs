using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Interfaces;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        public ICostCategoryRepository _repo { get; }

        public CategoriesController(ICostCategoryRepository repo)
        { _repo = repo; }


        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var usercats = await _repo.GetCostCategoriesAsync();
            return Ok(usercats);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            return await _repo.GetCostCategoryByIdAsync(id);
        }

    }
}