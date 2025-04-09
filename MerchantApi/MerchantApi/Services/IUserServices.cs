namespace MerchantApi.Services;

public interface IUserService
{
    bool Login(string username, string password);
}