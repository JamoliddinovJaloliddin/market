using Market.Class.Repositories;
using Market.Interfaces;
using System;
using System.Windows.Forms;

namespace Market.Forms.FormsUser
{
    public partial class FormUserTotal : Form
    {
        public FormUserTotal()
        {
            InitializeComponent();
        }

        private void FormUserTotal_Load(object sender, EventArgs e)
        {
            ITotalUser totalUser = new UserTotals();
            UserTotal.Text = totalUser.MoneyTotalUser().ToString();
        }

    }
}
