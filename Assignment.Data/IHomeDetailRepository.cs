using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Data
{
    public interface IHomeDetailRepository
    {
        Task<ApiHome> GetAllHomeDetailsAsync(HomeDetailDto p);
    }
}