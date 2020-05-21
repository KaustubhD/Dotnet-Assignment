using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Business
{
    public interface ILocationService
    {
        Task<List<ApiTypeAheadLocation>> GetAllLocationsAsync(LocationParameters p);
    }
}