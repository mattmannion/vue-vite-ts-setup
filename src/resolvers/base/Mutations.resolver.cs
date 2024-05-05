using HotChocolate.Execution.Configuration;

namespace Resolvers;

public class Mutations {
  [GraphQLName("HelloMutations")]
  public string HelloMutations() => "hello mutations!";
}

public static class MutationConfiguration {
  public static IRequestExecutorBuilder AddMutations(this IRequestExecutorBuilder builder) {
    return builder
        .AddMutationType<Mutations>();
  }
}