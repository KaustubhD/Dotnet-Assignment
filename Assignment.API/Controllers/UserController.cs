using System;
using System.Threading.Tasks;
using Assignment.Business;
using Assignment.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assignment.API
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUser([FromBody]UserProfileRequiredDto profile)
        {
            /*
                {
                "userId": "1234",
                "logonName": "dktest1",
                "partnerId": "1",
                "firstName": "ABC",
                "lastName": "DEF",
                "city": "Miami",
                "state": "FL",
                "postalCode": "33101",
                "regMetro": "dee",
                "password": "string"
                }
            */
            try
            {
                var res = await _service.CreateOneUserAsync(profile);
                if(res.Result)
                {
                    return Ok(res);
                }
                else
                {
                    return BadRequest(res.ErrorMessage);
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}