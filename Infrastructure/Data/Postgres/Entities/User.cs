using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string name { get; set; } = default!;
    public string email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; }
    public ICollection<Tweet> Tweets { get; set; }
    public ICollection<FallowedUser> FallowedUsers { get; set; }
}

public enum UserType
{
    User,
    Admin,
}