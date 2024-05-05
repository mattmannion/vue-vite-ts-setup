using Models;

namespace Resolvers;

[ExtendObjectType(typeof(Queries))]
public class BookQuery {
  [GraphQLName("GetBook")]
  public Book GetBook() {
    return new Book {
      Title = "C# in depth.",
      Author = new Author {
        Name = "Matt Mannion"
      }
    };
  }
}
