using HotChocolate.Execution.Configuration;

namespace Resolvers;

public class Queries {
  [GraphQLName("HelloQueries")]
  public string HelloQueries() => "hello queries!";
}

public static class QueryConfiguration {
  public static IRequestExecutorBuilder AddQueries(this IRequestExecutorBuilder builder) {
    return builder
        .AddQueryType<Queries>()
        .AddTypeExtension<BookQuery>();
  }
}