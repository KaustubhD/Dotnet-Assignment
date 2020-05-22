using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Data
{
    public interface IUserRepository
    {
        Task<ApiResultModelOfBoolean> CreateOneUserAsync(UserProfileRequiredDto profile);
    }
}