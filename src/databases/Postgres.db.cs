using Microsoft.EntityFrameworkCore;

public class PgDbContext : DbContext {
  public PgDbContext(DbContextOptions<PgDbContext> options) : base(options) { }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    if (!optionsBuilder.IsConfigured) {
      optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=phishdb;Username=postgres;Password=postgres;SSL Mode=Prefer;Pooling=true;");
    }
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    base.OnModelCreating(modelBuilder);
    // Configure your model relationships and properties here
  }

  // Define DbSets for your tables
  public DbSet<User> Users { get; set; }
}
