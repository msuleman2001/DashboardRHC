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
    public partial class PatientReadings : UserControl
    {
        public string PatientName { get; set; }
        public PatientReadings()
        {
            InitializeComponent();
        }

        private void PatientReadings_Load(object sender, EventArgs e)
        {
            lblPatientName.Text = PatientName;
            LoadData();
        }

        void LoadData()
        {
            string[] patient_data = File.ReadAllLines("patient_data.csv");
            
        }
    }
}
