﻿using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IFallowedUserRepository FallowedUsers { get; }
    ITweetRepository Tweets { get; }
    IUserTokenRepository UserTokens { get; }

    Task<int> CommitAsync();
}