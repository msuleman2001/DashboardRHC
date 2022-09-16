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

namespace DashboardRHC
{
    public partial class MedicineControl : UserControl
    {
        public MedicineControl()
        {
            InitializeComponent();
        }

        public delegate void MedicineControlClose(object sender, EventArgs e);
        public event MedicineControlClose Close;

        private void btnSaveMedicine_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == "" || txtPotency.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Name & Potency.");
                return;
            }
            MedicineEntity new_medicine = new MedicineEntity();
            new_medicine.MedicineID = 0;
            new_medicine.MedicineName = txtMedicineName.Text;
            new_medicine.Potency = txtPotency.Text;
            new_medicine.Remarks = txtRemarks.Text;
            new_medicine.CreatedByID = 2;
            new_medicine.CreatedDateTime = DateTime.Now;
            long new_medicine_id = MedicineContorller.MedicineInsertUpdate(new_medicine);
            if(new_medicine_id > 0)
            
            {
                gdvMedicine.DataSource = null;
                List<MedicineEntity> medicine_list = new List<MedicineEntity>();
                medicine_list = MedicineContorller.MedicineSelectAll();
                gdvMedicine.DataSource = medicine_list;
                MessageBox.Show("Medicine is added");
            }

        }

        private void MedicineControl_Load(object sender, EventArgs e)
        {
            List<MedicineEntity> medicine_list = new List<MedicineEntity>();
            medicine_list = MedicineContorller.MedicineSelectAll();
            gdvMedicine.DataSource = medicine_list;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(sender, e);
        }
    }
}
