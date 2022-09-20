
namespace DashboardRHC
{
    partial class StaffControl
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
            this.tabStaff = new System.Windows.Forms.TabControl();
            this.tpStaffList = new System.Windows.Forms.TabPage();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colStaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpManageStaff = new System.Windows.Forms.TabPage();
            this.gbStaff = new System.Windows.Forms.GroupBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.lblQaualification = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.tabStaff.SuspendLayout();
            this.tpStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tpManageStaff.SuspendLayout();
            this.gbStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.tpStaffList);
            this.tabStaff.Controls.Add(this.tpManageStaff);
            this.tabStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStaff.ItemSize = new System.Drawing.Size(100, 30);
            this.tabStaff.Location = new System.Drawing.Point(0, 0);
            this.tabStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.SelectedIndex = 0;
            this.tabStaff.Size = new System.Drawing.Size(933, 600);
            this.tabStaff.TabIndex = 0;
            this.tabStaff.SelectedIndexChanged += new System.EventHandler(this.tabStaff_SelectedIndexChanged);
            // 
            // tpStaffList
            // 
            this.tpStaffList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpStaffList.Controls.Add(this.dgvStaff);
            this.tpStaffList.Location = new System.Drawing.Point(4, 34);
            this.tpStaffList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpStaffList.Name = "tpStaffList";
            this.tpStaffList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpStaffList.Size = new System.Drawing.Size(925, 562);
            this.tpStaffList.TabIndex = 0;
            this.tpStaffList.Text = "Staff List";
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffID,
            this.colStaffName,
            this.colStaffPhone,
            this.colDesignation});
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(4, 3);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(917, 556);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // colStaffID
            // 
            this.colStaffID.DataPropertyName = "StaffID";
            this.colStaffID.HeaderText = "StaffID";
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.Visible = false;
            // 
            // colStaffName
            // 
            this.colStaffName.DataPropertyName = "StaffName";
            this.colStaffName.HeaderText = "Staff Name";
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            // 
            // colStaffPhone
            // 
            this.colStaffPhone.DataPropertyName = "StaffPhone";
            this.colStaffPhone.HeaderText = "Phone";
            this.colStaffPhone.Name = "colStaffPhone";
            this.colStaffPhone.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.DataPropertyName = "Designation";
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // tpManageStaff
            // 
            this.tpManageStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpManageStaff.Controls.Add(this.gbStaff);
            this.tpManageStaff.Location = new System.Drawing.Point(4, 34);
            this.tpManageStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpManageStaff.Name = "tpManageStaff";
            this.tpManageStaff.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tpManageStaff.Size = new System.Drawing.Size(925, 562);
            this.tpManageStaff.TabIndex = 1;
            this.tpManageStaff.Text = "Staff Management";
            // 
            // gbStaff
            // 
            this.gbStaff.Controls.Add(this.lblRemarks);
            this.gbStaff.Controls.Add(this.txtRemarks);
            this.gbStaff.Controls.Add(this.chkIsEnabled);
            this.gbStaff.Controls.Add(this.txtAddress);
            this.gbStaff.Controls.Add(this.lblAddress);
            this.gbStaff.Controls.Add(this.txtPhone);
            this.gbStaff.Controls.Add(this.lblPhone);
            this.gbStaff.Controls.Add(this.btnSave);
            this.gbStaff.Controls.Add(this.txtCancel);
            this.gbStaff.Controls.Add(this.txtQualification);
            this.gbStaff.Controls.Add(this.lblQaualification);
            this.gbStaff.Controls.Add(this.txtDesignation);
            this.gbStaff.Controls.Add(this.lblDesignation);
            this.gbStaff.Controls.Add(this.txtStaffName);
            this.gbStaff.Controls.Add(this.lblStaffName);
            this.gbStaff.ForeColor = System.Drawing.Color.White;
            this.gbStaff.Location = new System.Drawing.Point(174, 25);
            this.gbStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStaff.Name = "gbStaff";
            this.gbStaff.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbStaff.Size = new System.Drawing.Size(583, 496);
            this.gbStaff.TabIndex = 0;
            this.gbStaff.TabStop = false;
            this.gbStaff.Text = "Staff Info";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(36, 339);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblRemarks.TabIndex = 14;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(124, 336);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(415, 91);
            this.txtRemarks.TabIndex = 7;
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(124, 309);
            this.chkIsEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(79, 19);
            this.chkIsEnabled.TabIndex = 6;
            this.chkIsEnabled.Text = "Is Enabled";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(124, 209);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(415, 91);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(36, 212);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(124, 167);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(415, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 171);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(357, 449);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCancel
            // 
            this.txtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCancel.Location = new System.Drawing.Point(451, 449);
            this.txtCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(88, 27);
            this.txtCancel.TabIndex = 9;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(124, 126);
            this.txtQualification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(415, 23);
            this.txtQualification.TabIndex = 3;
            // 
            // lblQaualification
            // 
            this.lblQaualification.AutoSize = true;
            this.lblQaualification.Location = new System.Drawing.Point(36, 129);
            this.lblQaualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQaualification.Name = "lblQaualification";
            this.lblQaualification.Size = new System.Drawing.Size(75, 15);
            this.lblQaualification.TabIndex = 4;
            this.lblQaualification.Text = "Qualification";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(124, 84);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(415, 23);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(36, 88);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(70, 15);
            this.lblDesignation.TabIndex = 2;
            this.lblDesignation.Text = "Designation";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(124, 43);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(415, 23);
            this.txtStaffName.TabIndex = 0;
            this.txtStaffName.Tag = "0";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(36, 46);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(66, 15);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name";
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.tabStaff);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(933, 600);
            this.Tag = "0";
            this.Load += new System.EventHandler(this.StaffControl_Load);
            this.tabStaff.ResumeLayout(false);
            this.tpStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tpManageStaff.ResumeLayout(false);
            this.gbStaff.ResumeLayout(false);
            this.gbStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStaff;
        private System.Windows.Forms.TabPage tpStaffList;
        private System.Windows.Forms.TabPage tpManageStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox gbStaff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblQaualification;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private System.Windows.Forms.DataGridViewLinkColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
    }
}
