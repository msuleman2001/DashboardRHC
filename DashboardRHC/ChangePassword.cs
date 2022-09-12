using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Entities;
using Controllers;

namespace DashboardRHC
{
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {     
            //we are appling new checks for required fields in change password
            //Hi I am line 27 comment....
            if (txtNewPassword.Text != txtConfPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password are not same");
                return;
            }

            long admin_id = Program.AdminID;
            string old_admin_password = txtOldPassword.Text;
            string new_admin_password = txtNewPassword.Text;
            admin_id = CenterAdminController.ChangeAdminPassword(admin_id, old_admin_password, new_admin_password);
            if (admin_id > 0)
                MessageBox.Show("Password changed");
            else if (admin_id == -1)
                MessageBox.Show("Old Password not matching");
            else
                MessageBox.Show("Some other error. Contact to administration");
        }
    }
}
