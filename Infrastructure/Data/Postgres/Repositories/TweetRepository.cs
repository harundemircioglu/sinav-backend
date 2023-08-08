using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class TweetRepository : Repository<Tweet, int>, ITweetRepository
    {
        public TweetRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Tweet>> GetAllAsync(Expression<Func<Tweet, bool>>? filter = null)
        {
            var tweet = PostgresContext.Set<Tweet>()
                .Include(x => x.User);
            return filter == null
                ? await tweet.ToListAsync()
                : await tweet.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Tweet>> GetByTweetIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<User>> GetTweetByUserIdAsync(int id)
        {
            var users = PostgresContext.Set<User>();
            var filteredUsers = await users
                .Where(user => user.Id == id)
                .ToListAsync();
            return filteredUsers;
        }
    }
}
