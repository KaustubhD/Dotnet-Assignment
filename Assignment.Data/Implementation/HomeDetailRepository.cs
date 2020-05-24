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
        public Task<ApiHome> GetAllHomeDetailsAsync(HomeDetailDto param)
        {
            var request = new RestRequest("Detail/Home", Method.GET ,DataFormat.Json);
            request.AddObject(param);
            
            return _http.SendRequestAsync<ApiHome>(request);
        }
    }
}