using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Interfaces
{
    public interface IProductRepository
    {
        void Create(Product product);

        void Update(Product product);

        void Delete(int productId);
    }
}
