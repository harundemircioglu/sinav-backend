using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FallowedUserConfiguration : IEntityTypeConfiguration<FallowedUser>
    {
        public void Configure(EntityTypeBuilder<FallowedUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.user_id).IsRequired();
            builder.Property(x => x.fallowed_user_id).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.FallowedUsers)
                .HasForeignKey(x => x.user_id);
        }
    }
}
