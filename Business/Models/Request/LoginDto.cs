namespace Business.Models.Request;

public class LoginDto
{
    public string email { get; set; } = default!;
    public string password { get; set; } = default!;
}