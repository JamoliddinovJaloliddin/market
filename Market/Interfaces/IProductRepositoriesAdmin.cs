using MiniMarket.Models;
using System.Collections.Generic;

namespace Market.Interfaces
{
    public interface IProductRepositoriesAdmin
    {
         IList<Product> GetAllAdmin();

        bool Create(Product product);

        bool Update(Product product);

        bool Delete(int Id);

        int CheckIdNumber();
    }
}
