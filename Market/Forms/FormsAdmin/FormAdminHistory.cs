using Market.Class.Repositories;
using Market.Interfaces;
using System;
using System.Windows.Forms;

namespace Market.Forms.FormsAdmin
{
    public partial class FormAdminHistory : Form
    {
        public FormAdminHistory()
        {
            InitializeComponent();
        }

        private void FormAdminHistory_Load(object sender, EventArgs e)
        {
            IHistory history = new HistoryPro();
            var resault = history.HistoryGettAllMarket();

            foreach (var item in resault)
            {
                listBox1.Items.Add($"Foydalanuvchi: {item.User}");
                listBox1.Items.Add($"Maxsulotlar:");
                listBox1.Items.Add(item.Name);
                listBox1.Items.Add($"Sana: {item.DateTime}");
                listBox1.Items.Add($"Umumiy summa: {item.TotalBuy}");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
            }
        }
    }
}
