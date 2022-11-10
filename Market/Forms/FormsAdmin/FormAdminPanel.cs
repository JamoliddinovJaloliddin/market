using Market.Class.Models;
using System;
using System.Windows.Forms;

namespace Market.Forms.FormsAdmin
{
    public partial class FormAdminPanel : Form
    {
        private Form activateForm;
 
        public FormAdminPanel()
        {
            InitializeComponent();
        }
        public void OpenChildFrom(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFormAdmin.Controls.Add(childForm);
            this.panelFormAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonTotal_Click_1(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsAdmin.FormAdminTotal());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Invalidate(); 
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsAdmin.FormAdminProduct());
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            labelAdminName.Text = GlobalVariables.adminName;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsAdmin.FormAdminHistory());
        }
    }
}
