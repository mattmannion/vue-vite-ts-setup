using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
[GraphQLDescription("Application User definition")]
public class User {
  [Key]
  [Column("id")]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }

  [Required]
  [Column("firstname", TypeName = "varchar(50)")]
  [GraphQLName("firstname")]
  [GraphQLNonNullType]
  public string Firstname { get; set; }

  [Required]
  [Column("lastname", TypeName = "varchar(50)")]
  [GraphQLNonNullType]
  [GraphQLName("lastname")]
  public string Lastname { get; set; }

  [Required]
  [Column("username", TypeName = "varchar(50)")]
  [GraphQLNonNullType]
  [GraphQLName("username")]
  public string Username { get; set; }

  [Required]
  [EmailAddress]
  [Column("email", TypeName = "varchar(255)")]
  [GraphQLNonNullType]
  [GraphQLName("email")]
  public string Email { get; set; }

  [Column("password", TypeName = "varchar(255)")]
  [GraphQLIgnore]
  public string Password { get; set; }

  [Column("confirmed", TypeName = "boolean")]
  [GraphQLNonNullType]
  [GraphQLName("confirmed")]
  public bool Confirmed { get; set; }
}
