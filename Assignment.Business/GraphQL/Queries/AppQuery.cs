
using Assignment.Business.GraphQL.Types;
using Assignment.Data;
using GraphQL.Types;
using System.Threading.Tasks;

namespace Assignment.BUsiness.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ITypeAheadLocationRepository repository)
        {
            Field<ListGraphType<LocationType>>(
               "location",
               resolve: context => repository.GetAllLocations()
            );
        }
    }
}
