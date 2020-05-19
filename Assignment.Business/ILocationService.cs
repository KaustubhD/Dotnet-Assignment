using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Business
{
    public interface ILocationService
    {
        Task<List<Location>> GetAllLocationsAsync(int PartnerId, string SearchQuery, string Types, bool IncludeAll);
    }
}