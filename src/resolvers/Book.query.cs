using Models;

namespace Resolvers;

[ExtendObjectType(typeof(Query))]
public class BookQuery {
  [GraphQLNonNullType]
  [GraphQLDescription("Returns one book")]
  [GraphQLName("BookGet")]
  public Book BookGet() {
    return new Book {
      Title = "C# in depth.",
      Author = new Author {
        Name = "Matt Mannion"
      }
    };
  }
}
