using HotChocolate.Execution.Configuration;

namespace Resolvers;

public class Query {
  [GraphQLNonNullType]
  [GraphQLDescription("For testing the query side of the gql api")]
  [GraphQLName("QueryTest")]
  public string QueryTest() => "Queries are functional";
}

public static class QueryConfiguration {
  public static IRequestExecutorBuilder AddQueries(this IRequestExecutorBuilder builder) {
    return builder
        .AddQueryType<Query>()
        .AddTypeExtension<BookQuery>();
  }
}