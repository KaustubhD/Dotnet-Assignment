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
        public async Task<List<ApiTypeAheadLocation>> GetAllLocationsAsync(LocationParameters param)
        {
            try
            {
                return new List<ApiTypeAheadLocation>(await _Locationrepo.GetAllLocationsAsync(param));
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}