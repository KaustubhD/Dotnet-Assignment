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
        public Task<ApiResultModel<bool>> CreateOneUserAsync(UserProfileRequiredDto profile)
        {
            var request = new RestRequest("User/Create", Method.POST ,DataFormat.Json);
            request.AddJsonBody(profile);
            
            return _http.SendRequestAsync<ApiResultModel<bool>>(request);
        }
        public Task<ApiResultModel<List<UserProfile>>> GetProfileAsync(UserProfileDto loginObject)
        {
            var request = new RestRequest("User/Profile", Method.GET, DataFormat.Json);
            request.AddObject(loginObject);
            
            return _http.SendRequestAsync<ApiResultModel<List<UserProfile>>>(request);
        }
        public Task<ApiResultModel<List<BookmarkAttribute>>> GetBookmarksAsync(UserBookmarksDto loginObject)
        {
            var request = new RestRequest("User/Bookmarks", Method.GET, DataFormat.Json);
            request.AddObject(loginObject);

            return _http.SendRequestAsync<ApiResultModel<List<BookmarkAttribute>>>(request);
        }
        public Task<ApiResultModel<int>> CreateOneBookmarkAsync(BookmarkAttribute bookmark)
        {
            var request = new RestRequest("User/CreateBookmark", Method.POST, DataFormat.Json);
            request.AddJsonBody(bookmark);

            return _http.SendRequestAsync<ApiResultModel<int>>(request);
        }
        public Task<ApiResultModel<bool>> UpdateOneBookmarkAsync(BookmarkAttribute bookmark)
        {
            var request = new RestRequest("User/UpdateBookmark", Method.POST, DataFormat.Json);
            request.AddJsonBody(bookmark);

            return _http.SendRequestAsync<ApiResultModel<bool>>(request);
        }
        public Task<ApiResultModel<bool>> DeleteOneBookmarkAsync(int bookmarkId)
        {
            var request = new RestRequest("User/DeleteBookmark", Method.GET, DataFormat.Json);
            request.AddQueryParameter("bookmarkId", bookmarkId.ToString());

            return _http.SendRequestAsync<ApiResultModel<bool>>(request);
        }
    }
}