
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
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.SelectedIndex = 0;
            this.tabStaff.Size = new System.Drawing.Size(800, 520);
            this.tabStaff.TabIndex = 0;
            this.tabStaff.SelectedIndexChanged += new System.EventHandler(this.tabStaff_SelectedIndexChanged);
            // 
            // tpStaffList
            // 
            this.tpStaffList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpStaffList.Controls.Add(this.dgvStaff);
            this.tpStaffList.Location = new System.Drawing.Point(4, 34);
            this.tpStaffList.Name = "tpStaffList";
            this.tpStaffList.Padding = new System.Windows.Forms.Padding(3);
            this.tpStaffList.Size = new System.Drawing.Size(792, 482);
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
            this.dgvStaff.Location = new System.Drawing.Point(3, 3);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(786, 476);
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
            this.tpManageStaff.Name = "tpManageStaff";
            this.tpManageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageStaff.Size = new System.Drawing.Size(792, 482);
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
            this.gbStaff.Location = new System.Drawing.Point(149, 22);
            this.gbStaff.Name = "gbStaff";
            this.gbStaff.Size = new System.Drawing.Size(500, 430);
            this.gbStaff.TabIndex = 0;
            this.gbStaff.TabStop = false;
            this.gbStaff.Text = "Staff Info";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(31, 294);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 14;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(106, 291);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(356, 79);
            this.txtRemarks.TabIndex = 7;
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(106, 268);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(76, 17);
            this.chkIsEnabled.TabIndex = 6;
            this.chkIsEnabled.Text = "Is Enabled";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 181);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(356, 79);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(356, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(31, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(306, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCancel
            // 
            this.txtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCancel.Location = new System.Drawing.Point(387, 389);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 9;
            this.txtCancel.Text = "Cancel";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(106, 109);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(356, 20);
            this.txtQualification.TabIndex = 3;
            // 
            // lblQaualification
            // 
            this.lblQaualification.AutoSize = true;
            this.lblQaualification.Location = new System.Drawing.Point(31, 112);
            this.lblQaualification.Name = "lblQaualification";
            this.lblQaualification.Size = new System.Drawing.Size(65, 13);
            this.lblQaualification.TabIndex = 4;
            this.lblQaualification.Text = "Qualification";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(106, 73);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(356, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(31, 76);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 2;
            this.lblDesignation.Text = "Designation";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(106, 37);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(356, 20);
            this.txtStaffName.TabIndex = 0;
            this.txtStaffName.Tag = "0";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(31, 40);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name";
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.tabStaff);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(800, 520);
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
