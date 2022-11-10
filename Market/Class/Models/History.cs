using System;

namespace Market.Class.Models
{
    public class History
    {

        public string User { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public DateTime DateTime { get; set; }
        public double TotalBuy { get; set; }

        public History(string user, string name, DateTime dateTime, double totalBuy)
        {
            User = user;
            Name = name;
            DateTime = dateTime;
            TotalBuy = totalBuy;
        }
    }
}
