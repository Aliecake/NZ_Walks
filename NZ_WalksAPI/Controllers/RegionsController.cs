using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZ_WalksAPI.Data;
using NZ_WalksAPI.Models.Domain;

namespace NZ_WalksAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL REGIONS
        // https://localhost/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dbContext.Regions.ToList();
            
            return Ok(regions);
        }

        //GET Single Region by Id
        //https://localhost/api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);

            var region = dbContext.Regions.FirstOrDefault(x => x.Id == id); 

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }
    }
}
