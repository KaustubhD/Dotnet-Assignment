using System.Threading.Tasks;
using RestSharp;

namespace Assignment.Data
{
    public interface IRestClientRepository
    {
        Task<T> SendRequestAsync<T>(RestRequest req);
        T SendRequest<T>(RestRequest req);
    }
}