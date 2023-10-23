using CQRS_Library.Data.Models;
using CQRS_Library.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IitemRepository iitemRepository;

        public ItemsController(IitemRepository iitemRepository)
        {
            this.iitemRepository = iitemRepository;
        }

        [HttpGet]

        public async Task<IActionResult> GetItems()
        {
            return Ok(iitemRepository.GetItems());
        }

        [HttpPost]

        public async Task<IActionResult> InsertItem(Items item)
        {
            iitemRepository.InsertItem(item);

            return Ok(item);    
        }
    }
}
