using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.name).IsRequired();
        builder.Property(x => x.email).IsRequired();
        builder.HasIndex(x => x.email).IsUnique();
        builder.Property(x => x.phone).IsRequired();
        builder.HasIndex(x => x.phone).IsUnique();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.IsDeleted).IsRequired();

        builder.HasMany(x => x.Tweets)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);

        builder.HasMany(x => x.FallowedUsers)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.user_id);
    }
}