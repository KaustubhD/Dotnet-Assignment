
using Assignment.Business.GraphQL.Types;
using Assignment.Data;
using GraphQL.Types;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BUsiness.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ITypeAheadLocationRepository repository)
        {
            Field<ListGraphType<LocationType>>(
               "location",
               arguments: new QueryArguments(
                   new QueryArgument<StringGraphType> { Name = "searchTerm" }
               ),
               resolve: context => repository.GetAllLocations(new Core.LocationDto() { SearchTerm = context.GetArgument<string>("searchTerm") })
            );
        }
    }
}
