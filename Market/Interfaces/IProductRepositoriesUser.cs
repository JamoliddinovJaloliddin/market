using MiniMarket.Models;
using System.Collections.Generic;

namespace Market.Interfaces
{
    public interface IProductRepositoriesUser
    {
        IList<Product> GettAllUser();
    }
}
