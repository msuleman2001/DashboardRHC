using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

using Entities;
using Controllers;

namespace DashboardRHC
{
    public partial class frmLogin : Form
    {
        //Hi i am just a comment...
        frmDashboard frmDashboard;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmLogin()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //int admin_id = (int)CenterAdminController.CenterAdminLogin("super", "");
            //if (admin_id == -1)
            //{
            //    frmCenterAdminPassword obj = new frmCenterAdminPassword();
            //    obj.Show();
            //}

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Must Provide Username and Password");
                return;
            }
            long admin_id = CenterAdminController.CenterAdminLogin(txtAdminName.Text, txtPassword.Text);
            if (admin_id > 0)
            {
                frmDashboard = new frmDashboard();
                Program.AdminID = admin_id;
                frmDashboard.Tag = admin_id;
                //AdminLogEntity admin_log = new AdminLogEntity();
                //admin_log.AdminLogID = 0;
                //admin_log.AdminID = admin_id;
                //admin_log.LoginDateTime = DateTime.Now;
                //admin_log.LogoutDateTime = DateTime.Now;
                //admin_log.Remarks = " ";
                //long admin_log_id = AdminLogController.InsertUpdateAdminLog(admin_log);
                //frmDashboard.AdminLogID = Convert.ToInt32(admin_log_id);
                frmDashboard.Show();
                
                Hide();
            }
            else if(admin_id == -3 )
                MessageBox.Show("Incorrect Password");
            else if (admin_id == -2)
                MessageBox.Show("Incorrect Username");
            else 
                MessageBox.Show("No user found in DB.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
