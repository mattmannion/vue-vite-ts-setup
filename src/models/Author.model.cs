namespace Models;

[GraphQLDescription("An author's information")]
public class Author {

  [GraphQLNonNullType]
  [GraphQLDescription("An author's fullname")]
  public string Name { get; set; }
}