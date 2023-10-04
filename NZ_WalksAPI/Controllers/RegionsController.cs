using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZ_WalksAPI.Data;
using NZ_WalksAPI.Models.Domain;
using NZ_WalksAPI.Models.DTO;

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
            // Domain Models - get from DB
            var regions = dbContext.Regions.ToList();
            
            // Map model to DTO
            var regionsDto = new List<RegionDto>();

            foreach (var region in regions) {
                regionsDto.Add(new RegionDto()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImgUrl = region.RegionImgUrl
                });
            }

            // Return DTO
            return Ok(regionsDto);
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
            
            // Convert domain model to DTO

            var regionDto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImgUrl = region.RegionImgUrl
            };

            return Ok(regionDto);
        }
    }
}
