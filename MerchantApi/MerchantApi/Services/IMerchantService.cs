using MerchantApi.Model;

namespace MerchantApi.Services;

public interface IMerchantService
{
    IEnumerable<Merchant> GetAll();
    Merchant GetById(int id);
    Merchant Create(Merchant merchant);
    Merchant Update(int id, Merchant merchant);
    void Delete(int id);
}