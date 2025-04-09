using MerchantApi.Model;

namespace MerchantApi.Services;


public class FakeUserService : IUserService
{
    private readonly List<User> _users = new()
    {
        new User { Id = 1, Username = "admin", Password = "1234" }
    };

    public bool Login(string username, string password)
    {
        return _users.Any(u => u.Username == username && u.Password == password);
    }
}
