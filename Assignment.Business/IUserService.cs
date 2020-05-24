using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

namespace Assignment.Business
{
    public interface IUserService
    {
        Task<ApiResultModel<bool>> CreateOneUserAsync(UserProfileRequiredDto profile);
        Task<ApiResultModel<List<UserProfile>>> GetProfileAsync(UserProfileDto loginObject);
        Task<ApiResultModel<List<BookmarkAttribute>>> GetBookmarksAsync(UserBookmarksDto loginObject);
        Task<ApiResultModel<int>> CreateOneBookmarkAsync(BookmarkAttribute bookmark);
        Task<ApiResultModel<bool>> UpdateOneBookmarkAsync(BookmarkAttribute bookmark);
        Task<ApiResultModel<bool>> DeleteOneBookmarkAsync(int bookmarkId);
    }
}