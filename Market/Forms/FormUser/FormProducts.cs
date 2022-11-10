using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Interfaces;
using MiniMarket.Constans;
using MiniMarket.Repositories;

namespace Market.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void listBoxProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            IProductRepositories productRepositories = new ProductRepositories();
            var resault = productRepositories.GetAll();
            foreach (var product in resault)
            {
                listBoxProducts.Items.Add($"{product.Id} {product.Name} {product.Price} {product.Description}");
                //Gridwill
                
            }
        }
    }
}
