using System;
using System.Threading.Tasks;
using Assignment.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API
{
    [ApiController]
    [Route("v1/[controller]")]
    public class AssignmentController: ControllerBase
    {
        private readonly ILocationService _service;
        public AssignmentController(ILocationService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("locations")]
        public async Task<IActionResult> GetTypeHeadHandler()
        {
            int partnerId = Convert.ToInt32((string)HttpContext.Request.Query["partnerid"]);
            string searchQuery = (string)HttpContext.Request.Query["searchTerm"];
            string types = (string)HttpContext.Request.Query["types"];
            bool includeAll = Convert.ToBoolean((string)HttpContext.Request.Query["types"]);

            try
            {
                return Ok(await _service.GetAllLocationsAsync(partnerId, searchQuery, types, includeAll));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}