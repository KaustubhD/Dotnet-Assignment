using System;
using System.Net;
using System.Threading.Tasks;
using RestSharp;

namespace Assignment.Data
{
    public sealed class RestClientRepository: IRestClientRepository
    {
        private static readonly RestClientRepository Instance = new RestClientRepository();
        private static readonly RestClient _client = new RestClient("https://sprint-api.newhomesource.com/api/v2");
        static RestClientRepository()
        {
        }
        private RestClientRepository()
        {
        }
        public static RestClientRepository instance
        {
            get
            {
                return Instance;
            }
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