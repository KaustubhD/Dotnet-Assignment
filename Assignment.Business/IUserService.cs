using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Business
{
    public interface IUserService
    {
        Task<ApiResultModelOfBoolean> CreateOneUserAsync(UserProfileRequiredDto profile);
    }
}