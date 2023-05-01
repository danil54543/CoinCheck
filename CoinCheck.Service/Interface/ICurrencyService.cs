using CoinCheck.Domain.Model.Coin;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CoinCheck.Service.Interface
{
    public interface ICurrencyService
    {
        List<Coin> GetTop7Coin();
    }
}
