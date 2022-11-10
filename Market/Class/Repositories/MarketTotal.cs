using Market.Interfaces;
using MiniMarket.Constans;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Market.MarketClass.Models;
using Market.Class.Models;

namespace Market.Class.Repositories
{
    public class MarketTotal : ITotalMarket
    {
        private readonly string _dbPath = DBconstants.ADMIN_DB;
        public string MoneyTotalAdmin()
        {
            var json = File.ReadAllText(_dbPath);
            var money = JsonConvert.DeserializeObject<IList<UserAdminProfile>>(json);
            foreach (var user in money)
            {
                if (user.User == GlobalVariables.adminName)
                {
                    return user.Total.ToString();
                }
            }
            return money.ToString();
        }
    }
}
