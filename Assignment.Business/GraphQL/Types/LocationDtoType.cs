using Assignment.Core;
using GraphQL.Types;

namespace Assignment.Business.GraphQL.Types
{
    public class LocationDtoType: InputObjectGraphType<LocationDto>
    {
        public LocationDtoType()
        {
            Field(x => x.PartnerId, type: typeof(IntGraphType)).DefaultValue(9383);
            Field(x => x.SearchTerm, type: typeof(NonNullGraphType<StringGraphType>));
            Field(x => x.Types, type: typeof(StringGraphType));
            Field(x => x.IncludeAll, type: typeof(BooleanGraphType), nullable: true);
        }
    }
}
