using MiniMarket.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Forms
{
    public partial class FormBuyPanel : Form
    {

        private Form activateForm;
        public FormBuyPanel()
        {
            InitializeComponent();
        }

        private void OpenChildFrom(Form childForm)
        {
            if (activateForm != null)
            { 
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBuyPanel.Controls.Add(childForm);
            this.panelBuyPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void History_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormProducts());
        }

        private void Total_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsTotal());
        }

        private void Products_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsHistory());
        }

        private void FormBuyPanel_Load(object sender, EventArgs e)
        {

        }

        private void panelBuyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
