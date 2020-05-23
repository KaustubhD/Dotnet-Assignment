using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;
using Assignment.Data;

namespace Assignment.Business
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        public Task<ApiResultModel<bool>> CreateOneUserAsync(UserProfileRequiredDto profile)
        {
            try
            {
                return _repo.CreateOneUserAsync(profile);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public Task<ApiResultModel<List<UserProfile>>> GetProfileAsync(UserProfileDto loginObject)
        {
            try
            {
                return _repo.GetProfileAsync(loginObject);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public Task<ApiResultModel<List<BookmarkAttribute>>> GetBookmarksAsync(UserBookmarksDto loginObject)
        {
            try
            {
                return _repo.GetBookmarksAsync(loginObject);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}