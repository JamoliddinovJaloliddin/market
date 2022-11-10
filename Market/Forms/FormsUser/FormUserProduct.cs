using Market.Class.Models;
using Market.Class.Repositories;
using Market.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using History = Market.Class.Models.History;

namespace Market.Forms.FormsUser
{
    
    public partial class FormUserProduct : Form
        
    {
        private int counter = 1;
        public static IList<History> add = new List<History>();
        private double summa = 0;
        private Dictionary<string, int> productsCheck = new Dictionary<string, int>();
        
        public FormUserProduct()
        {
            InitializeComponent();
        }

        private void FormUserProduct_Load(object sender, EventArgs e)
        {
            try
            {
                IProductRepositoriesUser productRepositoriesUser = new ProductRepositoriesUser();
                var resault = productRepositoriesUser.GettAllUser();


                listView1.Items.Clear();
                foreach (var item in resault)
                {
                    ListViewItem listviev = new ListViewItem(new string[] { counter++.ToString(), item.Name, item.Price.ToString(), item.Description });
                    listView1.Items.Add(listviev);
                }

                foreach (var item in resault)
                {
                    ComboBoxUser.Items.Add(item.Name);
                }
            }
            catch
            { 
            }
        }

        private void ComboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IProductRepositoriesUser product = new ProductRepositoriesUser();
                var resault = product.GettAllUser();

                foreach (var item in resault)
                {
                    if (ComboBoxUser.Text == item.Name)
                    {
                        IdBox.Text = item.Id.ToString();
                        NameBox.Text = item.Name;
                        PriceBoxUser.Text = item.Price.ToString();
                        DicBox.Text = item.Description;
                    }

                }
            }
            catch
            { 
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdBox.Text != null && NameBox.Text != null && PriceBoxUser.Text != null && DicBox.Text != null)
                {
                    IProductRepositoriesUser product = new ProductRepositoriesUser();
                    var resault = product.GettAllUser();
                    ITotalUser totalUser = new UserTotals();
                    var money = totalUser.MoneyTotalUser();

                    foreach (var res in resault)
                    {
                        if (res.Name == ComboBoxUser.Text)
                        {
                            summa += res.Price;
                            for (int i = 0; i <= productsCheck.Count; i++)
                            {
                                if (productsCheck.ContainsKey(res.Name))
                                {
                                    productsCheck[res.Name] += 1;
                                }
                                else
                                {
                                    productsCheck.Add(res.Name, 1);
                                }
                            }
                        }
                        else if (res.Name == ComboBoxUser.Text && money < summa)
                        {
                            MessageBox.Show("Sizda mablag' yetari emas");
                            productsCheck.Clear();
                            summa = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Qatorni to'ldiring");
                }
            }
            catch
            {
                MessageBox.Show("Xatolik yuz berdi, dastur tugatildi");
            }
        }


        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                IProductRepositoriesUser product = new ProductRepositoriesUser();
                var resault = product.GettAllUser();
                foreach (var res in resault)
                {
                    if (int.Parse(IdBox.Text) == res.Id && NameBox.Text == res.Name && double.Parse(PriceBoxUser.Text) == res.Price && DicBox.Text == res.Description)
                    {
                        if (summa / 2 > 0)
                        {
                            string add = "";
                            ITotalUser totalUser = new UserTotals();
                            var resaul = totalUser.MoneyTotalUserReduce(summa / 2);
                            if (resaul)
                            {
                                foreach (var item in productsCheck)
                                {
                                    add += $"{item.Key}  -  {item.Value / 2}\n";
                                }
                                History historyadd = new History(GlobalVariables.userName, add, DateTime.Now, summa);
                                IHistory history = new HistoryPro();
                                history.HistoryAppend(historyadd);
                                MessageBox.Show($"Mijoz: {historyadd.User}\nMahsulotlar:\n{historyadd.Name}Vaqt: {historyadd.DateTime.ToString()}\nSumma: {historyadd.TotalBuy.ToString()} so'm");
                                MessageBox.Show("Xaridingiz uchun raxmat.\nBuyurmangiz tez orada yetkaziladi ");
                                totalUser.MoneyMarket(summa / 2);
                                totalUser.MoneyTotalUserReduce(summa / 2);
                            }
                            else
                            {
                                MessageBox.Show("Hisobingizda mablag' yetarli emas");
                            }
                            productsCheck.Clear();
                            summa = 0;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xatolik yuz berdi, dastur tugatildi");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IProductRepositoriesUser product = new ProductRepositoriesUser();
            var resault = product.GettAllUser();
            foreach (var item in resault)
            {
                if (int.Parse(IdBox.Text) == item.Id && NameBox.Text == item.Name && double.Parse(PriceBoxUser.Text) == item.Price && DicBox.Text == item.Description)
                {
                    if (summa / 2 > 0)
                    {
                        MessageBox.Show("Buyurtma bekor qilindi");
                        productsCheck.Clear();
                        summa = 0;
                    }
                }
            }
        }
    }
}
