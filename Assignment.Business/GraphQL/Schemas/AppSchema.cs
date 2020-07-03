using Assignment.BUsiness.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;

namespace Assignment.Business.GraphQL.Schemas
{
    public class AppSchema: Schema
    {
        public AppSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
