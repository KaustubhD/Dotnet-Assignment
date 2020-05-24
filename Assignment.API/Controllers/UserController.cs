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
        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult> GetProfileAsync([FromQuery]UserProfileDto loginObject)
        {
            try
            {
                var res = await _service.GetProfileAsync(loginObject);
                if(!string.IsNullOrEmpty(res.ErrorMessage))
                {
                    throw new Exception(res.ErrorMessage);
                }
                return Ok(res);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("bookmarks")]
        public async Task<IActionResult> GetBookmarksAsync([FromQuery]UserBookmarksDto loginObject)
        {
            try
            {
                var res = await _service.GetBookmarksAsync(loginObject);
                if(!string.IsNullOrEmpty(res.ErrorMessage))
                {
                    throw new Exception(res.ErrorMessage);
                }
                return Ok(res);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("createBookmark")]
        public async Task<IActionResult> CreateOneBookmarkAsync([FromBody]BookmarkAttribute bookmark)
        {
            /*
                {
                "userId": "1234",
                "contentTypeId": 3,
                "contentId": 1,
                "title": "DK Test4",
                "url": "http://www.newhomesource.com",
                "action": "Saved"
                }
            */
            try
            {
                var res = await _service.CreateOneBookmarkAsync(bookmark);
                if(!string.IsNullOrEmpty(res.ErrorMessage))
                {
                    throw new Exception(res.ErrorMessage);
                }
                return Ok(res);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("updateBookmark")]
        public async Task<IActionResult> UpdateOneBookmarkAsync([FromBody]BookmarkAttribute bookmark)
        {
            /*
                {
                "userId": "1234",
                "contentTypeId": 3, // This doesn't change for some reason
                "contentId": 1,
                "title": "DK Test4---",
                "url": "http://www.newhomesource.com",
                "action": "Saved",
                "notes": ["new",""home]
                }
            */
            try
            {
                var res = await _service.UpdateOneBookmarkAsync(bookmark);
                if(!res.Result)
                {
                    throw new Exception(res.ErrorMessage);
                }
                return Ok(res);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("deleteBookmark")]
        public async Task<IActionResult> DeleteOneBookmarkAsync([FromQuery]int bookmarkId)
        {
            try
            {
                var res = await _service.DeleteOneBookmarkAsync(bookmarkId);
                if(!res.Result)
                {
                    throw new Exception(res.ErrorMessage);
                }
                return Ok(res);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}