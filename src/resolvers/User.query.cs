using Microsoft.EntityFrameworkCore;
using Resolvers;

public class UserInput {
  public int? Id { get; set; }
  public string Username { get; set; }
}

[ExtendObjectType(typeof(Query))]
public class UserQuery {
  [GraphQLNonNullType]
  [GraphQLDescription("Returns a list of all users")]
  [GraphQLName("UsersGet")]
  public async Task<List<User>> GetUsersAsync([Service] PgDbContext context) {
    return await context.Users.ToListAsync();
  }

  [GraphQLDescription("Returns a single user by ID or Username provided in an input object")]
  [GraphQLName("UserGet")]
  public async Task<User> GetUser([Service] PgDbContext context, UserInput input) {
    try {
      User user = null;

      if (input.Id.HasValue) {
        user = await context.Users.FirstOrDefaultAsync(u => u.Id == input.Id);
      } else if (!string.IsNullOrEmpty(input.Username)) {
        user = await context.Users.FirstOrDefaultAsync(u => u.Username == input.Username);
      }

      if (user == null) {
        string notFoundMessage = "No user found";
        if (input.Id.HasValue) {
          notFoundMessage += $" by ID: {input.Id}";
        } else if (!string.IsNullOrEmpty(input.Username)) {
          notFoundMessage += $" by Username: '{input.Username}'";
        }
        throw new GraphQLException(notFoundMessage);
      }

      return user;
    } catch (Exception ex) {
      throw new GraphQLException($"An error occurred while processing your request. Error: {ex.Message}");
    }
  }
}