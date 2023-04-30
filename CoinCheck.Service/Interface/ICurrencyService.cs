using CoinCheck.Domain.Model.Coin;
using System.Threading.Tasks;

namespace CoinCheck.Service.Interface
{
    public interface ICurrencyService
    {
        Task<RootCoin> GetTop7Coin();
    }
}
