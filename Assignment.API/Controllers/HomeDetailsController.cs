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
    public class HomeDetailsController: ControllerBase
    {
        private readonly IHomeDetailService _service;
        public HomeDetailsController(IHomeDetailService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("home")]
        public async Task<IActionResult> GetHomeDetailsHandler([FromQuery]HomeDetailDto param)
        {
            try
            {
                return Ok(await _service.GetAllHomeDetailsAsync(param));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}