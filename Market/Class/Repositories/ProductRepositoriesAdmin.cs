using Market.Interfaces;
using MiniMarket.Constans;
using MiniMarket.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MiniMarket.Repositories
{
    public class ProductRepositories : IProductRepositoriesAdmin
    {
        private readonly string _dbPath = DBconstants.PRODUCTS_DB;

        public int CheckIdNumber()
        {
            int count = 0;
            string json = File.ReadAllText(_dbPath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            foreach (var product in products)
            {
                    count++;   
            }
            return count;
        }

        public bool Create(Product obj)
        {
            try
            {
                int count = 0;
                string json = File.ReadAllText(_dbPath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var product in products)
                {
                    if (product.Price > 0 && product.Price == obj.Price && product.Name == obj.Name)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    products.Add(obj);
                    json = JsonConvert.SerializeObject(products);
                    File.WriteAllText(_dbPath, json);
                    return true;
                }
                json = JsonConvert.SerializeObject(products);
                File.WriteAllText(_dbPath, json);
                return false;
            }
            catch
            {
               
            }
            return false;
        }

        public bool Delete(int Id)
        {

            try
            {
                int count = 0;
                string json = File.ReadAllText(_dbPath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var product in products)
                {
                    if (product.Id == Id)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    foreach (Product product in products)
                    {
                        if (product.Id == Id)
                        {
                            products.Remove(product);
                            json = JsonConvert.SerializeObject(products);
                            File.WriteAllText(_dbPath, json);
                            return true;

                        }
                    }

                }
                json = JsonConvert.SerializeObject(products);
                File.WriteAllText(_dbPath, json);
                return false;
            }
            catch
            {

            }
            return false;
        }

        public bool Update(Product obj)
        {
            try
            {
                int count = 0;
                string json = File.ReadAllText(_dbPath);
                var products = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach (var product in products)
                {
                    if (product.Id == obj.Id)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    foreach (Product product in products)
                    {
                        if (product.Id == obj.Id && product.Price > 0)
                        {
                            product.Id = obj.Id;
                            product.Name = obj.Name;
                            product.Description = obj.Description;
                            product.Price = obj.Price;
                            json = JsonConvert.SerializeObject(products);
                            File.WriteAllText(_dbPath, json);
                            return true;
                        }
                    }
                }
                json = JsonConvert.SerializeObject(products);
                File.WriteAllText(_dbPath, json);
                return false;
            }
            catch
            {
            }
            return false;
        }

        IList<Product> IProductRepositoriesAdmin.GetAllAdmin()
        {
            string json = File.ReadAllText(_dbPath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }
    }
}
