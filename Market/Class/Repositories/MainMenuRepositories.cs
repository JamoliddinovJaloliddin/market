using MiniMarket.Constans;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UserAdminProfile = Market.MarketClass.Models.UserAdminProfile;

namespace Market.MarketClass.Repositories
{
    public class MainMenuRepositories
    {
        private readonly string _dbPathAdmin = DBconstants.ADMIN_DB;
        private readonly string _dbPathUser = DBconstants.USER_DB;
        public  bool CheckAdmin(string password, string user)
        {
            string path = File.ReadAllText(_dbPathAdmin);
            var json = JsonConvert.DeserializeObject<List<UserAdminProfile>>(path);
            foreach (var admin in json)
            {
                if (admin.User == user && admin.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckUser(string password, string user)
        {
            string path = File.ReadAllText(_dbPathUser);
            var json = JsonConvert.DeserializeObject<List<UserAdminProfile>>(path);
            foreach (var use in json)
            {
                if (use.User == user && use.Password == password)
                { 
                    return true;
                }
            }
            
            return false;
        }
    }
}
