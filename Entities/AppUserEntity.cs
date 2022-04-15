namespace Secrets.Entities;
public class AppUserEntity : IdentityUser
{
    [Required]
    public string Name { get; set; }
}