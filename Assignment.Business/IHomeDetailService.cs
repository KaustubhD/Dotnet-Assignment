using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Business
{
    public interface IHomeDetailService
    {
        Task<ApiHome> GetAllHomeDetailsAsync(HomeDetailDto p);
    }
}