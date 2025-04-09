using MerchantApi.Model;

namespace MerchantApi.Services;

public class FakeMerchantService : IMerchantService
{
    private readonly List<Merchant> _merchants = new List<Merchant>
    {
        new Merchant { Id = 1, Name = "Migros Market", Address = "Silivri/Istanbul", Email = "migros@gmail.com", Phone = "2126507088", OpenDate = new DateTime(2018, 9, 20) },
        new Merchant { Id = 2, Name = "Bim Market", Address = "Zeytinburnu/Istanbul", Email = "bim@gmail.com", Phone = "2126504081", OpenDate = new DateTime(1990, 9, 21) }
    };

    public IEnumerable<Merchant> GetAll() => _merchants;
    public Merchant GetById(int id) => _merchants.FirstOrDefault(m => m.Id == id);
    public Merchant Create(Merchant merchant)
    {
        merchant.Id = _merchants.Max(m => m.Id) + 1;
        _merchants.Add(merchant);
        return merchant;
    }
    public Merchant Update(int id, Merchant merchant)
    {
        var existing = _merchants.FirstOrDefault(m => m.Id == id);
        if (existing == null) return null;
        existing.Name = merchant.Name;
        existing.Address = merchant.Address;
        existing.Email = merchant.Email;
        existing.Phone = merchant.Phone;
        existing.OpenDate = merchant.OpenDate;
        return existing;
    }
    public void Delete(int id)
    {
        var merchant = _merchants.FirstOrDefault(m => m.Id == id);
        if (merchant != null) _merchants.Remove(merchant);
    }
}