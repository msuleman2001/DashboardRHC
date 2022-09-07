using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using Controllers;

namespace DashboardRHC
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void tabManageAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabManageAdmins.SelectedIndex == 0)
                LoadAdminList();
            if (tabManageAdmins.SelectedIndex == 1)
                LoadAdminLogs();

        }

        private void LoadAdminList()
        {
            List<CenterAdminEntity> all_admins = CenterAdminController.CenterAdminSelectAll();
            dgvAdminList.DataSource = all_admins;
        }

        private void LoadAdminLogs()
        {
            List<CenterAdminEntity> admins = CenterAdminController.CenterAdminSelectAll();
            cmbAdminNames.DataSource = admins;
            cmbAdminNames.ValueMember = "AdminID";
            cmbAdminNames.DisplayMember = "AdminName";
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            LoadAdminList();
        }

        private void bntLoadAdminLog_Click(object sender, EventArgs e)
        {
            int admin_id = Convert.ToInt32(cmbAdminNames.SelectedValue);
            List<AdminLogEntity> admin_log = AdminLogController.SelectAdminLogByAdminID(admin_id);
            dgvAdminLog.DataSource = admin_log;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string image_file_name = txtImagePath.Text.Substring(txtImagePath.Text.LastIndexOf("\\") + 1);
            File.Copy(txtImagePath.Text, "C:\\DashboardRHC\\StaffPictures\\" + image_file_name);
            image_file_name = "C:\\DashboardRHC\\StaffPictures\\" + image_file_name;
            CenterAdminEntity new_admin = new CenterAdminEntity();
            new_admin.AdminID = 0;
            new_admin.AdminName = txtAdminName.Text;
            new_admin.AdminPassword = "12345678";
            new_admin.AdminImage = "";
            new_admin.CreatedByID = Convert.ToInt32(this.Parent.FindForm().Tag);
            new_admin.CreatedDateTime = DateTime.Now;
            new_admin.IsEnabled = chkIsEnabled.Checked.ToString();
            new_admin.Remarks = txtRemarks.Text;

            long new_admin_id = CenterAdminController.InsertUpdateCenterAdmin(new_admin);
            if (new_admin_id > 0)
                MessageBox.Show("Admin Added");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAdminImage = new OpenFileDialog();
            ofdAdminImage.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            ofdAdminImage.Title = "Select Image";
            DialogResult dr = ofdAdminImage.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtImagePath.Text = ofdAdminImage.FileName;
                picAdmin.Image = Image.FromFile(ofdAdminImage.FileName);
            }
        }
    }
}
