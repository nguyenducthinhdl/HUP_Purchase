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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            HUUserManagement.GetInstance().bindListUser(dtgUserView);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HUUserManagement.GetInstance().save(dtgUserView);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HUUserManagement.GetInstance().bindListUser(dtgUserView);
        }
    }
}
