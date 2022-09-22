using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Entities;
using Controllers;

namespace DashboardRHC
{
    public partial class PatientControl : UserControl
    {
        JObject patient_symptom_json = new JObject();
        JObject cat_values;
        MedicineControl medicine_control;
        LabTestControl lab_test_control;
        JProperty current_symptom;
        List<object> checked_items = new List<object>();
        Dictionary<string, long> symptom_dict = new Dictionary<string, long>();
        bool by_cnic = false;
        bool by_phone = false;
        int symptom_list_index = -1;   

        public PatientControl()
        {
            InitializeComponent();
        }

        private void tabPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPatient.SelectedIndex == 0)
            {
                dgvPatientList.AutoGenerateColumns = false;
                dgvPatientList.DataSource = AdmittedPatientController.AdmittedPatientSelectAll();
            }

            if (tabPatient.SelectedIndex == 1)
            {
                long patient_id = Convert.ToInt64(txtPatientName.Tag);
                List<PatientVitalsEntity> patient_vitals = PatientVitalsController.GetPatientVitals(patient_id);
                if (patient_vitals != null)
                {
                    dgvPatientVisitVitals.AutoGenerateColumns = false;
                    dgvPatientVisitVitals.DataSource = patient_vitals;
                }
            }

            if (tabPatient.SelectedIndex == 2)
            {
                  //It will map value to primary key in table; 
                List<SymptomEntity> symptom_list = SymptomController.SymptomSelectAll();
                cmbSymptom.DataSource = symptom_list;
                cmbSymptom.ValueMember = "SymptomID";
                cmbSymptom.DisplayMember = "SymptomTitle";

                symptom_dict.Clear();
                lstSymptoms.Items.Clear();
                foreach (SymptomEntity symptom in symptom_list)
                {
                    lstSymptoms.Items.Add(symptom.SymptomTitle);
                    symptom_dict[symptom.SymptomTitle] = symptom.SymptomID;
                }
            }

            if (tabPatient.SelectedIndex == 5)
            {
                long current_patient_id = 0;
                if (txtPatientName.Tag.ToString() != "0")
                    current_patient_id = Convert.ToInt64(txtPatientName.Tag);

                txtObservationPatientName.Text = txtPatientName.Text;
                List<StaffRHCEntity> staff_list = StaffRHCController.StaffRHCSelectAll();
                cmbDoctor.DataSource = staff_list;
                cmbDoctor.ValueMember = "StaffID";
                cmbDoctor.DisplayMember = "StaffName";
                List<StaffObservationEntity> observation_history = StaffObservationController.GetPatientObservationHistory(current_patient_id);
                dgvPatientList.AutoGenerateColumns = false;
                dgvPatientObservationHistory.DataSource = observation_history;
            }
        }

        private void PatientControl_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            DateTime dob = dtpDOB.Value.Date;
            int years = today.Year - dob.Year;
            int months = today.Month - dob.Month;
            int days = today.Day - dob.Day;

            if (months < 0)
            {
                years--;
                months = months + 12;
            }

            if (days < 0)
            {
                months--;
                days = days + 30;
            }


            lblAge.Text = years + "Y, " + months + "M, " + days + "D"; 

        }

        private void lstSymptom_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                checked_items.Add(lstSymptoms.SelectedItem);
            else
                checked_items.Remove(lstSymptoms.SelectedItem);

            string symptom_name = lstSymptoms.Items[e.Index].ToString();
            long symptom_id = symptom_dict[symptom_name];

            scSymptoms.Panel2.Enabled = e.NewValue.Equals(CheckState.Checked) ? true : false;
            JProperty patient_symptom_prop = new JProperty(symptom_name);
            current_symptom = patient_symptom_prop;

            if (e.NewValue == CheckState.Checked)
                patient_symptom_json.Add(patient_symptom_prop);
            if (e.NewValue == CheckState.Unchecked)
                patient_symptom_json.Remove(patient_symptom_prop.Name);
        }

        private void SymptomCheckedChanged(object sender, EventArgs e)
        {
            CheckBox check_box = sender as CheckBox;
            string category_name = check_box.Parent.Text;

            //if (!ExistsProperty(current_symptom, category_name))
            //{
                //JObject category_object = new JObject();
                JProperty category = new JProperty(category_name);
                JArray values = new JArray();
                foreach (Control ctrl in check_box.Parent.Controls)
                {
                    CheckBox box = ctrl as CheckBox;
                    if (box.Checked)
                        values.Add(box.Text);
                }
                category.Value = values;

                JObject updated_symptom = new JObject();
                updated_symptom.Add(category);
                foreach (JToken category_token in patient_symptom_json[current_symptom.Name].Children())
                {
                    JProperty prop = category_token as JProperty;
                    if (updated_symptom[prop.Name] == null)
                        updated_symptom.Add(prop);
                }
                                    
                patient_symptom_json.Property(current_symptom.Name).Value = updated_symptom;
            //}
        }

        private void Illness_CheckedChange(object sender, EventArgs e)
        {
            CheckBox illness_check = (CheckBox)sender;
            if (illness_check.Checked)
            {

                illness_check.Parent.Tag = 1;
            }
            else
            {
                foreach (Control ctrl in illness_check.Parent.Controls)
                {
                    CheckBox c = (CheckBox)ctrl;
                    if (c.Checked)
                        return;
                }
                illness_check.Parent.Tag = 0;
            }
        }

        private void btnSymptomSave_Click(object sender, EventArgs e)
        {
            SymptomEntity new_symptom = new SymptomEntity();
            new_symptom.SymptomID = Convert.ToInt32(cmbSymptom.SelectedValue);
            new_symptom.SymptomTitle = cmbSymptom.Text;
            new_symptom.CategoryAndValue = txtCategoryAndValues.Text.Replace(Environment.NewLine, "");
            new_symptom.CreatedDateTime = DateTime.Now;
            new_symptom.SymptomRemarks = "NA";
            new_symptom.SymptomEnabled = "1";
            new_symptom.CreatedByID = Program.AdminID;
            
            if (SymptomController.SymptomInsertUpdate(new_symptom) > 0)
                System.Windows.Forms.MessageBox.Show("Value added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddCategoryAndValue_Click(object sender, EventArgs e)
        {
            if (cat_values == null)
                cat_values = new JObject();

            JArray value_array = new JArray(txtValues.Text.Split(','));
            cat_values.Add(txtCategoryName.Text, value_array);
            txtCategoryAndValues.Text = cat_values.ToString();
            txtCategoryName.Text = txtValues.Text = "";
        }

        private void cmbSymptom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category_values = "";

            if (cmbSymptom.SelectedItem != null)
            {
                category_values = ((SymptomEntity)cmbSymptom.SelectedItem).CategoryAndValue;
                cat_values = JObject.Parse(category_values);
            }
            else
                cat_values = new JObject();

            txtCategoryAndValues.Text = cat_values.ToString();      
        }

        private void bntNewTitle_Click(object sender, EventArgs e)
        {
            cmbSymptom.SelectedItem = null;
            cmbSymptom.Text = "";
        }

        private void btnAddSymptom_Click(object sender, EventArgs e)
        {
            PatientSymptomEntity add_symptom = new PatientSymptomEntity();
            add_symptom.PatientSymptomID = 0;
            add_symptom.PatientID = Convert.ToInt64(txtPatientName.Tag);
            add_symptom.SymptomID = Convert.ToInt64(txtCategoryName.Text);
            add_symptom.PatientSymptomValue = txtCategoryAndValues.Text;
            add_symptom.DateCreated = DateTime.Now;
            add_symptom.CreatedByID = Program.AdminID;
            add_symptom.Remarks = txtMedicalInfoRemarks.Text;

            if (PatientSymptomController.PatientSymptomInsertUpdate(add_symptom) > 0)
            {
                MessageBox.Show("Value is added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSavePatientInfo_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show("Please Enter Patient Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtPatientName.Text, "[a-zA-Z][A-Z]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Patient Name." +
                    "\n\nHint: Avoid Special Characters and Numbers.", "Message" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPatientName.Focus();
                return;
            }
            if (txtAttendentName.Text == "")
            {
                MessageBox.Show("Please Enter Attendent Name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtAttendentName.Text, "[a-zA-Z][A-Z]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Attendent Name." +
                    "\n\nHint: Avoid Special Characters and Numbers.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAttendentName.Focus();
                return;
            }
            if (txtCNIC.Text.Length < 15)
            {
                MessageBox.Show("Please Enter CNIC.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPhone.Text.Length < 12)
            {
                MessageBox.Show("Please Enter Phone Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdmittedPatientEntity new_patient = new AdmittedPatientEntity();
            new_patient.PatientID = Convert.ToInt64(txtPatientName.Tag);
            new_patient.PatientName = txtPatientName.Text;
            new_patient.AttendentName = txtAttendentName.Text;
            new_patient.PatientCNIC = txtCNIC.Text.Replace("-", "");
            new_patient.AttendentPhone = txtPhone.Text.Replace("-", "");
            new_patient.PatientDOB = dtpDOB.Value;
            new_patient.PatientAddress = txtAddress.Text;
            new_patient.PatientGender = cmbGender.Text;
            new_patient.AdmissionDate = DateTime.Now;
            new_patient.AdmittedByID = Program.AdminID;
            new_patient.DischargeDateTime = DateTime.MinValue;
            new_patient.Remarks = txtMedicalInfoRemarks.Text;

            long new_id = AdmittedPatientController.InsertUpdateAdmittedPatient(new_patient);

            if ( new_id > 0)
            {
                txtPatientName.Tag = new_id;
                btnSaveVitals.Enabled= true;
                MessageBox.Show("New Patient Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNewMedicine_Click(object sender, EventArgs e)
        {
            medicine_control = new MedicineControl();
            medicine_control.Top = 100;
            medicine_control.Left = 200;
            tabPatient.TabPages["tpgMedicine"].Controls.Add(medicine_control);
            medicine_control.BringToFront();
            medicine_control.Close += new MedicineControl.MedicineControlClose(RemoveMedicineControl);
        }

        private void RemoveMedicineControl(object sender, EventArgs e)
        {
            tabPatient.TabPages["tpgMedicine"].Controls.Remove(medicine_control);
        }

        private void btnMedicineSave_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == "" || txtDosage.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Name & Dosage.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtDosage.Text, "[a-zA-Z0-9]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Medicine Dosage." +
                    "\n\nHint: Avoid Special Characters.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDosage.Focus();
                return;
            }


            if (Convert.ToInt64(txtPatientName.Tag) == 0)
            {
                MessageBox.Show("Select or save patient!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PatientMedicineEntity new_patient_medicine = new PatientMedicineEntity();
            new_patient_medicine.PatientMedicineID = Convert.ToInt64(txtMedicineName.Tag);
            new_patient_medicine.PatientID = Convert.ToInt64(txtPatientName.Tag);
            new_patient_medicine.MedicineID = Convert.ToInt64(txtMedicineName.Tag);
            new_patient_medicine.Dosage = txtDosage.Text;
            new_patient_medicine.CreatedByID = Program.AdminID;
            new_patient_medicine.CreatedDateTime = DateTime.Now;
            new_patient_medicine.Remarks = txtMedicineRemarks.Text;
            long new_patient_medicine_id = PatientMedicineController.PatientMedicineInsertUpdate(new_patient_medicine);
            if (new_patient_medicine_id > 0)
            {
                List<PatientMedicineEntity> patient_medicines = PatientMedicineController.GetPatientMedcineByPatientID(new_patient_medicine.PatientID);
                gdvMedicine.DataSource = patient_medicines;
                MessageBox.Show("value is added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNewLabTest_Click(object sender, EventArgs e)
        {
            lab_test_control = new LabTestControl();
            lab_test_control.Top = 100;
            lab_test_control.Left = 200;
            tabPatient.TabPages["tpgLabTest"].Controls.Add(lab_test_control);
            lab_test_control.BringToFront();
            lab_test_control.Close += new LabTestControl.LabTestControlClose(RemoveLabTestControl);
        }

        private void RemoveLabTestControl(object sender, EventArgs e)
        {
            tabPatient.TabPages["tgpLabTest"].Controls.Remove(lab_test_control);
        }

        private void btnPatientLabTestSave_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text == "" || txtValue.Text == "")
            {
                MessageBox.Show("Please Enter Test Name & Value.");
                return;
            }
            
            PatientLabTestEntity new_patient_labtest = new PatientLabTestEntity();
            new_patient_labtest.PatientLabTestID = 0;
            new_patient_labtest.LabTestID = 1;
            new_patient_labtest.PatientID = Convert.ToInt32(txtPatientName.Tag);
            new_patient_labtest.LabTestValue = txtTestName.Text;
            new_patient_labtest.Remarks = txtLabTestRemarks.Text;
            new_patient_labtest.CreatedByID = Program.AdminID;
            new_patient_labtest.CreatedDateTime = DateTime.Now;

            if (PatientLabTestController.PatientLabTestInsertUpdate(new_patient_labtest) > 0)
            {
                MessageBox.Show("Value is added to patient Record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            if (!gdvMedicine.Visible)
            {
                gdvMedicine.Visible = true;
                gdvMedicine.Top = 45;
                gdvMedicine.Left = 140;
                gdvMedicine.Width = 505;
                gdvMedicine.Height = 200;
            }

            List<MedicineEntity> all_medicines = MedicineContorller.MedicineSelectAll();
            gdvMedicine.AutoGenerateColumns = false;
            gdvMedicine.DataSource = all_medicines.FindAll(m => m.MedicineName.ToLower().Contains((txtMedicineName.Text.ToLower())));
        }

        private void gdvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int medicine_id = Convert.ToInt32(gdvMedicine[0, e.RowIndex].Value);
            string medicine_name = Convert.ToString(gdvMedicine[1, e.RowIndex].Value);
            txtMedicineName.Text = medicine_name;
            txtMedicineName.Tag = medicine_id;
            gdvMedicine.Visible = false;
        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {
            if (!gdvLabTest.Visible)
            {
                gdvLabTest.Visible = true;
                gdvLabTest.Top = 60;
                gdvLabTest.Left = 130;
                gdvLabTest.Width = 505;
                gdvLabTest.Height = 200;

            }
            List<LabTestEntity> all_labtest = LabTestController.LabTestSelectAll();
            gdvLabTest.AutoGenerateColumns = false;
            gdvLabTest.DataSource = all_labtest.FindAll(lab => lab.LabTestName.ToLower().Contains((txtTestName.Text).ToLower()));
        }

        private void gdvLabTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int labtest_id = Convert.ToInt32(gdvLabTest[0, e.RowIndex].Value);
            string labtest_name = Convert.ToString(gdvLabTest[1, e.RowIndex].Value);
            txtTestName.Text = labtest_name;
            txtTestName.Tag = labtest_id;
            gdvLabTest.Visible = false;
        }

        private void LoadPatient(object sender, EventArgs e)
        {
            Button find_button = sender as Button;
            string criteria = find_button.Tag.ToString();
            string search_string = "";

            if (criteria == "cnic")
                search_string = txtCNIC.Text.Replace("-", "");
            if (criteria == "phone")
                search_string = txtPhone.Text.Replace("-", "");

            if (search_string == "")
            {
                MessageBox.Show("Please input CNIC or Phone.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<AdmittedPatientEntity> patients = AdmittedPatientController.GetPatientByPhoneOrCNIC(search_string);
            dgvPatientList.DataSource = null;
            dgvPatientList.Rows.Clear();
            if (patients.Count > 0)
            {
                dgvPatientList.AutoGenerateColumns = false;
                dgvPatientList.DataSource = patients;
            }
                
        }

        private void dgvPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long patient_id = Convert.ToInt64(dgvPatientList.Rows[e.RowIndex].Cells[0].Value);
            
            if (patient_id == 0)
                return;

            btnSaveVitals.Enabled = true;

            AdmittedPatientEntity patient = AdmittedPatientController.AdmittedPatientSelectByID(patient_id);
            if (patient != null)
            {
                txtPatientName.Text = patient.PatientName;
                txtPatientName.Tag = patient.PatientID;
                txtAttendentName.Text = patient.AttendentName;
                txtCNIC.Text = patient.PatientCNIC;
                txtPhone.Text = patient.AttendentPhone;
                dtpDOB.Value = patient.PatientDOB;
                cmbGender.SelectedItem = patient.PatientGender;
                txtAddress.Text = patient.PatientAddress;
                txtPatientPersonalInfoRemarks.Text = patient.Remarks;
                btnVisitHistory.Enabled = true;

                List<PatientMedicineEntity> patient_medicine = PatientMedicineController.GetPatientMedcineByPatientID(patient_id);
                dgvMedicineHistory.DataSource = patient_medicine;
                List<PatientLabTestEntity> patient_labtest = PatientLabTestController.PatientLabTestByPatientID(patient_id);
                dgvLabTestHistory.DataSource = patient_labtest;
            }

        }

        private void btnVisitHistory_Click(object sender, EventArgs e)
        {

            tabPatient.SelectedIndex = 1;
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            txtPatientName.Text = "";
            txtPatientName.Tag = 0;
            txtAttendentName.Text = "";
            txtCNIC.Text = "";
            txtPhone.Text = "";
            dtpDOB.Value = DateTime.Now;
            cmbGender.SelectedIndex = 0;
            txtAddress.Text = "";
            txtPatientPersonalInfoRemarks.Text = "";
        }

        private void lstSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checked_items.Find(item => item.ToString() == lstSymptoms.SelectedItem.ToString()) != null)
                scSymptoms.Panel2.Enabled = true;
            else
                scSymptoms.Panel2.Enabled = false;

            if (lstSymptoms.SelectedIndex != symptom_list_index)
                symptom_list_index = lstSymptoms.SelectedIndex;
            else
                return;

            object symptom_name = lstSymptoms.SelectedItem;
            
            if (checked_items.Contains(symptom_name))
                current_symptom = patient_symptom_json.Property(symptom_name.ToString());

            long symptom_id = symptom_dict[symptom_name.ToString()];
            SymptomEntity symptom = SymptomController.SymptomSelectByID(symptom_id);
            JObject category_values = JObject.Parse(symptom.CategoryAndValue);
            scSymptoms.Panel2.Controls.Clear();
            foreach (JProperty property in category_values.Properties())
            {
                string category_name = property.Name;
                GroupBox gb_category = new GroupBox();
                gb_category.Text = category_name;
                gb_category.Dock = DockStyle.Top;
                gb_category.ForeColor = Color.White;
                
                scSymptoms.Panel2.Controls.Add(gb_category);
                scSymptoms.Panel2.AutoScroll = true;

                int x_location = 10;
                JArray values = property.Value as JArray;
                foreach (string value in values)
                {
                    CheckBox category_value_check = new CheckBox();

                    category_value_check.Text = value.ToString().ToUpper();
                    category_value_check.AutoSize = false;
                    category_value_check.Size = new Size(150, 30);
                    category_value_check.ForeColor = Color.White;
                    category_value_check.Location = new Point(x_location, 20);
                    category_value_check.Checked = GetSymptomValueFromPatientJSON(symptom.SymptomTitle, category_value_check.Text);
                    
                    x_location += 160;
                    category_value_check.CheckedChanged += new EventHandler(SymptomCheckedChanged);
                    gb_category.Controls.Add(category_value_check);
                }
            }
        }

        private bool GetSymptomValueFromPatientJSON(string symptom_name, string value)
        {
            if (patient_symptom_json.HasValues)
            {
                JProperty symptom_prop = patient_symptom_json.Property(symptom_name);
                if (symptom_prop != null)
                {
                    JToken category_token = symptom_prop.Value;
                    if (category_token != null)
                        return category_token.ToString().Contains(value);
                }
            }
            return false;
        }

        private void CheckedSetup(object sender, EventArgs e)
        {
            ((CheckBox)sender).CheckedChanged += new EventHandler(SymptomCheckedChanged);
        }

        private void btnSaveStaffObservation_Click(object sender, EventArgs e)
        {
            if (txtObservationPatientName.Text == "" || txtObservation.Text == "")
            {
                MessageBox.Show("Please Enter Patient Name & Observation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.Match(txtObservationPatientName.Text, "[a-zA-Z][A-Z]*$").Success)
            {
                MessageBox.Show("Please Enter a Valid Patient Name." +
                    "\n\nHint: Avoid Special Characters and Numbers.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtObservationPatientName.Focus();
                return;
            }
            if (txtPatientName.Tag.ToString() == "0")
            {
                MessageBox.Show("Save patient data before saving observation", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            


            StaffObservationEntity staff_observation = new StaffObservationEntity();
            staff_observation.StaffObservationID = 0;
            staff_observation.StaffObserationByID = Convert.ToInt64(cmbDoctor.SelectedValue);
            staff_observation.PatientID = Convert.ToInt64(txtPatientName.Tag); 
            staff_observation.StaffObservationDetails = txtObservation.Text;
            staff_observation.Remarks = txtObservationRemarks.Text;
            staff_observation.AdminID = Program.AdminID;
            staff_observation.CreatedDateTime = DateTime.Now;
            long new_ob_id = StaffObservationController.InsertUpdateStaffObservation(staff_observation);
            if (new_ob_id > 0)
                MessageBox.Show("Observation Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error");
        }

        private void btnSaveVitals_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(txtWeight.Text, "[-+]?[0-9]*\\.?[0-9]*").Success)
            {
                MessageBox.Show("Please Enter a Valid Value." +
                    "\n\nHint: Avoid Alphabets & Special Character.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPatientName.Focus();
                return;
            }
            long patient_id = Convert.ToInt64(txtPatientName.Tag);
            if (patient_id > 0)
            {
                foreach (Control ctrl in gbMedicalInfo.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(MaskedTextBox))
                    {
                        PatientVitalsEntity vital = new PatientVitalsEntity();
                        vital.PatientVitalID = 0;
                        vital.PatientID = patient_id;
                        vital.VitalName = ctrl.Tag.ToString();
                        vital.VitalValue = ctrl.Text;
                        vital.VitalDateTime = DateTime.Now;
                        PatientVitalsController.InsertUpdatePatientVitals(vital);
                    }
                }
                MessageBox.Show("Values Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvPatientList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
