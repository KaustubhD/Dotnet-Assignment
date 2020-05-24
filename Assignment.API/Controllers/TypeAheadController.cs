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
    public class TypeAheadController: ControllerBase
    {
        private readonly ILocationService _service;
        public TypeAheadController(ILocationService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("locations")]
        public async Task<IActionResult> GetTypeHeadHandler([FromQuery]LocationDto param)
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