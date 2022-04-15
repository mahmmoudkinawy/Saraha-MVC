namespace Secrets.Entities;
public class AppUserEntity : IdentityUser<int>
{
    [Required]
    public string Name { get; set; }
}