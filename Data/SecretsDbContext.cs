namespace Secrets.Data;
public class SecretsDbContext : IdentityDbContext
{
    public SecretsDbContext(DbContextOptions<SecretsDbContext> options) : base(options)
    { }

    public DbSet<AppUserEntity> AppUsers { get; set; }
}