
using Assignment.Business.GraphQL.Types;
using Assignment.Core;
using Assignment.Data;
using GraphQL.Types;

namespace Assignment.BUsiness.GraphQL.Queries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ITypeAheadLocationRepository repository)
        {
            Field<ListGraphType<LocationType>>(
               "location",
               arguments: new QueryArguments(
                   new QueryArgument<LocationDtoType> { Name = "args" }
               ),
               resolve: context =>
               {
                   return repository.GetAllLocations(context.GetArgument<LocationDto>("args"));
               }
            );
        }
    }
}
