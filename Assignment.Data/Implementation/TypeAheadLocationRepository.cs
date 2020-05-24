using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;
using RestSharp;

namespace Assignment.Data
{
    public class TypeAheadLocationRepository: ITypeAheadLocationRepository
    {
        private readonly IRestClientRepository _http;
        public TypeAheadLocationRepository(IRestClientRepository http)
        {
            _http = http;
        }

        public Task<List<ApiTypeAheadLocation>> GetAllLocationsAsync(LocationDto param)
        {
            var request = new RestRequest("Typeahead/Locations", Method.GET ,DataFormat.Json);
            request.AddObject(param);
            
            return _http.SendRequestAsync<List<ApiTypeAheadLocation>>(request);
        }
    }
}