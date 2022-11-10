using Market.Class.Models;
using Market.Class.Repositories;
using Market.Interfaces;
using System;
using System.Windows.Forms;

namespace Market.Forms.FormsUser
{
    public partial class FormUserHistory : Form
    {
        public FormUserHistory()
        {
            InitializeComponent();
        }

        private void FormUserHistory_Load(object sender, EventArgs e)
        {
            IHistory history = new HistoryPro();
            var resault = history.HistoryGettAllUser();

            foreach (var item in resault)
            {
                if (item.User == GlobalVariables.userName)
                {
                    listBoxHistory.Items.Add($"Mijoz: {item.User}");
                    listBoxHistory.Items.Add($"Maxsulotlar:");
                    listBoxHistory.Items.Add(item.Name);
                    listBoxHistory.Items.Add($"Sana: {item.DateTime}");
                    listBoxHistory.Items.Add($"Umumiy summa: {item.TotalBuy}");
                    listBoxHistory.Items.Add("");
                    listBoxHistory.Items.Add("");
                }
            }
        }
    }
}
