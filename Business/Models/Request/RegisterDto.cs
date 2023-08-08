namespace Business.Models.Request;

public class RegisterDto
{
    public string name { get; set; } = default!;
    public string email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public string password { get; set; } = default!;
}