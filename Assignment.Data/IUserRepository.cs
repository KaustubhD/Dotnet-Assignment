using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Data
{
    public interface IUserRepository
    {
        Task<ApiResultModel<bool>> CreateOneUserAsync(UserProfileRequiredDto profile);
        Task<ApiResultModel<List<UserProfile>>> GetProfileAsync(UserProfileDto loginObject);
    }
}