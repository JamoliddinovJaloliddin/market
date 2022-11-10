using Market.Class.Models;
using Market.Forms;
using Market.Forms.FormsAdmin;
using Market.Forms.FormsUser;
using Market.MarketClass.Data;
using Market.MarketClass.Repositories;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace Market
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }   

        private void Button_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = null;
            textBoxLogin.Text = null;
            textBoxPassword.Text = null;
        }

        private void ButtunSignUp_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (textBoxLogin.Text == "admin")
                {
                    GlobalVariables.adminName = textBoxUser.Text;
                    if (textBoxLogin.Text == "admin")
                    {
                        MainMenuRepositories main = new MainMenuRepositories();
                        var admin = main.CheckAdmin(textBoxPassword.Text, textBoxUser.Text);

                        if (admin)
                        {

                            FormAdminPanel form = new FormAdminPanel();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kiritisgda xatolik");
                        }
                    }
                }
                else if (textBoxLogin.Text == "user")
                {
                    MainMenuRepositories main = new MainMenuRepositories();
                    var users = main.CheckUser(textBoxPassword.Text, textBoxUser.Text);
                    GlobalVariables.userName = textBoxUser.Text;

                    if (users)
                    {
                        FormUserPanel formUserPanel = new FormUserPanel();
                        formUserPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kiritishda Xatolik");
                    }
                }
                else
                {
                    MessageBox.Show("Kiritishda xatoli");
                    textBoxUser.Text = null;
                    textBoxLogin.Text = null;
                    textBoxPassword.Text = null;
                }
            }
            catch
            {

            }
        }
    }
}
