using Market.MarketClass.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using MiniMarket.Constans;

namespace Market.MarketClass.Data
{
    public  class AdminDate
    {
        public void Add()
        {
            IList<UserAdminProfile> adminProfiles = new List<UserAdminProfile>()
            {
                 new UserAdminProfile()
                 {
                    User = "akbar",
                    Login = "admin",
                    Password = "akbar123",
                    Total = 1000000,
                },

            };
            string json = File.ReadAllText(DBconstants.ADMIN_DB);
            var products = JsonConvert.DeserializeObject<List<UserAdminProfile>>(json);
            products.Add((UserAdminProfile)adminProfiles);
            json = JsonConvert.SerializeObject(products);
            File.WriteAllText(DBconstants.ADMIN_DB, json);
        }
    }
}
