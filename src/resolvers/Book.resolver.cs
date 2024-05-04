using Models;

namespace Resolvers;

public class BookQuery {
  public Models.Book GetBook() {
    return new Book {
      Title = "C# in depth.",
      Author = new Author {
        Name = "Matt Mannion"
      }
    };
  }
}