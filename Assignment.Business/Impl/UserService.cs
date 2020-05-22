using System;
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
        public Task<ApiResultModelOfBoolean> CreateOneUserAsync(UserProfileRequiredDto profile)
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
    }
}