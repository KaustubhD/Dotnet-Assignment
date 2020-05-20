using System;
using System.Threading.Tasks;
using Assignment.Business;
using Assignment.Core;
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
        public async Task<IActionResult> GetTypeHeadHandler([FromQuery]LocationParameters param)
        {
            try
            {
                return Ok(await _service.GetAllLocationsAsync(param));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}