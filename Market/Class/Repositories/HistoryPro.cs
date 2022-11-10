using Market.Class.Models;
using Market.Interfaces;
using MiniMarket.Constans;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Market.Class.Repositories
{
    public class HistoryPro : IHistory
    {
        private readonly string _path = DBconstants.HISTORYMARKET_DB;
        public void HistoryAppend(Models.History histories)
        {
            string json = File.ReadAllText(_path);
            var historyList = JsonConvert.DeserializeObject<List<Models.History>>(json);
            historyList.Add((Models.History)histories);
            json = JsonConvert.SerializeObject(historyList);
            File.WriteAllText(_path, json);
        }

        IList<Models.History> IHistory.HistoryGettAllMarket()
        {
            string json = File.ReadAllText(_path);
            var historyList = JsonConvert.DeserializeObject<List<Models.History>>(json);
            return historyList;
        }

        IList<History> IHistory.HistoryGettAllUser()
        {
            string json = File.ReadAllText(_path);
            var historyList = JsonConvert.DeserializeObject<List<Models.History>>(json);
            return historyList;
        }
    }
}
