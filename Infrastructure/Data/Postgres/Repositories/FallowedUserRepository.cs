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
    public class FallowedUserRepository : Repository<FallowedUser, int>, IFallowedUserRepository
    {
        public FallowedUserRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<FallowedUser>> GetAllAsync(Expression<Func<FallowedUser, bool>>? filter = null)
        {
            var fallowedUser = PostgresContext.Set<FallowedUser>()
                .Include(x => x.User);
            return filter == null
                ? await fallowedUser.ToListAsync()
                : await fallowedUser.Where(filter)
                .ToListAsync();
        }

        public Task<IList<FallowedUser>> GetByFallowedUserIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
