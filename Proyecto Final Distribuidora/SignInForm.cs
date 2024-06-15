using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Distribuidora
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (AuthenticateUser(username, password))
            {
                // Check the username to determine which form to open
                if (username == "admin")
                {
                    MenuFormDBA menuFormDBA = new MenuFormDBA();
                    menuFormDBA.Show();
                }
                else if (username == "user")
                {
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            return (username == "admin" && password == "admin123") || (username == "user" && password == "user123");
        }
    }
}
