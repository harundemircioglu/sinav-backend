using Business.Models.Request;
using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, UserProfileDto>();

        CreateMap<TweetCreateDto, Tweet>();
        CreateMap<TweetUpdateDto, Tweet>();
        CreateMap<Tweet, TweetResponseDto>();

        CreateMap<FallowedUserCreateDto, FallowedUser>();
        CreateMap<FallowedUserUpdateDto, FallowedUser>();
        CreateMap<FallowedUser, FallowedUserResponseDto>();
    }
}