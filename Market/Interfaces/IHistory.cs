using Market.Class.Models;
using System.Collections.Generic;

namespace Market.Interfaces
{
    public interface IHistory
    {
        IList<History> HistoryGettAllMarket();
        IList<History> HistoryGettAllUser();
        void HistoryAppend(History histories);
    }
}
