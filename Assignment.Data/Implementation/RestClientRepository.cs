using System;
using System.Net;
using System.Threading.Tasks;
using RestSharp;

namespace Assignment.Data
{
    public class RestClientRepository: IRestClientRepository
    {
        private static readonly RestClient _client;
        static RestClientRepository()
        {
            _client = new RestClient("https://sprint-api.newhomesource.com/api/v2");
        }
        public RestClientRepository()
        {

        }
        public async Task<T> SendRequestAsync<T>(RestRequest request)
        {
            var response = await _client.ExecuteAsync<T>(request);
            if(response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
            return response.Data;
        }
        public T SendRequest<T>(RestRequest request)
        {
            var response = _client.Execute<T>(request);
            if(response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
            return response.Data;
        }
    }
}