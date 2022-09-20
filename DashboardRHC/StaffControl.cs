using System;
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
using System.Text.RegularExpressions;

namespace DashboardRHC
{
    public partial class StaffControl : UserControl
    {
        int staff_id = 0;
        public StaffControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Please Enter Staff Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtStaffName.Text, "[a-zA-Z][A-Z]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Staff Name." +
                    "\n\nHint: Avoid Special Characters and Numbers.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStaffName.Focus();
                return;
            }
            if (txtDesignation.Text == "")
            {
                MessageBox.Show("Please Enter Designation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (txtQualification.Text == "")
            {
                MessageBox.Show("Please Enter Qualification.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtPhone.Text, "[0-9]").Success)
            {
                MessageBox.Show("Please Enter a Valid Phone Number." +
                    "\n\nHint: Avoid Special Characters and Alphabets.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhone.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StaffRHCEntity staff = new StaffRHCEntity();
            staff.StaffID = Convert.ToInt32(this.Tag);
            staff.StaffName = txtStaffName.Text;
            staff.StaffPassword = txtStaffName.Tag.ToString();
            staff.StaffPhone = txtPhone.Text;
            staff.StaffAddress = txtAddress.Text;
            staff.Designation = txtDesignation.Text;
            staff.Qualification = txtQualification.Text;
            staff.CreatedByID = Convert.ToInt32(this.Parent.Parent.Tag);
            staff.CreatedDateTime = DateTime.Now;
            staff.Remarks = txtRemarks.Text;
            staff.IsEnabled = chkIsEnabled.Checked.ToString();
            staff.LastUpdateDateTime = DateTime.Now;
            staff.LastUpdateID = Convert.ToInt32(this.Parent.Parent.Tag);
            if (StaffRHCController.InsertUpdateStaffRHC(staff) > 0)
            {
                MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
               
            else
                MessageBox.Show("Unable to store data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ClearFields()
        {
            this.Tag = 0;
            txtStaffName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtDesignation.Text = "";
            txtQualification.Text = "";
            txtRemarks.Text = "";
            chkIsEnabled.Checked = false;
        }

        private void tabStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabStaff.SelectedIndex == 0)
            {
                dgvStaff.AutoGenerateColumns = false;
                dgvStaff.DataSource = StaffRHCController.StaffRHCSelectAll();
            }
            else
            {
                if(staff_id != 0)
                {
                    StaffRHCEntity staff = StaffRHCController.StaffRHCSelectByID(staff_id);
                    this.Tag = staff.StaffID;
                    txtStaffName.Text = staff.StaffName;
                    txtStaffName.Tag = staff.StaffPassword;
                    txtDesignation.Text = staff.Designation;
                    txtQualification.Text = staff.Qualification;
                    txtPhone.Text = staff.StaffPhone;
                    txtAddress.Text = staff.StaffAddress;
                    chkIsEnabled.Checked = Convert.ToBoolean(staff.IsEnabled);
                    txtRemarks.Text = staff.Remarks;
                }
            }

        }

        private void StaffControl_Load(object sender, EventArgs e)
        {
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = StaffRHCController.StaffRHCSelectAll();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                staff_id = Convert.ToInt32(dgvStaff.Rows[e.RowIndex].Cells[0].Value);
                this.Tag = staff_id;
                tabStaff.SelectedIndex = 1;
            }
        }
    }
}
