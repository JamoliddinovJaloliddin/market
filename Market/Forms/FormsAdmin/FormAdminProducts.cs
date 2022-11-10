using Market.Interfaces;
using MiniMarket.Repositories;
using System;
using System.Windows.Forms;
using MiniMarket.Models;
using System.Linq;

namespace Market.Forms.FormsAdmin
{
    public partial class FormAdminProduct : Form
    {
        private Form1 activateForm;

        public FormAdminProduct()
        {
            InitializeComponent();
        }

        private void FormAdminProducts_Load(object sender, EventArgs e)
        {
            IProductRepositoriesAdmin product = new ProductRepositories(); 
            var resault = product.GetAllAdmin();
            var res = resault.OrderBy(x => x.Id);

            listViewAdmin.Items.Clear();
           
            foreach (var item in res)
            {
                var row = new string[] {item.Id.ToString(), item.Name, item.Price.ToString(), item.Description };
                var lvi = new ListViewItem(row);
                lvi.Tag = item;
                listViewAdmin.Items.Add(lvi);
            }
            foreach (var item in resault)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                if (IdBox.Text != null && NameBox.Text != null && PriceBox.Text != null && DicBox.Text != null)
                {
                    IProductRepositoriesAdmin productt = new ProductRepositories();
                    var resaultt = productt.GetAllAdmin();
                    foreach (var item in resaultt)
                    {

                        if (NameBox.Text == item.Name && int.Parse(PriceBox.Text) == item.Price && DicBox.Text == item.Description)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        MessageBox.Show("Bu ma'lumot mavjud");
                    }
                    else
                    {
                        Product product = new Product(int.Parse(IdBox.Text), NameBox.Text, double.Parse(PriceBox.Text), DicBox.Text);
                        IProductRepositoriesAdmin products = new ProductRepositories();
                        var resault = products.Create(product);
                        var res = products.CheckIdNumber();
                        MessageBox.Show("Ma'lumot kiritildi");
                    }
                }
            }
            catch
            { 
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdBox.Text != null && NameBox.Text != null && PriceBox.Text != null && DicBox.Text != null)
                {
                    Product product = new Product(int.Parse(IdBox.Text), NameBox.Text, double.Parse(PriceBox.Text), DicBox.Text);
                    IProductRepositoriesAdmin products = new ProductRepositories();
                    var resault = products.Update(product);
                    if (resault == false)
                    {
                        MessageBox.Show("Error ID");
                        IdBox.Text = null;

                    }
                    else
                    {
                        MessageBox.Show("Amaliyot bajarildi");
                        IdBox.Text = null;
                        NameBox.Text = null;
                        PriceBox.Text = null;
                        DicBox.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Jadvalni to'ldiring");
                }
            }
            catch
            { 
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product(int.Parse(IdBox.Text), NameBox.Text, double.Parse(PriceBox.Text), DicBox.Text);
                IProductRepositoriesAdmin products = new ProductRepositories();
                var resault = products.Delete(product.Id);
                if (resault == false)
                {
                    MessageBox.Show("Error");
                    IdBox.Text = null;
                    NameBox.Text = null;
                    PriceBox.Text = null;
                    DicBox.Text = null;
                }
                else
                {
                    MessageBox.Show("Amaliyot bajarildi");
                    IdBox.Text = null;
                    NameBox.Text = null;
                    PriceBox.Text = null;
                    DicBox.Text = null;
                }
            }
            catch
            { 
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IProductRepositoriesAdmin product = new ProductRepositories();
            var resault = product.GetAllAdmin();

            foreach (var item in resault)
            {
                if (comboBox1.Text == item.Name)
                {
                    IdBox.Text = item.Id.ToString();
                    NameBox.Text = item.Name;
                    PriceBox.Text = item.Price.ToString();
                    DicBox.Text = item.Description;
                }
            }
        }
    }
}
