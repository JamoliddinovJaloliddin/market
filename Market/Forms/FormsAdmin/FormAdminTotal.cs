using Market.Class.Repositories;
using Market.Interfaces;
using System;
using System.Windows.Forms;


namespace Market.Forms.FormsAdmin
{
    public partial class FormAdminTotal : Form
    {
        public FormAdminTotal()
        {
            InitializeComponent();
        }

        private void FormAdminTotal_Load(object sender, EventArgs e)
        {
            ITotalMarket totalMarket = new MarketTotal();
            AdminTotal.Text = totalMarket.MoneyTotalAdmin();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            {
                ITotalMarket totalMarket = new MarketTotal();
                var resault = totalMarket.MoneyTotalAdmin();
            }
        }
    }
}
