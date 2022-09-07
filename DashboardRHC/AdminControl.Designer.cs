namespace DashboardRHC
{
    partial class AdminControl
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
            this.tabManageAdmins = new System.Windows.Forms.TabControl();
            this.tpAdminList = new System.Windows.Forms.TabPage();
            this.dgvAdminList = new System.Windows.Forms.DataGridView();
            this.tpAdminLogs = new System.Windows.Forms.TabPage();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvAdminLog = new System.Windows.Forms.DataGridView();
            this.pnlAdminLogHeader = new System.Windows.Forms.Panel();
            this.bntLoadAdminLog = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.cmbAdminNames = new System.Windows.Forms.ComboBox();
            this.tpAddAdmin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.tabManageAdmins.SuspendLayout();
            this.tpAdminList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            this.tpAdminLogs.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminLog)).BeginInit();
            this.pnlAdminLogHeader.SuspendLayout();
            this.tpAddAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageAdmins
            // 
            this.tabManageAdmins.Controls.Add(this.tpAdminList);
            this.tabManageAdmins.Controls.Add(this.tpAdminLogs);
            this.tabManageAdmins.Controls.Add(this.tpAddAdmin);
            this.tabManageAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageAdmins.Location = new System.Drawing.Point(0, 0);
            this.tabManageAdmins.Name = "tabManageAdmins";
            this.tabManageAdmins.SelectedIndex = 0;
            this.tabManageAdmins.Size = new System.Drawing.Size(851, 621);
            this.tabManageAdmins.TabIndex = 0;
            this.tabManageAdmins.SelectedIndexChanged += new System.EventHandler(this.tabManageAdmins_SelectedIndexChanged);
            // 
            // tpAdminList
            // 
            this.tpAdminList.Controls.Add(this.dgvAdminList);
            this.tpAdminList.Location = new System.Drawing.Point(4, 22);
            this.tpAdminList.Name = "tpAdminList";
            this.tpAdminList.Size = new System.Drawing.Size(843, 595);
            this.tpAdminList.TabIndex = 2;
            this.tpAdminList.Text = "Admin List";
            this.tpAdminList.UseVisualStyleBackColor = true;
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminList.Location = new System.Drawing.Point(0, 0);
            this.dgvAdminList.Name = "dgvAdminList";
            this.dgvAdminList.Size = new System.Drawing.Size(843, 595);
            this.dgvAdminList.TabIndex = 0;
            // 
            // tpAdminLogs
            // 
            this.tpAdminLogs.Controls.Add(this.pnlBody);
            this.tpAdminLogs.Controls.Add(this.pnlAdminLogHeader);
            this.tpAdminLogs.Location = new System.Drawing.Point(4, 22);
            this.tpAdminLogs.Name = "tpAdminLogs";
            this.tpAdminLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminLogs.Size = new System.Drawing.Size(843, 595);
            this.tpAdminLogs.TabIndex = 0;
            this.tpAdminLogs.Text = "Admin Logs";
            this.tpAdminLogs.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvAdminLog);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(3, 41);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(837, 551);
            this.pnlBody.TabIndex = 2;
            // 
            // dgvAdminLog
            // 
            this.dgvAdminLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminLog.Location = new System.Drawing.Point(0, 0);
            this.dgvAdminLog.Name = "dgvAdminLog";
            this.dgvAdminLog.Size = new System.Drawing.Size(837, 551);
            this.dgvAdminLog.TabIndex = 1;
            // 
            // pnlAdminLogHeader
            // 
            this.pnlAdminLogHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.pnlAdminLogHeader.Controls.Add(this.bntLoadAdminLog);
            this.pnlAdminLogHeader.Controls.Add(this.lblAdminName);
            this.pnlAdminLogHeader.Controls.Add(this.cmbAdminNames);
            this.pnlAdminLogHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminLogHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlAdminLogHeader.Name = "pnlAdminLogHeader";
            this.pnlAdminLogHeader.Size = new System.Drawing.Size(837, 38);
            this.pnlAdminLogHeader.TabIndex = 1;
            // 
            // bntLoadAdminLog
            // 
            this.bntLoadAdminLog.Location = new System.Drawing.Point(404, 8);
            this.bntLoadAdminLog.Name = "bntLoadAdminLog";
            this.bntLoadAdminLog.Size = new System.Drawing.Size(94, 23);
            this.bntLoadAdminLog.TabIndex = 2;
            this.bntLoadAdminLog.Text = "View Admin Log";
            this.bntLoadAdminLog.UseVisualStyleBackColor = true;
            this.bntLoadAdminLog.Click += new System.EventHandler(this.bntLoadAdminLog_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(20, 11);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(67, 13);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "Admin Name";
            // 
            // cmbAdminNames
            // 
            this.cmbAdminNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdminNames.FormattingEnabled = true;
            this.cmbAdminNames.Location = new System.Drawing.Point(93, 9);
            this.cmbAdminNames.Name = "cmbAdminNames";
            this.cmbAdminNames.Size = new System.Drawing.Size(305, 21);
            this.cmbAdminNames.TabIndex = 0;
            // 
            // tpAddAdmin
            // 
            this.tpAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tpAddAdmin.Controls.Add(this.panel1);
            this.tpAddAdmin.Location = new System.Drawing.Point(4, 22);
            this.tpAddAdmin.Name = "tpAddAdmin";
            this.tpAddAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddAdmin.Size = new System.Drawing.Size(843, 595);
            this.tpAddAdmin.TabIndex = 1;
            this.tpAddAdmin.Text = "Add Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.gbAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 596);
            this.panel1.TabIndex = 0;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.chkIsEnabled);
            this.gbAdmin.Controls.Add(this.btnBrowse);
            this.gbAdmin.Controls.Add(this.txtImagePath);
            this.gbAdmin.Controls.Add(this.labelAdminName);
            this.gbAdmin.Controls.Add(this.picAdmin);
            this.gbAdmin.Controls.Add(this.txtAdminName);
            this.gbAdmin.Controls.Add(this.btnSave);
            this.gbAdmin.Controls.Add(this.lblRemarks);
            this.gbAdmin.Controls.Add(this.txtRemarks);
            this.gbAdmin.ForeColor = System.Drawing.Color.White;
            this.gbAdmin.Location = new System.Drawing.Point(25, 26);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(625, 293);
            this.gbAdmin.TabIndex = 14;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(106, 57);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(76, 17);
            this.chkIsEnabled.TabIndex = 1;
            this.chkIsEnabled.Text = "Is Enabled";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(540, 210);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(434, 213);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(100, 20);
            this.txtImagePath.TabIndex = 3;
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.labelAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAdminName.Location = new System.Drawing.Point(33, 34);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(67, 13);
            this.labelAdminName.TabIndex = 4;
            this.labelAdminName.Text = "Admin Name";
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.picAdmin.Location = new System.Drawing.Point(434, 31);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(139, 173);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 13;
            this.picAdmin.TabStop = false;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(106, 31);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(307, 20);
            this.txtAdminName.TabIndex = 0;
            this.txtAdminName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(338, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.ForeColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(51, 80);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 9;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(106, 80);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(307, 164);
            this.txtRemarks.TabIndex = 3;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.tabManageAdmins);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(851, 621);
            this.Load += new System.EventHandler(this.AdminControl_Load);
            this.tabManageAdmins.ResumeLayout(false);
            this.tpAdminList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            this.tpAdminLogs.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminLog)).EndInit();
            this.pnlAdminLogHeader.ResumeLayout(false);
            this.pnlAdminLogHeader.PerformLayout();
            this.tpAddAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageAdmins;
        private System.Windows.Forms.TabPage tpAdminList;
        private System.Windows.Forms.DataGridView dgvAdminList;
        private System.Windows.Forms.TabPage tpAdminLogs;
        private System.Windows.Forms.TabPage tpAddAdmin;
        private System.Windows.Forms.Panel pnlAdminLogHeader;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.ComboBox cmbAdminNames;
        private System.Windows.Forms.Button bntLoadAdminLog;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvAdminLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.CheckBox chkIsEnabled;
    }
}
