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
        private readonly IRestClientRepository _http;
        public TypeAheadLocationRepository(IRestClientRepository http)
        {
            _http = http;
        }

        public async Task<ICollection<ApiTypeAheadLocation>> GetAllLocationsAsync(LocationParameters param)
        {
            var request = new RestRequest("Typeahead/Locations", Method.GET ,DataFormat.Json);
            request.AddObject(param);
            
            try
            {
                return await _http.SendRequestAsync<List<ApiTypeAheadLocation>>(request);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}