using System;
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
        public async Task<ApiResultModelOfBoolean> CreateOneUserAsync(UserProfileRequiredDto profile)
        {
            var request = new RestRequest("User/Create", Method.POST ,DataFormat.Json);
            request.AddJsonBody(profile);
            
            try
            {
                return await _http.SendRequestAsync<ApiResultModelOfBoolean>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}