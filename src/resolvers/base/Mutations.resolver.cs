using HotChocolate.Execution.Configuration;

namespace Resolvers;

public class Mutation {
  [GraphQLNonNullType]
  [GraphQLDescription("For testing the mutation side of the gql api")]
  [GraphQLName("MutationTest")]
  public string MutationTest() => "Mutations are functional";
}

public static class MutationConfiguration {
  public static IRequestExecutorBuilder AddMutations(this IRequestExecutorBuilder builder) {
    return builder
        .AddMutationType<Mutation>();
  }
}