using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Assignment.Core;
using RestSharp;

namespace Assignment.Data
{
    public class TypeAheadLocationRepository: ITypeAheadLocationRepository
    {
        private readonly RestClient _client;
        public TypeAheadLocationRepository()
        {
            _client = new RestClient("https://sprint-api.newhomesource.com/api/v2");
        }

        public async Task<ICollection<Location>> GetAllLocationsAsync(int PartnerId, string SearchQuery, string Types = null, bool IncludeAll = false)
        {
            _client.ThrowOnDeserializationError = true;
            var request = new RestRequest("Typeahead/Locations", Method.GET ,DataFormat.Json);

            request.AddParameter("partnerid", PartnerId);
            request.AddParameter("searchTerm", SearchQuery);
            
            var response = await _client.ExecuteAsync<List<Location>>(request);
            if(response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
            return response.Data;
        }
    }
}