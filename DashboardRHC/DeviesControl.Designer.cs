
namespace DashboardRHC
{
    partial class DeviesControl
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
            this.tabDevices = new System.Windows.Forms.TabControl();
            this.tpDeviceList = new System.Windows.Forms.TabPage();
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            this.colDeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDeviceMAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSensors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDeviceManagement = new System.Windows.Forms.TabPage();
            this.gbAttachment = new System.Windows.Forms.GroupBox();
            this.btnDetach = new System.Windows.Forms.Button();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.btnAttachDevice = new System.Windows.Forms.Button();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDeviceProperties = new System.Windows.Forms.Label();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.gbDevice = new System.Windows.Forms.GroupBox();
            this.txtDeviceIP = new System.Windows.Forms.MaskedTextBox();
            this.lblDeviceIP = new System.Windows.Forms.Label();
            this.txtMACAddress = new System.Windows.Forms.TextBox();
            this.lblDeviceMAC = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtSensors = new System.Windows.Forms.TextBox();
            this.lblSensors = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.tabDevices.SuspendLayout();
            this.tpDeviceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            this.tpDeviceManagement.SuspendLayout();
            this.gbAttachment.SuspendLayout();
            this.gbDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDevices
            // 
            this.tabDevices.Controls.Add(this.tpDeviceList);
            this.tabDevices.Controls.Add(this.tpDeviceManagement);
            this.tabDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDevices.ItemSize = new System.Drawing.Size(100, 30);
            this.tabDevices.Location = new System.Drawing.Point(0, 0);
            this.tabDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.SelectedIndex = 0;
            this.tabDevices.Size = new System.Drawing.Size(933, 600);
            this.tabDevices.TabIndex = 0;
            this.tabDevices.SelectedIndexChanged += new System.EventHandler(this.tabDevices_SelectedIndexChanged);
            // 
            // tpDeviceList
            // 
            this.tpDeviceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpDeviceList.Controls.Add(this.dgvDeviceList);
            this.tpDeviceList.Location = new System.Drawing.Point(4, 34);
            this.tpDeviceList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDeviceList.Name = "tpDeviceList";
            this.tpDeviceList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDeviceList.Size = new System.Drawing.Size(925, 562);
            this.tpDeviceList.TabIndex = 0;
            this.tpDeviceList.Text = "Device List";
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeviceID,
            this.colDeviceName,
            this.colDeviceMAC,
            this.colDeviceIP,
            this.colSensors});
            this.dgvDeviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceList.Location = new System.Drawing.Point(4, 3);
            this.dgvDeviceList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDeviceList.Name = "dgvDeviceList";
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.Size = new System.Drawing.Size(917, 556);
            this.dgvDeviceList.TabIndex = 0;
            this.dgvDeviceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeviceList_CellContentClick);
            // 
            // colDeviceID
            // 
            this.colDeviceID.DataPropertyName = "DeviceID";
            this.colDeviceID.HeaderText = "DeviceID";
            this.colDeviceID.Name = "colDeviceID";
            this.colDeviceID.Visible = false;
            // 
            // colDeviceName
            // 
            this.colDeviceName.DataPropertyName = "DeviceName";
            this.colDeviceName.HeaderText = "Name";
            this.colDeviceName.Name = "colDeviceName";
            this.colDeviceName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDeviceMAC
            // 
            this.colDeviceMAC.DataPropertyName = "DeviceMAC";
            this.colDeviceMAC.HeaderText = "MAC Address";
            this.colDeviceMAC.Name = "colDeviceMAC";
            this.colDeviceMAC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeviceMAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDeviceIP
            // 
            this.colDeviceIP.DataPropertyName = "DeviceIP";
            this.colDeviceIP.HeaderText = "DeviceIP";
            this.colDeviceIP.Name = "colDeviceIP";
            this.colDeviceIP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeviceIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSensors
            // 
            this.colSensors.DataPropertyName = "Sensors";
            this.colSensors.HeaderText = "Sensors";
            this.colSensors.Name = "colSensors";
            this.colSensors.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSensors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tpDeviceManagement
            // 
            this.tpDeviceManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpDeviceManagement.Controls.Add(this.gbAttachment);
            this.tpDeviceManagement.Controls.Add(this.gbDevice);
            this.tpDeviceManagement.Location = new System.Drawing.Point(4, 34);
            this.tpDeviceManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDeviceManagement.Name = "tpDeviceManagement";
            this.tpDeviceManagement.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpDeviceManagement.Size = new System.Drawing.Size(925, 562);
            this.tpDeviceManagement.TabIndex = 1;
            this.tpDeviceManagement.Text = "Device Management";
            // 
            // gbAttachment
            // 
            this.gbAttachment.Controls.Add(this.btnDetach);
            this.gbAttachment.Controls.Add(this.cmbPatient);
            this.gbAttachment.Controls.Add(this.btnAttachDevice);
            this.gbAttachment.Controls.Add(this.lblPatient);
            this.gbAttachment.Controls.Add(this.lblDeviceProperties);
            this.gbAttachment.Controls.Add(this.cmbDevice);
            this.gbAttachment.Controls.Add(this.lblDevice);
            this.gbAttachment.ForeColor = System.Drawing.Color.White;
            this.gbAttachment.Location = new System.Drawing.Point(524, 25);
            this.gbAttachment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAttachment.Name = "gbAttachment";
            this.gbAttachment.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbAttachment.Size = new System.Drawing.Size(378, 202);
            this.gbAttachment.TabIndex = 1;
            this.gbAttachment.TabStop = false;
            this.gbAttachment.Text = "Device Attachment";
            // 
            // btnDetach
            // 
            this.btnDetach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetach.Location = new System.Drawing.Point(265, 158);
            this.btnDetach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(88, 27);
            this.btnDetach.TabIndex = 11;
            this.btnDetach.Text = "Detach";
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // cmbPatient
            // 
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(77, 120);
            this.cmbPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(275, 23);
            this.cmbPatient.TabIndex = 9;
            // 
            // btnAttachDevice
            // 
            this.btnAttachDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachDevice.Location = new System.Drawing.Point(170, 158);
            this.btnAttachDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAttachDevice.Name = "btnAttachDevice";
            this.btnAttachDevice.Size = new System.Drawing.Size(88, 27);
            this.btnAttachDevice.TabIndex = 10;
            this.btnAttachDevice.Text = "Attach";
            this.btnAttachDevice.UseVisualStyleBackColor = true;
            this.btnAttachDevice.Click += new System.EventHandler(this.btnAttachDevice_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(22, 123);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(44, 15);
            this.lblPatient.TabIndex = 3;
            this.lblPatient.Text = "Patient";
            // 
            // lblDeviceProperties
            // 
            this.lblDeviceProperties.Location = new System.Drawing.Point(74, 62);
            this.lblDeviceProperties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceProperties.Name = "lblDeviceProperties";
            this.lblDeviceProperties.Size = new System.Drawing.Size(279, 54);
            this.lblDeviceProperties.TabIndex = 2;
            this.lblDeviceProperties.Text = "Device Info";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(77, 33);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(275, 23);
            this.cmbDevice.TabIndex = 8;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(22, 37);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(42, 15);
            this.lblDevice.TabIndex = 0;
            this.lblDevice.Text = "Device";
            // 
            // gbDevice
            // 
            this.gbDevice.Controls.Add(this.txtDeviceIP);
            this.gbDevice.Controls.Add(this.lblDeviceIP);
            this.gbDevice.Controls.Add(this.txtMACAddress);
            this.gbDevice.Controls.Add(this.lblDeviceMAC);
            this.gbDevice.Controls.Add(this.btnSave);
            this.gbDevice.Controls.Add(this.btnCancel);
            this.gbDevice.Controls.Add(this.chkIsEnabled);
            this.gbDevice.Controls.Add(this.txtRemarks);
            this.gbDevice.Controls.Add(this.lblRemarks);
            this.gbDevice.Controls.Add(this.txtSensors);
            this.gbDevice.Controls.Add(this.lblSensors);
            this.gbDevice.Controls.Add(this.txtDeviceName);
            this.gbDevice.Controls.Add(this.lblDeviceName);
            this.gbDevice.ForeColor = System.Drawing.Color.White;
            this.gbDevice.Location = new System.Drawing.Point(21, 25);
            this.gbDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDevice.Size = new System.Drawing.Size(496, 360);
            this.gbDevice.TabIndex = 0;
            this.gbDevice.TabStop = false;
            this.gbDevice.Text = "Device Info";
            // 
            // txtDeviceIP
            // 
            this.txtDeviceIP.Location = new System.Drawing.Point(113, 98);
            this.txtDeviceIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeviceIP.Mask = "000.000.000.000";
            this.txtDeviceIP.Name = "txtDeviceIP";
            this.txtDeviceIP.Size = new System.Drawing.Size(354, 23);
            this.txtDeviceIP.TabIndex = 2;
            // 
            // lblDeviceIP
            // 
            this.lblDeviceIP.AutoSize = true;
            this.lblDeviceIP.Location = new System.Drawing.Point(18, 102);
            this.lblDeviceIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceIP.Name = "lblDeviceIP";
            this.lblDeviceIP.Size = new System.Drawing.Size(55, 15);
            this.lblDeviceIP.TabIndex = 11;
            this.lblDeviceIP.Text = "Device IP";
            // 
            // txtMACAddress
            // 
            this.txtMACAddress.Location = new System.Drawing.Point(113, 60);
            this.txtMACAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMACAddress.Name = "txtMACAddress";
            this.txtMACAddress.Size = new System.Drawing.Size(354, 23);
            this.txtMACAddress.TabIndex = 1;
            // 
            // lblDeviceMAC
            // 
            this.lblDeviceMAC.AutoSize = true;
            this.lblDeviceMAC.Location = new System.Drawing.Point(18, 63);
            this.lblDeviceMAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceMAC.Name = "lblDeviceMAC";
            this.lblDeviceMAC.Size = new System.Drawing.Size(79, 15);
            this.lblDeviceMAC.TabIndex = 9;
            this.lblDeviceMAC.Text = "MAC Address";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(286, 303);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(380, 303);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(113, 280);
            this.chkIsEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(61, 19);
            this.chkIsEnabled.TabIndex = 5;
            this.chkIsEnabled.Text = "Enable";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(113, 178);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(354, 94);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(18, 181);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtSensors
            // 
            this.txtSensors.Location = new System.Drawing.Point(113, 136);
            this.txtSensors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSensors.Name = "txtSensors";
            this.txtSensors.Size = new System.Drawing.Size(354, 23);
            this.txtSensors.TabIndex = 3;
            // 
            // lblSensors
            // 
            this.lblSensors.AutoSize = true;
            this.lblSensors.Location = new System.Drawing.Point(18, 140);
            this.lblSensors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensors.Name = "lblSensors";
            this.lblSensors.Size = new System.Drawing.Size(47, 15);
            this.lblSensors.TabIndex = 2;
            this.lblSensors.Text = "Sensors";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(113, 22);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(354, 23);
            this.txtDeviceName.TabIndex = 0;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(18, 25);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(77, 15);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device Name";
            // 
            // DeviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.tabDevices);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeviesControl";
            this.Size = new System.Drawing.Size(933, 600);
            this.Load += new System.EventHandler(this.DeviesControl_Load);
            this.tabDevices.ResumeLayout(false);
            this.tpDeviceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            this.tpDeviceManagement.ResumeLayout(false);
            this.gbAttachment.ResumeLayout(false);
            this.gbAttachment.PerformLayout();
            this.gbDevice.ResumeLayout(false);
            this.gbDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDevices;
        private System.Windows.Forms.TabPage tpDeviceList;
        private System.Windows.Forms.TabPage tpDeviceManagement;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.GroupBox gbDevice;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtSensors;
        private System.Windows.Forms.Label lblSensors;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDeviceIP;
        private System.Windows.Forms.TextBox txtMACAddress;
        private System.Windows.Forms.Label lblDeviceMAC;
        private System.Windows.Forms.MaskedTextBox txtDeviceIP;
        private System.Windows.Forms.GroupBox gbAttachment;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblDeviceProperties;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Button btnAttachDevice;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceID;
        private System.Windows.Forms.DataGridViewLinkColumn colDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceMAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSensors;
        private System.Windows.Forms.Button btnDetach;
    }
}
