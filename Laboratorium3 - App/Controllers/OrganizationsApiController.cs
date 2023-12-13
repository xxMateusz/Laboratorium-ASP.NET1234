using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Laboratorium3___App.Controllers
{
    [Route("api/organizations")]
    [ApiController]
    public class OrganizationsApiController:ControllerBase
    {
        private readonly AppDbContext context;

        public OrganizationsApiController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetOrganizationsByName(string? name)
        {
            return Ok(
                name is null ?
                    context.Organizations
                    .Select(organization => new { organization.Name, organization.Id })
                    .ToList()
                :
                    context.Organizations
                    .Where(organization => organization.Name.ToUpper().StartsWith(name.ToUpper()))
                    .Select(organization => new { organization.Name, organization.Id })
                    .ToList()
            );
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var entity = context.Organizations.Find(id);
            if (entity is null) return NotFound();

            return Ok(entity);
        }
    }
}