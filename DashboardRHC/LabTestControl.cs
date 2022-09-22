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
    public partial class LabTestControl : UserControl
    {
        public LabTestControl()
        {
            InitializeComponent();
        }

        public delegate void LabTestControlClose(object sender, EventArgs e);
        public event LabTestControlClose Close;

        private void btnSaveLabTest_Click(object sender, EventArgs e)
        {
            if (txtLabTetsName.Text == "" || txtNormalValue.Text == "")
            {
                MessageBox.Show("Please Enter LabTest Name & Normal Value.");
                return;
            }
            if (!Regex.Match(txtLabTetsName.Text, "[a-zA-Z][A-Z]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Lab Test Name." +
                    "\n\nHint: Avoid Special Characters and Numbers.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLabTetsName.Focus();
                return;
            }
            LabTestEntity new_LabTest = new LabTestEntity();
            new_LabTest.LabTestID = 0;
            new_LabTest.LabTestName = txtLabTetsName.Text;
            new_LabTest.NormalRange = txtNormalValue.Text;
            new_LabTest.Remarks = txtRemarks.Text;
            new_LabTest.CreatedByID = 2;
            new_LabTest.CreatedDateTime = DateTime.Now;

            long new_medicine_id = LabTestController.LabTestInsertUpdate(new_LabTest);
            if(new_medicine_id > 0)
            {
                gdvLabTest.DataSource = null;
                List<LabTestEntity> labtest_list = new List<LabTestEntity>();
                labtest_list = LabTestController.LabTestSelectAll();
                gdvLabTest.DataSource = labtest_list;
                MessageBox.Show("Lab Test is Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void LabTestControl_Load(object sender, EventArgs e)
        {
            List<LabTestEntity> labtest_list = new List<LabTestEntity>();
            labtest_list = LabTestController.LabTestSelectAll();
            gdvLabTest.DataSource = labtest_list;
        }

        private void btnCloseLabTest_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
