namespace Market.Interfaces
{
    public interface ITotalUser
    {
        double MoneyTotalUser();
        bool MoneyTotalUserReduce(double summa);
        void MoneyMarket(double summa);
    }
}
