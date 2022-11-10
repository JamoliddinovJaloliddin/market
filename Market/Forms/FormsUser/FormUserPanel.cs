using Market.Class.Models;
using System;
using System.Windows.Forms;

namespace Market.Forms.FormsUser
{
    public partial class FormUserPanel : Form
    {
        private Form activateForm;
        public FormUserPanel()
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
            this.panelFormUser.Controls.Add(childForm);
            this.panelFormUser.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormUserPanel_Load(object sender, EventArgs e)
        {
            labelAdminProfil.Text = GlobalVariables.userName;
        }

        private void ButtonTotal_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsUser.FormUserTotal());
        }

        private void ButtonProducts_Click_1(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsUser.FormUserProduct());
        }


        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form1.Invalidate();
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormsUser.FormUserHistory());
        }
    }
}
