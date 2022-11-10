using Market.Interfaces;
using MiniMarket.Constans;
using MiniMarket.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace Market.Class.Repositories
{
    public class ProductRepositoriesUser : IProductRepositoriesUser
    {
        private readonly string _dbPath = DBconstants.PRODUCTS_DB;

        IList<Product> IProductRepositoriesUser.GettAllUser()
        {
            string json = File.ReadAllText(_dbPath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }
    }
}
