using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;
using Assignment.Data;

namespace Assignment.Business
{
    public class LocationService: ILocationService
    {
        private readonly ITypeAheadLocationRepository _Locationrepo;
        public LocationService(ITypeAheadLocationRepository repo)
        {
            _Locationrepo = repo;
        }
        public async Task<List<Location>> GetAllLocationsAsync(int PartnerId, string SearchQuery, string Types = null, bool IncludeAll = false)
        {
            try
            {
                return new List<Location>(await _Locationrepo.GetAllLocationsAsync(PartnerId, SearchQuery, Types, IncludeAll));
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}