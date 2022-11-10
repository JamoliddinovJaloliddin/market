using Market.Class.Models;
using Market.Interfaces;
using Market.MarketClass.Models;
using MiniMarket.Constans;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace Market.Class.Repositories
{
    public class UserTotals : ITotalUser
    {
        private readonly string _pathUserMoney = DBconstants.USER_DB;
        private readonly string _pathMarketMoney = DBconstants.ADMIN_DB;

        public void MoneyMarket(double sum)
        {
            string path = File.ReadAllText(_pathMarketMoney);
            var money = JsonConvert.DeserializeObject<List<UserAdminProfile>>(path);
            foreach (var history in money)
            {
                history.Total += sum;
            }
            path = JsonConvert.SerializeObject(money);
            File.WriteAllText(_pathMarketMoney, path);
        }

        public double MoneyTotalUser()
        {
            string path = File.ReadAllText(_pathUserMoney);
            var money = JsonConvert.DeserializeObject<List<UserAdminProfile>>(path);
            foreach (var profile in money)
            {
                if (profile.User == GlobalVariables.userName)
                {
                    return profile.Total;                    
                }
            }
            return 0;

        }

        public bool MoneyTotalUserReduce(double summa)
        {
            string path = File.ReadAllText(_pathUserMoney);
            var money = JsonConvert.DeserializeObject<List<UserAdminProfile>>(path);
            foreach (var profile in money)
            {
                if (profile.User == GlobalVariables.userName && profile.Total > summa)
                {
                    profile.Total -= summa;
                    path = JsonConvert.SerializeObject(money);
                    File.WriteAllText(_pathUserMoney, path);
                    return true;
                }
            }
            return false;
        }
    }
}
