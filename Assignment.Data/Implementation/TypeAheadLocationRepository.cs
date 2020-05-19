using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;
using RestSharp;

public class TypeAheadLocationRepository: ITypeAheadLocationRepository
{
    public TypeAheadLocationRepository()
    {

    }

    public async Task<ICollection<Location>> GetAllLocationsAsync(int PartnerId, string SearchQuery, string Types = null, bool IncludeAll = false)
    {
        var client = new RestClient("https://https://sprint-api.newhomesource.com/api/v2");

        var request = new RestRequest("Typeahead/Locations", DataFormat.Json);

        request.AddParameter("partnerid", PartnerId);
        request.AddParameter("search", SearchQuery);

        return await client.GetAsync<List<Location>>(request);
    }
}