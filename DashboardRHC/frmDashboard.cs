using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Entities;
using Controllers;

namespace DashboardRHC
{
    public partial class frmDashboard : Form
    {
        frmLogin frmLogin;
        DateTime current_admin_log_datetime;
        List<AdmittedPatientEntity> un_uploaded_patients;

        public bool timerIsRunning;
        public int AdminLogID { get; set; }


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
        public frmDashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            timerIsRunning = true;
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Sidebar_Click(object sender, EventArgs e)
        {
            foreach (Control button_ctrl in pnlSidebar.Controls)
            {
                Button sidebar_button = (Button)button_ctrl;
                sidebar_button.BackColor = Color.FromArgb(46, 51, 73);
            }

            Button current_button = (Button)sender;
            current_button.BackColor = Color.FromArgb(74, 79, 99);
            pnlBody.Controls.Clear();
            Control loading_control = new Control();
            switch (current_button.Name)
            {
                case "btnHome":
                    loading_control = new HomeControl();
                    break;
                case "btnPatient":
                    loading_control = new PatientControl();
                    break;
                case "btnStaff":
                    loading_control = new StaffControl();
                    break;
                case "btnDevices":
                    loading_control = new DeviesControl();
                    break;
            }

            loading_control.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(loading_control);
        }

        private void pnlCommand_MouseHover(object sender, EventArgs e)
        {
            pnlAdminOps.Visible = true;
        }

        private void pnlAdminOps_MouseHover(object sender, EventArgs e)
        {
            pnlAdminOps.Visible = true;
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                niSAFERH.Visible = true;
            }
        }

        private void niSAFERH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmLogin.Show();
            Hide();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            frmLogin = new frmLogin();
            long admin_id = Program.AdminID;

            lblNameRHC.Text = ConfigurationManager.AppSettings["CenterName"];

            if (admin_id != 1)
            {
                CenterAdminEntity center_admin = CenterAdminController.CenterAdminSelectByID(admin_id);
                lblUsername.Text = center_admin.AdminName;

                //int admin_log_id = Convert.ToInt32(AdminLogID);
                //AdminLogEntity current_admin_log = AdminLogController.AdminLogSelectByID(admin_log_id);

                //current_admin_log_datetime = current_admin_log.LoginDateTime;
            }
            else
                lblUsername.Text = "superadmin";
            
            HomeControl home_control = new HomeControl();
            pnlBody.Controls.Add(home_control);

            //un_uploaded_patients = AdmittedPatientController.GetUnUploadedPatients();
            //if (un_uploaded_patients.Count > 0)
            //    tmrDashboard.Enabled = true;
        }

        private void pnlAdminOps_MouseLeave(object sender, EventArgs e)
        {
            pnlAdminOps.Visible = false;
        }  

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            AdminControl admin_control = new AdminControl();
            pnlBody.Controls.Add(admin_control);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            ChangePassword change_password = new ChangePassword();
            change_password.Dock = DockStyle.Fill;
            change_password.Tag = Program.AdminID;
            pnlBody.Controls.Add(change_password);
        }

        private void btnStartCollectionService_Click(object sender, EventArgs e)
        {
            if (Program.AdminID != 1)
            {
                System.Windows.Forms.MessageBox.Show("Service Start/Stop only perform by Superadmin");
                return;
            }


        }
    }
}
