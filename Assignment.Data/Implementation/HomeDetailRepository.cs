using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;
using RestSharp;

namespace Assignment.Data
{
    public class HomeDetailRepository: IHomeDetailRepository
    {
        private readonly IRestClientRepository _http;
        public HomeDetailRepository(IRestClientRepository http)
        {
            _http = http;
        }
        public async Task<ICollection<ApiHome>> GetAllHomeDetailsAsync(HomeDetailParameters param)
        {
            var request = new RestRequest("Detail/Home", Method.GET ,DataFormat.Json);
            request.AddObject(param);
            
            try
            {
                return await _http.SendRequestAsync<List<ApiHome>>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}