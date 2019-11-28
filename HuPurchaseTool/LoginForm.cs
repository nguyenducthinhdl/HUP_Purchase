using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuPurchaseTool
{
    public partial class frmLogin : Form
    {
        const int NUMBER_VALUE = 10;
        const string PASSWORD = "Hu";
        string lastPass = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginPurchase() {
            if (txtPassword.Text == PASSWORD + lastPass)
            {
                var purchaseForm = new frmPurchase();
                this.Hide();
                purchaseForm.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("Wrong Password :(", "Can not login");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginPurchase();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                loginPurchase();
            }
        }
    }
}
