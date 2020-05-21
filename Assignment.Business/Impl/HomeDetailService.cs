using Assignment.Data;
using Assignment.Core;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Assignment.Business
{
    public class HomeDetailService: IHomeDetailService
    {
        private readonly IHomeDetailRepository _repo;
        public HomeDetailService(IHomeDetailRepository repo)
        {
            _repo = repo;
        }
        public async Task<ApiHome> GetAllHomeDetailsAsync(HomeDetailParameters param)
        {
            try
            {
                return await _repo.GetAllHomeDetailsAsync(param);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}