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
    public class TweetConfiguration : IEntityTypeConfiguration<Tweet>
    {
        public void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.user_id).IsRequired();
            builder.Property(x => x.tweet_header).IsRequired();
            builder.Property(x => x.tweet_detail).IsRequired();
            builder.Property(x => x.likes).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Tweets)
                .HasForeignKey(x => x.user_id);
        }
    }
}
