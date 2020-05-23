using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;
using RestSharp;

namespace Assignment.Data
{
    public class UserRepository: IUserRepository
    {
        private readonly IRestClientRepository _http;
        public UserRepository(IRestClientRepository http)
        {
            _http = http;
        }
        public async Task<ApiResultModel<bool>> CreateOneUserAsync(UserProfileRequiredDto profile)
        {
            var request = new RestRequest("User/Create", Method.POST ,DataFormat.Json);
            request.AddJsonBody(profile);
            
            try
            {
                return await _http.SendRequestAsync<ApiResultModel<bool>>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public async Task<ApiResultModel<List<UserProfile>>> GetProfileAsync(UserProfileDto loginObject)
        {
            var request = new RestRequest("User/Profile", Method.GET, DataFormat.Json);
            request.AddObject(loginObject);
            try
            {
                return await _http.SendRequestAsync<ApiResultModel<List<UserProfile>>>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public async Task<ApiResultModel<List<BookmarkAttribute>>> GetBookmarksAsync(UserBookmarksDto loginObject)
        {
            var request = new RestRequest("User/Bookmarks", Method.GET, DataFormat.Json);
            request.AddObject(loginObject);
            try
            {
                return await _http.SendRequestAsync<ApiResultModel<List<BookmarkAttribute>>>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public async Task<ApiResultModel<int>> CreateOneBookmarkAsync(BookmarkAttribute bookmark)
        {
            var request = new RestRequest("User/CreateBookmark", Method.POST, DataFormat.Json);
            request.AddJsonBody(bookmark);
            try
            {
                return await _http.SendRequestAsync<ApiResultModel<int>>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}