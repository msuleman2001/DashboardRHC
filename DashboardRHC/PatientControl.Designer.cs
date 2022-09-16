
namespace DashboardRHC
{
    partial class PatientControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPatient = new System.Windows.Forms.TabControl();
            this.tpgPatientPersonalData = new System.Windows.Forms.TabPage();
            this.btnSaveVitals = new System.Windows.Forms.Button();
            this.btnVisitHistory = new System.Windows.Forms.Button();
            this.btnSavePatientInfo = new System.Windows.Forms.Button();
            this.gbPatientList = new System.Windows.Forms.GroupBox();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.colAdmittedPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMedicalInfo = new System.Windows.Forms.GroupBox();
            this.txtBloodPressure = new System.Windows.Forms.MaskedTextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.lblHeartRate = new System.Windows.Forms.Label();
            this.lblBloodPressure = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtMedicalInfoRemarks = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblMedicalInfoRemarks = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.txtPatientPersonalInfoRemarks = new System.Windows.Forms.TextBox();
            this.lblPatientPersonaleInfoRemarks = new System.Windows.Forms.Label();
            this.btnLoadPatientDataByPhone = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnLoadPatientDataByCNIC = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.lblPatientCNIC = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAttendentName = new System.Windows.Forms.Label();
            this.txtAttendentName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.tpgVisitHistory = new System.Windows.Forms.TabPage();
            this.dgvPatientVisitVitals = new System.Windows.Forms.DataGridView();
            this.colVisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpgSymptoms = new System.Windows.Forms.TabPage();
            this.pnlNewSymptoms = new System.Windows.Forms.Panel();
            this.gbNewSymptom = new System.Windows.Forms.GroupBox();
            this.bntNewTitle = new System.Windows.Forms.Button();
            this.cmbSymptom = new System.Windows.Forms.ComboBox();
            this.txtCategoryAndValues = new System.Windows.Forms.TextBox();
            this.gbCategoryAndValues = new System.Windows.Forms.GroupBox();
            this.lblValues = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnAddCategoryAndValue = new System.Windows.Forms.Button();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddNewSymptom = new System.Windows.Forms.Button();
            this.lblSymptomTitle = new System.Windows.Forms.Label();
            this.btnSavePatientSymptom = new System.Windows.Forms.Button();
            this.pnlPatientSymptoms = new System.Windows.Forms.Panel();
            this.scSymptoms = new System.Windows.Forms.SplitContainer();
            this.lstSymptoms = new System.Windows.Forms.CheckedListBox();
            this.tpgMedicine = new System.Windows.Forms.TabPage();
            this.gdvMedicine = new System.Windows.Forms.DataGridView();
            this.colMedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewMedicine = new System.Windows.Forms.Button();
            this.btnMedicineSave = new System.Windows.Forms.Button();
            this.txtMedicineRemarks = new System.Windows.Forms.TextBox();
            this.lblPatientMedicineRemarks = new System.Windows.Forms.Label();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.dgvMedicineHistory = new System.Windows.Forms.DataGridView();
            this.colMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdvisedByDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.tpgLabTest = new System.Windows.Forms.TabPage();
            this.gdvLabTest = new System.Windows.Forms.DataGridView();
            this.LabTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewLabTest = new System.Windows.Forms.Button();
            this.btnPatientLabTestSave = new System.Windows.Forms.Button();
            this.txtLabTestRemarks = new System.Windows.Forms.TextBox();
            this.lblTestRemarks = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.dgvLabTestHistory = new System.Windows.Forms.DataGridView();
            this.colLabTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNormalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdvisedByID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lblLabTestName = new System.Windows.Forms.Label();
            this.tpgStaffObservations = new System.Windows.Forms.TabPage();
            this.lblPatientObservationHistory = new System.Windows.Forms.Label();
            this.dgvPatientObservationHistory = new System.Windows.Forms.DataGridView();
            this.colStaffObservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservationDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservationPatientName = new System.Windows.Forms.TextBox();
            this.lblObservationPatientName = new System.Windows.Forms.Label();
            this.btnSaveStaffObservation = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtObservationRemarks = new System.Windows.Forms.TextBox();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblObservation = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.tabPatient.SuspendLayout();
            this.tpgPatientPersonalData.SuspendLayout();
            this.gbPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.gbMedicalInfo.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.tpgVisitHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisitVitals)).BeginInit();
            this.tpgSymptoms.SuspendLayout();
            this.pnlNewSymptoms.SuspendLayout();
            this.gbNewSymptom.SuspendLayout();
            this.gbCategoryAndValues.SuspendLayout();
            this.pnlPatientSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSymptoms)).BeginInit();
            this.scSymptoms.Panel1.SuspendLayout();
            this.scSymptoms.SuspendLayout();
            this.tpgMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineHistory)).BeginInit();
            this.tpgLabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLabTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabTestHistory)).BeginInit();
            this.tpgStaffObservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientObservationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.tpgPatientPersonalData);
            this.tabPatient.Controls.Add(this.tpgVisitHistory);
            this.tabPatient.Controls.Add(this.tpgSymptoms);
            this.tabPatient.Controls.Add(this.tpgMedicine);
            this.tabPatient.Controls.Add(this.tpgLabTest);
            this.tabPatient.Controls.Add(this.tpgStaffObservations);
            this.tabPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPatient.Location = new System.Drawing.Point(0, 0);
            this.tabPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPatient.Multiline = true;
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.SelectedIndex = 0;
            this.tabPatient.Size = new System.Drawing.Size(1400, 750);
            this.tabPatient.TabIndex = 1;
            this.tabPatient.SelectedIndexChanged += new System.EventHandler(this.tabPatient_SelectedIndexChanged);
            // 
            // tpgPatientPersonalData
            // 
            this.tpgPatientPersonalData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpgPatientPersonalData.Controls.Add(this.btnSaveVitals);
            this.tpgPatientPersonalData.Controls.Add(this.btnVisitHistory);
            this.tpgPatientPersonalData.Controls.Add(this.btnSavePatientInfo);
            this.tpgPatientPersonalData.Controls.Add(this.gbPatientList);
            this.tpgPatientPersonalData.Controls.Add(this.gbMedicalInfo);
            this.tpgPatientPersonalData.Controls.Add(this.gbPersonalInfo);
            this.tpgPatientPersonalData.Location = new System.Drawing.Point(4, 24);
            this.tpgPatientPersonalData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgPatientPersonalData.Name = "tpgPatientPersonalData";
            this.tpgPatientPersonalData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgPatientPersonalData.Size = new System.Drawing.Size(1392, 722);
            this.tpgPatientPersonalData.TabIndex = 0;
            this.tpgPatientPersonalData.Text = "Patien Personal Data";
            // 
            // btnSaveVitals
            // 
            this.btnSaveVitals.Enabled = false;
            this.btnSaveVitals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveVitals.ForeColor = System.Drawing.Color.White;
            this.btnSaveVitals.Location = new System.Drawing.Point(808, 388);
            this.btnSaveVitals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveVitals.Name = "btnSaveVitals";
            this.btnSaveVitals.Size = new System.Drawing.Size(88, 27);
            this.btnSaveVitals.TabIndex = 12;
            this.btnSaveVitals.Text = "Save Vitals";
            this.btnSaveVitals.UseVisualStyleBackColor = true;
            this.btnSaveVitals.Click += new System.EventHandler(this.btnSaveVitals_Click);
            // 
            // btnVisitHistory
            // 
            this.btnVisitHistory.Enabled = false;
            this.btnVisitHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitHistory.ForeColor = System.Drawing.Color.White;
            this.btnVisitHistory.Location = new System.Drawing.Point(712, 388);
            this.btnVisitHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVisitHistory.Name = "btnVisitHistory";
            this.btnVisitHistory.Size = new System.Drawing.Size(88, 27);
            this.btnVisitHistory.TabIndex = 11;
            this.btnVisitHistory.Text = "Visit History";
            this.btnVisitHistory.UseVisualStyleBackColor = true;
            this.btnVisitHistory.Click += new System.EventHandler(this.btnVisitHistory_Click);
            // 
            // btnSavePatientInfo
            // 
            this.btnSavePatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePatientInfo.ForeColor = System.Drawing.Color.White;
            this.btnSavePatientInfo.Location = new System.Drawing.Point(308, 388);
            this.btnSavePatientInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSavePatientInfo.Name = "btnSavePatientInfo";
            this.btnSavePatientInfo.Size = new System.Drawing.Size(136, 27);
            this.btnSavePatientInfo.TabIndex = 10;
            this.btnSavePatientInfo.Text = "Save Patient Info";
            this.btnSavePatientInfo.UseVisualStyleBackColor = true;
            this.btnSavePatientInfo.Click += new System.EventHandler(this.btnSavePatientInfo_Click);
            // 
            // gbPatientList
            // 
            this.gbPatientList.Controls.Add(this.dgvPatientList);
            this.gbPatientList.ForeColor = System.Drawing.Color.White;
            this.gbPatientList.Location = new System.Drawing.Point(26, 430);
            this.gbPatientList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPatientList.Name = "gbPatientList";
            this.gbPatientList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPatientList.Size = new System.Drawing.Size(870, 255);
            this.gbPatientList.TabIndex = 5;
            this.gbPatientList.TabStop = false;
            this.gbPatientList.Text = "Patient List";
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdmittedPatientID,
            this.colPatientName,
            this.colAttendentName,
            this.colDOB,
            this.colGender,
            this.colDateCreated});
            this.dgvPatientList.Location = new System.Drawing.Point(7, 22);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.ReadOnly = true;
            this.dgvPatientList.RowHeadersVisible = false;
            this.dgvPatientList.RowTemplate.Height = 25;
            this.dgvPatientList.Size = new System.Drawing.Size(856, 227);
            this.dgvPatientList.TabIndex = 0;
            this.dgvPatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_CellContentClick);
            // 
            // colAdmittedPatientID
            // 
            this.colAdmittedPatientID.DataPropertyName = "PatientID";
            this.colAdmittedPatientID.HeaderText = "PatientID";
            this.colAdmittedPatientID.Name = "colAdmittedPatientID";
            this.colAdmittedPatientID.ReadOnly = true;
            this.colAdmittedPatientID.Visible = false;
            // 
            // colPatientName
            // 
            this.colPatientName.DataPropertyName = "PatientName";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.colPatientName.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPatientName.HeaderText = "Patient Name";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.ReadOnly = true;
            this.colPatientName.Width = 200;
            // 
            // colAttendentName
            // 
            this.colAttendentName.DataPropertyName = "AttendentName";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.colAttendentName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAttendentName.HeaderText = "Attendent Name";
            this.colAttendentName.Name = "colAttendentName";
            this.colAttendentName.ReadOnly = true;
            this.colAttendentName.Width = 200;
            // 
            // colDOB
            // 
            this.colDOB.DataPropertyName = "PatientDOB";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.colDOB.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDOB.HeaderText = "Date of Birth";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "PatientGender";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.colGender.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colDateCreated
            // 
            this.colDateCreated.DataPropertyName = "AdmissionDate";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.colDateCreated.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDateCreated.HeaderText = "Entry Date";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.ReadOnly = true;
            // 
            // gbMedicalInfo
            // 
            this.gbMedicalInfo.Controls.Add(this.txtBloodPressure);
            this.gbMedicalInfo.Controls.Add(this.txtHeartRate);
            this.gbMedicalInfo.Controls.Add(this.lblHeartRate);
            this.gbMedicalInfo.Controls.Add(this.lblBloodPressure);
            this.gbMedicalInfo.Controls.Add(this.txtTemperature);
            this.gbMedicalInfo.Controls.Add(this.lblTemperature);
            this.gbMedicalInfo.Controls.Add(this.txtMedicalInfoRemarks);
            this.gbMedicalInfo.Controls.Add(this.txtHeight);
            this.gbMedicalInfo.Controls.Add(this.txtWeight);
            this.gbMedicalInfo.Controls.Add(this.lblMedicalInfoRemarks);
            this.gbMedicalInfo.Controls.Add(this.lblWeight);
            this.gbMedicalInfo.Controls.Add(this.lblHeight);
            this.gbMedicalInfo.ForeColor = System.Drawing.Color.White;
            this.gbMedicalInfo.Location = new System.Drawing.Point(475, 22);
            this.gbMedicalInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMedicalInfo.Name = "gbMedicalInfo";
            this.gbMedicalInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMedicalInfo.Size = new System.Drawing.Size(421, 360);
            this.gbMedicalInfo.TabIndex = 4;
            this.gbMedicalInfo.TabStop = false;
            this.gbMedicalInfo.Text = "Medical Info";
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.Location = new System.Drawing.Point(113, 118);
            this.txtBloodPressure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBloodPressure.Mask = "000/000";
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.Size = new System.Drawing.Size(288, 23);
            this.txtBloodPressure.TabIndex = 11;
            this.txtBloodPressure.Tag = "Blood Pressure";
            this.txtBloodPressure.ValidatingType = typeof(int);
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Location = new System.Drawing.Point(113, 149);
            this.txtHeartRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(288, 23);
            this.txtHeartRate.TabIndex = 12;
            this.txtHeartRate.Tag = "Heart Rate";
            // 
            // lblHeartRate
            // 
            this.lblHeartRate.AutoSize = true;
            this.lblHeartRate.Location = new System.Drawing.Point(37, 152);
            this.lblHeartRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeartRate.Name = "lblHeartRate";
            this.lblHeartRate.Size = new System.Drawing.Size(62, 15);
            this.lblHeartRate.TabIndex = 14;
            this.lblHeartRate.Text = "Heart Rate";
            // 
            // lblBloodPressure
            // 
            this.lblBloodPressure.AutoSize = true;
            this.lblBloodPressure.Location = new System.Drawing.Point(15, 121);
            this.lblBloodPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodPressure.Name = "lblBloodPressure";
            this.lblBloodPressure.Size = new System.Drawing.Size(85, 15);
            this.lblBloodPressure.TabIndex = 12;
            this.lblBloodPressure.Text = "Blood Pressure";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(113, 87);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(288, 23);
            this.txtTemperature.TabIndex = 10;
            this.txtTemperature.Tag = "Temperature";
            this.txtTemperature.Text = "0";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(28, 90);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(73, 15);
            this.lblTemperature.TabIndex = 10;
            this.lblTemperature.Text = "Temperature";
            // 
            // txtMedicalInfoRemarks
            // 
            this.txtMedicalInfoRemarks.Location = new System.Drawing.Point(113, 179);
            this.txtMedicalInfoRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMedicalInfoRemarks.Multiline = true;
            this.txtMedicalInfoRemarks.Name = "txtMedicalInfoRemarks";
            this.txtMedicalInfoRemarks.Size = new System.Drawing.Size(288, 149);
            this.txtMedicalInfoRemarks.TabIndex = 13;
            this.txtMedicalInfoRemarks.Tag = "Remarks";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(113, 55);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(288, 23);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.Tag = "Height";
            this.txtHeight.Text = "0";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(113, 24);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(288, 23);
            this.txtWeight.TabIndex = 8;
            this.txtWeight.Tag = "Weight";
            this.txtWeight.Text = "0";
            // 
            // lblMedicalInfoRemarks
            // 
            this.lblMedicalInfoRemarks.AutoSize = true;
            this.lblMedicalInfoRemarks.Location = new System.Drawing.Point(49, 182);
            this.lblMedicalInfoRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicalInfoRemarks.Name = "lblMedicalInfoRemarks";
            this.lblMedicalInfoRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblMedicalInfoRemarks.TabIndex = 3;
            this.lblMedicalInfoRemarks.Text = "Remarks";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(30, 28);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(70, 15);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (KG)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(41, 59);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(65, 15);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height (M)";
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.btnNewPatient);
            this.gbPersonalInfo.Controls.Add(this.txtPatientPersonalInfoRemarks);
            this.gbPersonalInfo.Controls.Add(this.lblPatientPersonaleInfoRemarks);
            this.gbPersonalInfo.Controls.Add(this.btnLoadPatientDataByPhone);
            this.gbPersonalInfo.Controls.Add(this.txtPhone);
            this.gbPersonalInfo.Controls.Add(this.btnLoadPatientDataByCNIC);
            this.gbPersonalInfo.Controls.Add(this.cmbGender);
            this.gbPersonalInfo.Controls.Add(this.txtCNIC);
            this.gbPersonalInfo.Controls.Add(this.lblPatientCNIC);
            this.gbPersonalInfo.Controls.Add(this.lblAge);
            this.gbPersonalInfo.Controls.Add(this.txtAddress);
            this.gbPersonalInfo.Controls.Add(this.lblGender);
            this.gbPersonalInfo.Controls.Add(this.lblAddress);
            this.gbPersonalInfo.Controls.Add(this.dtpDOB);
            this.gbPersonalInfo.Controls.Add(this.lblDOB);
            this.gbPersonalInfo.Controls.Add(this.lblPhone);
            this.gbPersonalInfo.Controls.Add(this.lblAttendentName);
            this.gbPersonalInfo.Controls.Add(this.txtAttendentName);
            this.gbPersonalInfo.Controls.Add(this.lblPatientName);
            this.gbPersonalInfo.Controls.Add(this.txtPatientName);
            this.gbPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.gbPersonalInfo.Location = new System.Drawing.Point(26, 22);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPersonalInfo.Size = new System.Drawing.Size(418, 360);
            this.gbPersonalInfo.TabIndex = 3;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Info";
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPatient.Location = new System.Drawing.Point(350, 20);
            this.btnNewPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(29, 23);
            this.btnNewPatient.TabIndex = 26;
            this.btnNewPatient.Text = "N";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // txtPatientPersonalInfoRemarks
            // 
            this.txtPatientPersonalInfoRemarks.Location = new System.Drawing.Point(120, 269);
            this.txtPatientPersonalInfoRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPatientPersonalInfoRemarks.Multiline = true;
            this.txtPatientPersonalInfoRemarks.Name = "txtPatientPersonalInfoRemarks";
            this.txtPatientPersonalInfoRemarks.Size = new System.Drawing.Size(258, 59);
            this.txtPatientPersonalInfoRemarks.TabIndex = 7;
            // 
            // lblPatientPersonaleInfoRemarks
            // 
            this.lblPatientPersonaleInfoRemarks.AutoSize = true;
            this.lblPatientPersonaleInfoRemarks.Location = new System.Drawing.Point(56, 272);
            this.lblPatientPersonaleInfoRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientPersonaleInfoRemarks.Name = "lblPatientPersonaleInfoRemarks";
            this.lblPatientPersonaleInfoRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblPatientPersonaleInfoRemarks.TabIndex = 16;
            this.lblPatientPersonaleInfoRemarks.Text = "Remarks";
            // 
            // btnLoadPatientDataByPhone
            // 
            this.btnLoadPatientDataByPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPatientDataByPhone.Location = new System.Drawing.Point(350, 111);
            this.btnLoadPatientDataByPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadPatientDataByPhone.Name = "btnLoadPatientDataByPhone";
            this.btnLoadPatientDataByPhone.Size = new System.Drawing.Size(29, 23);
            this.btnLoadPatientDataByPhone.TabIndex = 25;
            this.btnLoadPatientDataByPhone.Tag = "phone";
            this.btnLoadPatientDataByPhone.Text = "F";
            this.btnLoadPatientDataByPhone.UseVisualStyleBackColor = true;
            this.btnLoadPatientDataByPhone.Click += new System.EventHandler(this.LoadPatient);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 111);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Mask = "0000-0000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 23);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.ValidatingType = typeof(int);
            // 
            // btnLoadPatientDataByCNIC
            // 
            this.btnLoadPatientDataByCNIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPatientDataByCNIC.Location = new System.Drawing.Point(350, 81);
            this.btnLoadPatientDataByCNIC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadPatientDataByCNIC.Name = "btnLoadPatientDataByCNIC";
            this.btnLoadPatientDataByCNIC.Size = new System.Drawing.Size(29, 23);
            this.btnLoadPatientDataByCNIC.TabIndex = 25;
            this.btnLoadPatientDataByCNIC.Tag = "cnic";
            this.btnLoadPatientDataByCNIC.Text = "F";
            this.btnLoadPatientDataByCNIC.UseVisualStyleBackColor = true;
            this.btnLoadPatientDataByCNIC.Click += new System.EventHandler(this.LoadPatient);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(120, 171);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(258, 23);
            this.cmbGender.TabIndex = 5;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(120, 81);
            this.txtCNIC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(222, 23);
            this.txtCNIC.TabIndex = 2;
            this.txtCNIC.ValidatingType = typeof(int);
            // 
            // lblPatientCNIC
            // 
            this.lblPatientCNIC.AutoSize = true;
            this.lblPatientCNIC.Location = new System.Drawing.Point(72, 85);
            this.lblPatientCNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientCNIC.Name = "lblPatientCNIC";
            this.lblPatientCNIC.Size = new System.Drawing.Size(38, 15);
            this.lblPatientCNIC.TabIndex = 11;
            this.lblPatientCNIC.Text = "CNIC:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(286, 144);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 202);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 59);
            this.txtAddress.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(64, 180);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(61, 212);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(120, 141);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(158, 23);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(78, 149);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(31, 15);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "DOB";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(69, 120);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblAttendentName
            // 
            this.lblAttendentName.AutoSize = true;
            this.lblAttendentName.Location = new System.Drawing.Point(15, 55);
            this.lblAttendentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendentName.Name = "lblAttendentName";
            this.lblAttendentName.Size = new System.Drawing.Size(95, 15);
            this.lblAttendentName.TabIndex = 3;
            this.lblAttendentName.Text = "Attendent Name";
            // 
            // txtAttendentName
            // 
            this.txtAttendentName.Location = new System.Drawing.Point(120, 51);
            this.txtAttendentName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAttendentName.Name = "txtAttendentName";
            this.txtAttendentName.Size = new System.Drawing.Size(258, 23);
            this.txtAttendentName.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(30, 24);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(79, 15);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(120, 21);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(222, 23);
            this.txtPatientName.TabIndex = 0;
            this.txtPatientName.Tag = "0";
            // 
            // tpgVisitHistory
            // 
            this.tpgVisitHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpgVisitHistory.Controls.Add(this.dgvPatientVisitVitals);
            this.tpgVisitHistory.Location = new System.Drawing.Point(4, 24);
            this.tpgVisitHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgVisitHistory.Name = "tpgVisitHistory";
            this.tpgVisitHistory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgVisitHistory.Size = new System.Drawing.Size(1392, 722);
            this.tpgVisitHistory.TabIndex = 4;
            this.tpgVisitHistory.Text = "Visit History";
            // 
            // dgvPatientVisitVitals
            // 
            this.dgvPatientVisitVitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientVisitVitals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVisitDate,
            this.colVitalName,
            this.colVitalValue});
            this.dgvPatientVisitVitals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientVisitVitals.Location = new System.Drawing.Point(4, 3);
            this.dgvPatientVisitVitals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPatientVisitVitals.Name = "dgvPatientVisitVitals";
            this.dgvPatientVisitVitals.RowHeadersVisible = false;
            this.dgvPatientVisitVitals.Size = new System.Drawing.Size(1384, 716);
            this.dgvPatientVisitVitals.TabIndex = 0;
            // 
            // colVisitDate
            // 
            this.colVisitDate.DataPropertyName = "VitalDateTime";
            this.colVisitDate.HeaderText = "VisitDate";
            this.colVisitDate.Name = "colVisitDate";
            // 
            // colVitalName
            // 
            this.colVitalName.DataPropertyName = "VitalName";
            this.colVitalName.HeaderText = "Vital Name";
            this.colVitalName.Name = "colVitalName";
            // 
            // colVitalValue
            // 
            this.colVitalValue.DataPropertyName = "VitalValue";
            this.colVitalValue.HeaderText = "Vital Value";
            this.colVitalValue.Name = "colVitalValue";
            // 
            // tpgSymptoms
            // 
            this.tpgSymptoms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpgSymptoms.Controls.Add(this.pnlNewSymptoms);
            this.tpgSymptoms.Controls.Add(this.pnlPatientSymptoms);
            this.tpgSymptoms.Location = new System.Drawing.Point(4, 24);
            this.tpgSymptoms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgSymptoms.Name = "tpgSymptoms";
            this.tpgSymptoms.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgSymptoms.Size = new System.Drawing.Size(1392, 722);
            this.tpgSymptoms.TabIndex = 1;
            this.tpgSymptoms.Text = "Symptoms";
            // 
            // pnlNewSymptoms
            // 
            this.pnlNewSymptoms.Controls.Add(this.gbNewSymptom);
            this.pnlNewSymptoms.Controls.Add(this.btnSavePatientSymptom);
            this.pnlNewSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewSymptoms.Location = new System.Drawing.Point(4, 399);
            this.pnlNewSymptoms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNewSymptoms.Name = "pnlNewSymptoms";
            this.pnlNewSymptoms.Size = new System.Drawing.Size(1384, 320);
            this.pnlNewSymptoms.TabIndex = 1;
            // 
            // gbNewSymptom
            // 
            this.gbNewSymptom.Controls.Add(this.bntNewTitle);
            this.gbNewSymptom.Controls.Add(this.cmbSymptom);
            this.gbNewSymptom.Controls.Add(this.txtCategoryAndValues);
            this.gbNewSymptom.Controls.Add(this.gbCategoryAndValues);
            this.gbNewSymptom.Controls.Add(this.btnAddNewSymptom);
            this.gbNewSymptom.Controls.Add(this.lblSymptomTitle);
            this.gbNewSymptom.ForeColor = System.Drawing.Color.White;
            this.gbNewSymptom.Location = new System.Drawing.Point(3, 5);
            this.gbNewSymptom.Name = "gbNewSymptom";
            this.gbNewSymptom.Size = new System.Drawing.Size(919, 243);
            this.gbNewSymptom.TabIndex = 9;
            this.gbNewSymptom.TabStop = false;
            this.gbNewSymptom.Text = "New Symptom";
            // 
            // bntNewTitle
            // 
            this.bntNewTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNewTitle.ForeColor = System.Drawing.Color.White;
            this.bntNewTitle.Location = new System.Drawing.Point(489, 20);
            this.bntNewTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntNewTitle.Name = "bntNewTitle";
            this.bntNewTitle.Size = new System.Drawing.Size(54, 27);
            this.bntNewTitle.TabIndex = 14;
            this.bntNewTitle.Text = "New";
            this.bntNewTitle.UseVisualStyleBackColor = true;
            // 
            // cmbSymptom
            // 
            this.cmbSymptom.FormattingEnabled = true;
            this.cmbSymptom.Location = new System.Drawing.Point(99, 22);
            this.cmbSymptom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSymptom.Name = "cmbSymptom";
            this.cmbSymptom.Size = new System.Drawing.Size(382, 23);
            this.cmbSymptom.TabIndex = 13;
            // 
            // txtCategoryAndValues
            // 
            this.txtCategoryAndValues.Location = new System.Drawing.Point(575, 26);
            this.txtCategoryAndValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoryAndValues.Multiline = true;
            this.txtCategoryAndValues.Name = "txtCategoryAndValues";
            this.txtCategoryAndValues.ReadOnly = true;
            this.txtCategoryAndValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCategoryAndValues.Size = new System.Drawing.Size(338, 114);
            this.txtCategoryAndValues.TabIndex = 12;
            // 
            // gbCategoryAndValues
            // 
            this.gbCategoryAndValues.Controls.Add(this.lblValues);
            this.gbCategoryAndValues.Controls.Add(this.lblCategoryName);
            this.gbCategoryAndValues.Controls.Add(this.btnAddCategoryAndValue);
            this.gbCategoryAndValues.Controls.Add(this.txtValues);
            this.gbCategoryAndValues.Controls.Add(this.txtCategoryName);
            this.gbCategoryAndValues.ForeColor = System.Drawing.Color.White;
            this.gbCategoryAndValues.Location = new System.Drawing.Point(137, 52);
            this.gbCategoryAndValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCategoryAndValues.Name = "gbCategoryAndValues";
            this.gbCategoryAndValues.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCategoryAndValues.Size = new System.Drawing.Size(406, 115);
            this.gbCategoryAndValues.TabIndex = 11;
            this.gbCategoryAndValues.TabStop = false;
            this.gbCategoryAndValues.Text = "Category and Value";
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(45, 55);
            this.lblValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(40, 15);
            this.lblValues.TabIndex = 8;
            this.lblValues.Text = "Values";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(28, 25);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(60, 15);
            this.lblCategoryName.TabIndex = 7;
            this.lblCategoryName.Text = "Cat Name";
            // 
            // btnAddCategoryAndValue
            // 
            this.btnAddCategoryAndValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoryAndValue.ForeColor = System.Drawing.Color.White;
            this.btnAddCategoryAndValue.Location = new System.Drawing.Point(352, 82);
            this.btnAddCategoryAndValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddCategoryAndValue.Name = "btnAddCategoryAndValue";
            this.btnAddCategoryAndValue.Size = new System.Drawing.Size(47, 27);
            this.btnAddCategoryAndValue.TabIndex = 6;
            this.btnAddCategoryAndValue.Text = "Add";
            this.btnAddCategoryAndValue.UseVisualStyleBackColor = true;
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(97, 52);
            this.txtValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(302, 23);
            this.txtValues.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(97, 22);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(302, 23);
            this.txtCategoryName.TabIndex = 0;
            // 
            // btnAddNewSymptom
            // 
            this.btnAddNewSymptom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSymptom.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSymptom.Location = new System.Drawing.Point(729, 147);
            this.btnAddNewSymptom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewSymptom.Name = "btnAddNewSymptom";
            this.btnAddNewSymptom.Size = new System.Drawing.Size(184, 27);
            this.btnAddNewSymptom.TabIndex = 10;
            this.btnAddNewSymptom.Text = "Save NewSymptoms";
            this.btnAddNewSymptom.UseVisualStyleBackColor = true;
            // 
            // lblSymptomTitle
            // 
            this.lblSymptomTitle.AutoSize = true;
            this.lblSymptomTitle.ForeColor = System.Drawing.Color.White;
            this.lblSymptomTitle.Location = new System.Drawing.Point(7, 26);
            this.lblSymptomTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymptomTitle.Name = "lblSymptomTitle";
            this.lblSymptomTitle.Size = new System.Drawing.Size(84, 15);
            this.lblSymptomTitle.TabIndex = 9;
            this.lblSymptomTitle.Text = "Symptom Title";
            // 
            // btnSavePatientSymptom
            // 
            this.btnSavePatientSymptom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePatientSymptom.ForeColor = System.Drawing.Color.White;
            this.btnSavePatientSymptom.Location = new System.Drawing.Point(929, 12);
            this.btnSavePatientSymptom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSavePatientSymptom.Name = "btnSavePatientSymptom";
            this.btnSavePatientSymptom.Size = new System.Drawing.Size(98, 58);
            this.btnSavePatientSymptom.TabIndex = 0;
            this.btnSavePatientSymptom.Text = "Save Patient Symptom";
            this.btnSavePatientSymptom.UseVisualStyleBackColor = true;
            this.btnSavePatientSymptom.Click += new System.EventHandler(this.btnAddSymptom_Click);
            // 
            // pnlPatientSymptoms
            // 
            this.pnlPatientSymptoms.Controls.Add(this.scSymptoms);
            this.pnlPatientSymptoms.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatientSymptoms.Location = new System.Drawing.Point(4, 3);
            this.pnlPatientSymptoms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPatientSymptoms.Name = "pnlPatientSymptoms";
            this.pnlPatientSymptoms.Size = new System.Drawing.Size(1384, 396);
            this.pnlPatientSymptoms.TabIndex = 0;
            // 
            // scSymptoms
            // 
            this.scSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSymptoms.Location = new System.Drawing.Point(0, 0);
            this.scSymptoms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scSymptoms.Name = "scSymptoms";
            // 
            // scSymptoms.Panel1
            // 
            this.scSymptoms.Panel1.Controls.Add(this.lstSymptoms);
            // 
            // scSymptoms.Panel2
            // 
            this.scSymptoms.Panel2.Enabled = false;
            this.scSymptoms.Size = new System.Drawing.Size(1384, 396);
            this.scSymptoms.SplitterDistance = 460;
            this.scSymptoms.SplitterWidth = 5;
            this.scSymptoms.TabIndex = 0;
            // 
            // lstSymptoms
            // 
            this.lstSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSymptoms.FormattingEnabled = true;
            this.lstSymptoms.Location = new System.Drawing.Point(0, 0);
            this.lstSymptoms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstSymptoms.Name = "lstSymptoms";
            this.lstSymptoms.Size = new System.Drawing.Size(460, 396);
            this.lstSymptoms.TabIndex = 0;
            this.lstSymptoms.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSymptom_ItemCheck);
            this.lstSymptoms.SelectedIndexChanged += new System.EventHandler(this.lstSymptoms_SelectedIndexChanged);
            // 
            // tpgMedicine
            // 
            this.tpgMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpgMedicine.Controls.Add(this.gdvMedicine);
            this.tpgMedicine.Controls.Add(this.btnNewMedicine);
            this.tpgMedicine.Controls.Add(this.btnMedicineSave);
            this.tpgMedicine.Controls.Add(this.txtMedicineRemarks);
            this.tpgMedicine.Controls.Add(this.lblPatientMedicineRemarks);
            this.tpgMedicine.Controls.Add(this.lblDosage);
            this.tpgMedicine.Controls.Add(this.txtDosage);
            this.tpgMedicine.Controls.Add(this.dgvMedicineHistory);
            this.tpgMedicine.Controls.Add(this.txtMedicineName);
            this.tpgMedicine.Controls.Add(this.lblMedicineName);
            this.tpgMedicine.Location = new System.Drawing.Point(4, 24);
            this.tpgMedicine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgMedicine.Name = "tpgMedicine";
            this.tpgMedicine.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgMedicine.Size = new System.Drawing.Size(1392, 722);
            this.tpgMedicine.TabIndex = 3;
            this.tpgMedicine.Text = "Medicine";
            // 
            // gdvMedicine
            // 
            this.gdvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMedicineID,
            this.colName});
            this.gdvMedicine.Location = new System.Drawing.Point(831, 58);
            this.gdvMedicine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gdvMedicine.Name = "gdvMedicine";
            this.gdvMedicine.RowHeadersVisible = false;
            this.gdvMedicine.Size = new System.Drawing.Size(86, 24);
            this.gdvMedicine.TabIndex = 18;
            this.gdvMedicine.Visible = false;
            this.gdvMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvMedicine_CellContentClick);
            // 
            // colMedicineID
            // 
            this.colMedicineID.DataPropertyName = "MedicineID";
            this.colMedicineID.HeaderText = "MedicineID";
            this.colMedicineID.Name = "colMedicineID";
            this.colMedicineID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "MedicineName";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // btnNewMedicine
            // 
            this.btnNewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnNewMedicine.Location = new System.Drawing.Point(760, 25);
            this.btnNewMedicine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewMedicine.Name = "btnNewMedicine";
            this.btnNewMedicine.Size = new System.Drawing.Size(66, 27);
            this.btnNewMedicine.TabIndex = 17;
            this.btnNewMedicine.Text = "New";
            this.btnNewMedicine.UseVisualStyleBackColor = true;
            this.btnNewMedicine.Click += new System.EventHandler(this.btnNewMedicine_Click);
            // 
            // btnMedicineSave
            // 
            this.btnMedicineSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineSave.ForeColor = System.Drawing.Color.White;
            this.btnMedicineSave.Location = new System.Drawing.Point(738, 197);
            this.btnMedicineSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMedicineSave.Name = "btnMedicineSave";
            this.btnMedicineSave.Size = new System.Drawing.Size(88, 27);
            this.btnMedicineSave.TabIndex = 16;
            this.btnMedicineSave.Text = "Save";
            this.btnMedicineSave.UseVisualStyleBackColor = true;
            this.btnMedicineSave.Click += new System.EventHandler(this.btnMedicineSave_Click);
            // 
            // txtMedicineRemarks
            // 
            this.txtMedicineRemarks.Location = new System.Drawing.Point(163, 88);
            this.txtMedicineRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMedicineRemarks.Multiline = true;
            this.txtMedicineRemarks.Name = "txtMedicineRemarks";
            this.txtMedicineRemarks.Size = new System.Drawing.Size(662, 102);
            this.txtMedicineRemarks.TabIndex = 15;
            // 
            // lblPatientMedicineRemarks
            // 
            this.lblPatientMedicineRemarks.AutoSize = true;
            this.lblPatientMedicineRemarks.ForeColor = System.Drawing.Color.White;
            this.lblPatientMedicineRemarks.Location = new System.Drawing.Point(99, 91);
            this.lblPatientMedicineRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientMedicineRemarks.Name = "lblPatientMedicineRemarks";
            this.lblPatientMedicineRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblPatientMedicineRemarks.TabIndex = 14;
            this.lblPatientMedicineRemarks.Text = "Remarks";
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.ForeColor = System.Drawing.Color.White;
            this.lblDosage.Location = new System.Drawing.Point(105, 61);
            this.lblDosage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(46, 15);
            this.lblDosage.TabIndex = 13;
            this.lblDosage.Text = "Dosage";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(163, 58);
            this.txtDosage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(662, 23);
            this.txtDosage.TabIndex = 12;
            // 
            // dgvMedicineHistory
            // 
            this.dgvMedicineHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMedicineName,
            this.colDosage,
            this.colRemarks,
            this.colAdvisedByDateTime});
            this.dgvMedicineHistory.Location = new System.Drawing.Point(163, 231);
            this.dgvMedicineHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMedicineHistory.Name = "dgvMedicineHistory";
            this.dgvMedicineHistory.RowHeadersVisible = false;
            this.dgvMedicineHistory.Size = new System.Drawing.Size(663, 310);
            this.dgvMedicineHistory.TabIndex = 11;
            // 
            // colMedicineName
            // 
            this.colMedicineName.DataPropertyName = "MedicineName";
            this.colMedicineName.HeaderText = "Medicine Name";
            this.colMedicineName.Name = "colMedicineName";
            // 
            // colDosage
            // 
            this.colDosage.DataPropertyName = "Dosage";
            this.colDosage.HeaderText = "Dosage";
            this.colDosage.Name = "colDosage";
            // 
            // colRemarks
            // 
            this.colRemarks.DataPropertyName = "Remarks";
            this.colRemarks.HeaderText = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // colAdvisedByDateTime
            // 
            this.colAdvisedByDateTime.DataPropertyName = "CreatedDateTime";
            this.colAdvisedByDateTime.HeaderText = "Date Time";
            this.colAdvisedByDateTime.Name = "colAdvisedByDateTime";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(163, 28);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(588, 23);
            this.txtMedicineName.TabIndex = 10;
            this.txtMedicineName.Tag = "0";
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.ForeColor = System.Drawing.Color.White;
            this.lblMedicineName.Location = new System.Drawing.Point(62, 33);
            this.lblMedicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(91, 15);
            this.lblMedicineName.TabIndex = 9;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // tpgLabTest
            // 
            this.tpgLabTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpgLabTest.Controls.Add(this.gdvLabTest);
            this.tpgLabTest.Controls.Add(this.btnNewLabTest);
            this.tpgLabTest.Controls.Add(this.btnPatientLabTestSave);
            this.tpgLabTest.Controls.Add(this.txtLabTestRemarks);
            this.tpgLabTest.Controls.Add(this.lblTestRemarks);
            this.tpgLabTest.Controls.Add(this.lblValue);
            this.tpgLabTest.Controls.Add(this.txtValue);
            this.tpgLabTest.Controls.Add(this.dgvLabTestHistory);
            this.tpgLabTest.Controls.Add(this.txtTestName);
            this.tpgLabTest.Controls.Add(this.lblLabTestName);
            this.tpgLabTest.Location = new System.Drawing.Point(4, 24);
            this.tpgLabTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgLabTest.Name = "tpgLabTest";
            this.tpgLabTest.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpgLabTest.Size = new System.Drawing.Size(1392, 722);
            this.tpgLabTest.TabIndex = 2;
            this.tpgLabTest.Text = "LabTest";
            // 
            // gdvLabTest
            // 
            this.gdvLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvLabTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabTestID,
            this.LabTestName});
            this.gdvLabTest.Location = new System.Drawing.Point(822, 81);
            this.gdvLabTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gdvLabTest.Name = "gdvLabTest";
            this.gdvLabTest.RowHeadersVisible = false;
            this.gdvLabTest.Size = new System.Drawing.Size(86, 24);
            this.gdvLabTest.TabIndex = 19;
            this.gdvLabTest.Visible = false;
            this.gdvLabTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvLabTest_CellContentClick);
            // 
            // LabTestID
            // 
            this.LabTestID.DataPropertyName = "LabTestID";
            this.LabTestID.HeaderText = "LabTestID";
            this.LabTestID.Name = "LabTestID";
            // 
            // LabTestName
            // 
            this.LabTestName.DataPropertyName = "LabTestName";
            this.LabTestName.HeaderText = "LabTestName";
            this.LabTestName.Name = "LabTestName";
            // 
            // btnNewLabTest
            // 
            this.btnNewLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLabTest.ForeColor = System.Drawing.Color.White;
            this.btnNewLabTest.Location = new System.Drawing.Point(749, 47);
            this.btnNewLabTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewLabTest.Name = "btnNewLabTest";
            this.btnNewLabTest.Size = new System.Drawing.Size(66, 27);
            this.btnNewLabTest.TabIndex = 8;
            this.btnNewLabTest.Text = "New";
            this.btnNewLabTest.UseVisualStyleBackColor = true;
            this.btnNewLabTest.Click += new System.EventHandler(this.btnNewLabTest_Click);
            // 
            // btnPatientLabTestSave
            // 
            this.btnPatientLabTestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientLabTestSave.ForeColor = System.Drawing.Color.White;
            this.btnPatientLabTestSave.Location = new System.Drawing.Point(728, 217);
            this.btnPatientLabTestSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPatientLabTestSave.Name = "btnPatientLabTestSave";
            this.btnPatientLabTestSave.Size = new System.Drawing.Size(88, 27);
            this.btnPatientLabTestSave.TabIndex = 7;
            this.btnPatientLabTestSave.Text = "Save";
            this.btnPatientLabTestSave.UseVisualStyleBackColor = true;
            this.btnPatientLabTestSave.Click += new System.EventHandler(this.btnPatientLabTestSave_Click);
            // 
            // txtLabTestRemarks
            // 
            this.txtLabTestRemarks.Location = new System.Drawing.Point(153, 107);
            this.txtLabTestRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLabTestRemarks.Multiline = true;
            this.txtLabTestRemarks.Name = "txtLabTestRemarks";
            this.txtLabTestRemarks.Size = new System.Drawing.Size(662, 102);
            this.txtLabTestRemarks.TabIndex = 6;
            // 
            // lblTestRemarks
            // 
            this.lblTestRemarks.AutoSize = true;
            this.lblTestRemarks.ForeColor = System.Drawing.Color.White;
            this.lblTestRemarks.Location = new System.Drawing.Point(89, 111);
            this.lblTestRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRemarks.Name = "lblTestRemarks";
            this.lblTestRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblTestRemarks.TabIndex = 5;
            this.lblTestRemarks.Text = "Remarks";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(106, 81);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(35, 15);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(153, 77);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(662, 23);
            this.txtValue.TabIndex = 3;
            // 
            // dgvLabTestHistory
            // 
            this.dgvLabTestHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabTestHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLabTestName,
            this.colNormalValue,
            this.colPatientValue,
            this.colDateTime,
            this.colAdvisedByID});
            this.dgvLabTestHistory.Location = new System.Drawing.Point(153, 250);
            this.dgvLabTestHistory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLabTestHistory.Name = "dgvLabTestHistory";
            this.dgvLabTestHistory.Size = new System.Drawing.Size(663, 310);
            this.dgvLabTestHistory.TabIndex = 2;
            // 
            // colLabTestName
            // 
            this.colLabTestName.HeaderText = "Test Name";
            this.colLabTestName.Name = "colLabTestName";
            // 
            // colNormalValue
            // 
            this.colNormalValue.HeaderText = "Normal Value";
            this.colNormalValue.Name = "colNormalValue";
            // 
            // colPatientValue
            // 
            this.colPatientValue.HeaderText = "Patient Value";
            this.colPatientValue.Name = "colPatientValue";
            // 
            // colDateTime
            // 
            this.colDateTime.HeaderText = "Date Time";
            this.colDateTime.Name = "colDateTime";
            // 
            // colAdvisedByID
            // 
            this.colAdvisedByID.HeaderText = "Advised By";
            this.colAdvisedByID.Name = "colAdvisedByID";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(153, 47);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(588, 23);
            this.txtTestName.TabIndex = 1;
            this.txtTestName.TextChanged += new System.EventHandler(this.txtTestName_TextChanged);
            // 
            // lblLabTestName
            // 
            this.lblLabTestName.AutoSize = true;
            this.lblLabTestName.ForeColor = System.Drawing.Color.White;
            this.lblLabTestName.Location = new System.Drawing.Point(77, 53);
            this.lblLabTestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabTestName.Name = "lblLabTestName";
            this.lblLabTestName.Size = new System.Drawing.Size(62, 15);
            this.lblLabTestName.TabIndex = 0;
            this.lblLabTestName.Text = "Test Name";
            // 
            // tpgStaffObservations
            // 
            this.tpgStaffObservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpgStaffObservations.Controls.Add(this.lblPatientObservationHistory);
            this.tpgStaffObservations.Controls.Add(this.dgvPatientObservationHistory);
            this.tpgStaffObservations.Controls.Add(this.txtObservationPatientName);
            this.tpgStaffObservations.Controls.Add(this.lblObservationPatientName);
            this.tpgStaffObservations.Controls.Add(this.btnSaveStaffObservation);
            this.tpgStaffObservations.Controls.Add(this.lblRemarks);
            this.tpgStaffObservations.Controls.Add(this.txtObservationRemarks);
            this.tpgStaffObservations.Controls.Add(this.txtObservation);
            this.tpgStaffObservations.Controls.Add(this.lblObservation);
            this.tpgStaffObservations.Controls.Add(this.lblDoctor);
            this.tpgStaffObservations.Controls.Add(this.cmbDoctor);
            this.tpgStaffObservations.Location = new System.Drawing.Point(4, 24);
            this.tpgStaffObservations.Name = "tpgStaffObservations";
            this.tpgStaffObservations.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStaffObservations.Size = new System.Drawing.Size(1392, 722);
            this.tpgStaffObservations.TabIndex = 5;
            this.tpgStaffObservations.Text = "Staff Observation";
            // 
            // lblPatientObservationHistory
            // 
            this.lblPatientObservationHistory.AutoSize = true;
            this.lblPatientObservationHistory.ForeColor = System.Drawing.Color.White;
            this.lblPatientObservationHistory.Location = new System.Drawing.Point(488, 24);
            this.lblPatientObservationHistory.Name = "lblPatientObservationHistory";
            this.lblPatientObservationHistory.Size = new System.Drawing.Size(112, 15);
            this.lblPatientObservationHistory.TabIndex = 10;
            this.lblPatientObservationHistory.Text = "Observation History";
            // 
            // dgvPatientObservationHistory
            // 
            this.dgvPatientObservationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientObservationHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffObservationID,
            this.colObservationDetail,
            this.colDoctor,
            this.dataGridViewTextBoxColumn1});
            this.dgvPatientObservationHistory.Location = new System.Drawing.Point(488, 49);
            this.dgvPatientObservationHistory.Name = "dgvPatientObservationHistory";
            this.dgvPatientObservationHistory.RowHeadersVisible = false;
            this.dgvPatientObservationHistory.RowTemplate.Height = 25;
            this.dgvPatientObservationHistory.Size = new System.Drawing.Size(454, 428);
            this.dgvPatientObservationHistory.TabIndex = 9;
            // 
            // colStaffObservationID
            // 
            this.colStaffObservationID.HeaderText = "Staff Observation";
            this.colStaffObservationID.Name = "colStaffObservationID";
            this.colStaffObservationID.Visible = false;
            // 
            // colObservationDetail
            // 
            this.colObservationDetail.HeaderText = "Observation Details";
            this.colObservationDetail.Name = "colObservationDetail";
            this.colObservationDetail.Width = 250;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "Doctor";
            this.colDoctor.Name = "colDoctor";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // txtObservationPatientName
            // 
            this.txtObservationPatientName.Location = new System.Drawing.Point(103, 16);
            this.txtObservationPatientName.Name = "txtObservationPatientName";
            this.txtObservationPatientName.ReadOnly = true;
            this.txtObservationPatientName.Size = new System.Drawing.Size(369, 23);
            this.txtObservationPatientName.TabIndex = 8;
            // 
            // lblObservationPatientName
            // 
            this.lblObservationPatientName.AutoSize = true;
            this.lblObservationPatientName.ForeColor = System.Drawing.Color.White;
            this.lblObservationPatientName.Location = new System.Drawing.Point(8, 19);
            this.lblObservationPatientName.Name = "lblObservationPatientName";
            this.lblObservationPatientName.Size = new System.Drawing.Size(79, 15);
            this.lblObservationPatientName.TabIndex = 7;
            this.lblObservationPatientName.Text = "Patient Name";
            // 
            // btnSaveStaffObservation
            // 
            this.btnSaveStaffObservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStaffObservation.ForeColor = System.Drawing.Color.White;
            this.btnSaveStaffObservation.Location = new System.Drawing.Point(332, 483);
            this.btnSaveStaffObservation.Name = "btnSaveStaffObservation";
            this.btnSaveStaffObservation.Size = new System.Drawing.Size(140, 23);
            this.btnSaveStaffObservation.TabIndex = 6;
            this.btnSaveStaffObservation.Text = "Save Observation";
            this.btnSaveStaffObservation.UseVisualStyleBackColor = true;
            this.btnSaveStaffObservation.Click += new System.EventHandler(this.btnSaveStaffObservation_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.ForeColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(35, 302);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtObservationRemarks
            // 
            this.txtObservationRemarks.Location = new System.Drawing.Point(103, 299);
            this.txtObservationRemarks.Multiline = true;
            this.txtObservationRemarks.Name = "txtObservationRemarks";
            this.txtObservationRemarks.Size = new System.Drawing.Size(369, 178);
            this.txtObservationRemarks.TabIndex = 4;
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(103, 90);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(369, 203);
            this.txtObservation.TabIndex = 3;
            // 
            // lblObservation
            // 
            this.lblObservation.AutoSize = true;
            this.lblObservation.ForeColor = System.Drawing.Color.White;
            this.lblObservation.Location = new System.Drawing.Point(16, 93);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(71, 15);
            this.lblObservation.TabIndex = 2;
            this.lblObservation.Text = "Observation";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.ForeColor = System.Drawing.Color.White;
            this.lblDoctor.Location = new System.Drawing.Point(44, 52);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 1;
            this.lblDoctor.Text = "Doctor";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(103, 49);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(369, 23);
            this.cmbDoctor.TabIndex = 0;
            // 
            // PatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.tabPatient);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PatientControl";
            this.Size = new System.Drawing.Size(1400, 750);
            this.Load += new System.EventHandler(this.PatientControl_Load);
            this.tabPatient.ResumeLayout(false);
            this.tpgPatientPersonalData.ResumeLayout(false);
            this.gbPatientList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.gbMedicalInfo.ResumeLayout(false);
            this.gbMedicalInfo.PerformLayout();
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.tpgVisitHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientVisitVitals)).EndInit();
            this.tpgSymptoms.ResumeLayout(false);
            this.pnlNewSymptoms.ResumeLayout(false);
            this.gbNewSymptom.ResumeLayout(false);
            this.gbNewSymptom.PerformLayout();
            this.gbCategoryAndValues.ResumeLayout(false);
            this.gbCategoryAndValues.PerformLayout();
            this.pnlPatientSymptoms.ResumeLayout(false);
            this.scSymptoms.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSymptoms)).EndInit();
            this.scSymptoms.ResumeLayout(false);
            this.tpgMedicine.ResumeLayout(false);
            this.tpgMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineHistory)).EndInit();
            this.tpgLabTest.ResumeLayout(false);
            this.tpgLabTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLabTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabTestHistory)).EndInit();
            this.tpgStaffObservations.ResumeLayout(false);
            this.tpgStaffObservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientObservationHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPatient;
        private System.Windows.Forms.TabPage tpgPatientPersonalData;
        private System.Windows.Forms.GroupBox gbMedicalInfo;
        private System.Windows.Forms.TextBox txtMedicalInfoRemarks;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblMedicalInfoRemarks;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAttendentName;
        private System.Windows.Forms.TextBox txtAttendentName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TabPage tpgSymptoms;
        private System.Windows.Forms.GroupBox gbPatientList;
        private System.Windows.Forms.Button btnSavePatientInfo;
        private System.Windows.Forms.Panel pnlNewSymptoms;
        private System.Windows.Forms.Panel pnlPatientSymptoms;
        private System.Windows.Forms.SplitContainer scSymptoms;
        private System.Windows.Forms.CheckedListBox lstSymptoms;
        private System.Windows.Forms.Button btnSavePatientSymptom;
        private System.Windows.Forms.TabPage tpgLabTest;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Label lblLabTestName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DataGridView dgvLabTestHistory;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtLabTestRemarks;
        private System.Windows.Forms.Label lblTestRemarks;
        private System.Windows.Forms.Button btnPatientLabTestSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLabTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNormalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdvisedByID;
        private System.Windows.Forms.Button btnNewLabTest;
        private System.Windows.Forms.TabPage tpgMedicine;
        private System.Windows.Forms.Button btnNewMedicine;
        private System.Windows.Forms.Button btnMedicineSave;
        private System.Windows.Forms.TextBox txtMedicineRemarks;
        private System.Windows.Forms.Label lblPatientMedicineRemarks;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.DataGridView dgvMedicineHistory;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.DataGridView gdvMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridView gdvLabTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestName;
        private System.Windows.Forms.Label lblPatientCNIC;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Button btnLoadPatientDataByCNIC;
        private System.Windows.Forms.Button btnLoadPatientDataByPhone;
        private System.Windows.Forms.TextBox txtPatientPersonalInfoRemarks;
        private System.Windows.Forms.Label lblPatientPersonaleInfoRemarks;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.MaskedTextBox txtBloodPressure;
        private System.Windows.Forms.TabPage tpgVisitHistory;
        private System.Windows.Forms.Button btnVisitHistory;
        private System.Windows.Forms.DataGridView dgvPatientVisitVitals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVitalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVitalValue;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.GroupBox gbNewSymptom;
        private System.Windows.Forms.Button bntNewTitle;
        private System.Windows.Forms.ComboBox cmbSymptom;
        private System.Windows.Forms.TextBox txtCategoryAndValues;
        private System.Windows.Forms.GroupBox gbCategoryAndValues;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnAddCategoryAndValue;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddNewSymptom;
        private System.Windows.Forms.Label lblSymptomTitle;
        private System.Windows.Forms.TabPage tpgStaffObservations;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtObservationRemarks;
        private System.Windows.Forms.Button btnSaveStaffObservation;
        private System.Windows.Forms.TextBox txtObservationPatientName;
        private System.Windows.Forms.Label lblObservationPatientName;
        private System.Windows.Forms.DataGridView dgvPatientObservationHistory;
        private System.Windows.Forms.Label lblPatientObservationHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffObservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservationDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdvisedByDateTime;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmittedPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreated;
        private System.Windows.Forms.Button btnSaveVitals;
    }
}
