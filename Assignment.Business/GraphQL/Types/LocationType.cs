using Assignment.Core;
using GraphQL.Types;

namespace Assignment.Business.GraphQL.Types
{
    public class LocationType: ObjectGraphType<ApiTypeAheadLocation>
    {
        public LocationType()
        {
            Field(x => x.Id, type: typeof(IntGraphType)).Description("Location Id");
            Field(x => x.Name).Description("Name of location");
            Field(x => x.Type).Description("Type of location");
            Field(x => x.MarketId, type: typeof(IntGraphType));
            Field(x => x.MarketName);
            Field(x => x.MarketStateAbbr);
            Field(x => x.MarketStateName);
            Field(x => x.Latitude, type: typeof(DecimalGraphType));
            Field(x => x.Longitude, type: typeof(DecimalGraphType));
            Field(x => x.City);
            Field(x => x.State);
            Field(x => x.HasShowCase, type: typeof(BooleanGraphType));
            Field(x => x.BrandType);
        }
    }
}
