using Models;

namespace Resolvers;

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
