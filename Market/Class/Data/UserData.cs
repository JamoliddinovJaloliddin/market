using Market.MarketClass.Models;
using MiniMarket.Constans;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Market.MarketClass.Data
{
    public class UserData
    {
        public void Add()
        {
            IList<UserAdminProfile> userProfiles = new List<UserAdminProfile>()
            {
                new UserAdminProfile()
                {
                    User = "ahmad",
                    Login = "user",
                    Password = "12345",
                    Total = 800000,
                },
                new UserAdminProfile()
                {
                    User = "ahmadullo",
                    Login = "user",
                    Password = "1234",
                    Total = 600000,
                }
            };

            string json = File.ReadAllText(DBconstants.USER_DB);
            var products = JsonConvert.DeserializeObject<List<UserAdminProfile>>(json);
            products.Add((UserAdminProfile)userProfiles);
            json = JsonConvert.SerializeObject(products);
            File.WriteAllText(DBconstants.ADMIN_DB, json);
        }
    }
}
