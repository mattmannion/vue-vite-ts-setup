namespace Models;

[GraphQLDescription("A book for reading")]
public class Book {
  [GraphQLNonNullType]
  [GraphQLDescription("A book's given title")]
  public string Title { get; set; }

  [GraphQLNonNullType]
  [GraphQLDescription("A book's given author")]
  public Author Author { get; set; }
}