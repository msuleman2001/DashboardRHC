
namespace DashboardRHC
{
    partial class HomeControl
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
            this.pnlHighlights = new System.Windows.Forms.Panel();
            this.pnlStaffCount = new System.Windows.Forms.Panel();
            this.lblStaffCountValue = new System.Windows.Forms.Label();
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.lblStaffCountTitle = new System.Windows.Forms.Label();
            this.pnlDeviceCount = new System.Windows.Forms.Panel();
            this.lblDevcesCountValue = new System.Windows.Forms.Label();
            this.picDevices = new System.Windows.Forms.PictureBox();
            this.lblDevicesCountTitle = new System.Windows.Forms.Label();
            this.pnlPatientCount = new System.Windows.Forms.Panel();
            this.lblPatientCountValue = new System.Windows.Forms.Label();
            this.lblPatientCountTitle = new System.Windows.Forms.Label();
            this.picPatientCount = new System.Windows.Forms.PictureBox();
            this.pnlHomeBody = new System.Windows.Forms.Panel();
            this.lblLoadingData = new System.Windows.Forms.Label();
            this.pnlHighlights.SuspendLayout();
            this.pnlStaffCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.pnlDeviceCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevices)).BeginInit();
            this.pnlPatientCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientCount)).BeginInit();
            this.pnlHomeBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHighlights
            // 
            this.pnlHighlights.Controls.Add(this.pnlStaffCount);
            this.pnlHighlights.Controls.Add(this.pnlDeviceCount);
            this.pnlHighlights.Controls.Add(this.pnlPatientCount);
            this.pnlHighlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHighlights.Location = new System.Drawing.Point(0, 0);
            this.pnlHighlights.Name = "pnlHighlights";
            this.pnlHighlights.Size = new System.Drawing.Size(800, 200);
            this.pnlHighlights.TabIndex = 0;
            // 
            // pnlStaffCount
            // 
            this.pnlStaffCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlStaffCount.Controls.Add(this.lblStaffCountValue);
            this.pnlStaffCount.Controls.Add(this.picStaff);
            this.pnlStaffCount.Controls.Add(this.lblStaffCountTitle);
            this.pnlStaffCount.Location = new System.Drawing.Point(550, 24);
            this.pnlStaffCount.Name = "pnlStaffCount";
            this.pnlStaffCount.Size = new System.Drawing.Size(200, 150);
            this.pnlStaffCount.TabIndex = 4;
            // 
            // lblStaffCountValue
            // 
            this.lblStaffCountValue.AutoSize = true;
            this.lblStaffCountValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCountValue.ForeColor = System.Drawing.Color.White;
            this.lblStaffCountValue.Location = new System.Drawing.Point(24, 76);
            this.lblStaffCountValue.Name = "lblStaffCountValue";
            this.lblStaffCountValue.Size = new System.Drawing.Size(63, 43);
            this.lblStaffCountValue.TabIndex = 8;
            this.lblStaffCountValue.Text = "15";
            // 
            // picStaff
            // 
            this.picStaff.BackgroundImage = global::DashboardRHC.Properties.Resources.staff_icon_fw;
            this.picStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStaff.Location = new System.Drawing.Point(111, 70);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(47, 53);
            this.picStaff.TabIndex = 6;
            this.picStaff.TabStop = false;
            // 
            // lblStaffCountTitle
            // 
            this.lblStaffCountTitle.AutoSize = true;
            this.lblStaffCountTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStaffCountTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblStaffCountTitle.Location = new System.Drawing.Point(69, 14);
            this.lblStaffCountTitle.Name = "lblStaffCountTitle";
            this.lblStaffCountTitle.Size = new System.Drawing.Size(57, 24);
            this.lblStaffCountTitle.TabIndex = 7;
            this.lblStaffCountTitle.Text = "Staff";
            // 
            // pnlDeviceCount
            // 
            this.pnlDeviceCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlDeviceCount.Controls.Add(this.lblDevcesCountValue);
            this.pnlDeviceCount.Controls.Add(this.picDevices);
            this.pnlDeviceCount.Controls.Add(this.lblDevicesCountTitle);
            this.pnlDeviceCount.Location = new System.Drawing.Point(300, 24);
            this.pnlDeviceCount.Name = "pnlDeviceCount";
            this.pnlDeviceCount.Size = new System.Drawing.Size(200, 150);
            this.pnlDeviceCount.TabIndex = 3;
            // 
            // lblDevcesCountValue
            // 
            this.lblDevcesCountValue.AutoSize = true;
            this.lblDevcesCountValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevcesCountValue.ForeColor = System.Drawing.Color.White;
            this.lblDevcesCountValue.Location = new System.Drawing.Point(29, 73);
            this.lblDevcesCountValue.Name = "lblDevcesCountValue";
            this.lblDevcesCountValue.Size = new System.Drawing.Size(63, 43);
            this.lblDevcesCountValue.TabIndex = 5;
            this.lblDevcesCountValue.Text = "15";
            // 
            // picDevices
            // 
            this.picDevices.BackgroundImage = global::DashboardRHC.Properties.Resources.devices_icon_fw;
            this.picDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDevices.Location = new System.Drawing.Point(98, 67);
            this.picDevices.Name = "picDevices";
            this.picDevices.Size = new System.Drawing.Size(82, 53);
            this.picDevices.TabIndex = 3;
            this.picDevices.TabStop = false;
            // 
            // lblDevicesCountTitle
            // 
            this.lblDevicesCountTitle.AutoSize = true;
            this.lblDevicesCountTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDevicesCountTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevicesCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblDevicesCountTitle.Location = new System.Drawing.Point(53, 14);
            this.lblDevicesCountTitle.Name = "lblDevicesCountTitle";
            this.lblDevicesCountTitle.Size = new System.Drawing.Size(90, 24);
            this.lblDevicesCountTitle.TabIndex = 4;
            this.lblDevicesCountTitle.Text = "Devices";
            // 
            // pnlPatientCount
            // 
            this.pnlPatientCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlPatientCount.Controls.Add(this.lblPatientCountValue);
            this.pnlPatientCount.Controls.Add(this.lblPatientCountTitle);
            this.pnlPatientCount.Controls.Add(this.picPatientCount);
            this.pnlPatientCount.Location = new System.Drawing.Point(50, 24);
            this.pnlPatientCount.Name = "pnlPatientCount";
            this.pnlPatientCount.Size = new System.Drawing.Size(200, 150);
            this.pnlPatientCount.TabIndex = 2;
            // 
            // lblPatientCountValue
            // 
            this.lblPatientCountValue.AutoSize = true;
            this.lblPatientCountValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientCountValue.ForeColor = System.Drawing.Color.White;
            this.lblPatientCountValue.Location = new System.Drawing.Point(28, 73);
            this.lblPatientCountValue.Name = "lblPatientCountValue";
            this.lblPatientCountValue.Size = new System.Drawing.Size(63, 43);
            this.lblPatientCountValue.TabIndex = 2;
            this.lblPatientCountValue.Text = "15";
            // 
            // lblPatientCountTitle
            // 
            this.lblPatientCountTitle.AutoSize = true;
            this.lblPatientCountTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPatientCountTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblPatientCountTitle.Location = new System.Drawing.Point(47, 14);
            this.lblPatientCountTitle.Name = "lblPatientCountTitle";
            this.lblPatientCountTitle.Size = new System.Drawing.Size(92, 24);
            this.lblPatientCountTitle.TabIndex = 1;
            this.lblPatientCountTitle.Text = "Patients";
            // 
            // picPatientCount
            // 
            this.picPatientCount.BackgroundImage = global::DashboardRHC.Properties.Resources.patient_icon_fw;
            this.picPatientCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPatientCount.Location = new System.Drawing.Point(88, 63);
            this.picPatientCount.Name = "picPatientCount";
            this.picPatientCount.Size = new System.Drawing.Size(83, 60);
            this.picPatientCount.TabIndex = 0;
            this.picPatientCount.TabStop = false;
            // 
            // pnlHomeBody
            // 
            this.pnlHomeBody.Controls.Add(this.lblLoadingData);
            this.pnlHomeBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeBody.Location = new System.Drawing.Point(0, 200);
            this.pnlHomeBody.Name = "pnlHomeBody";
            this.pnlHomeBody.Size = new System.Drawing.Size(800, 320);
            this.pnlHomeBody.TabIndex = 1;
            // 
            // lblLoadingData
            // 
            this.lblLoadingData.AutoSize = true;
            this.lblLoadingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingData.ForeColor = System.Drawing.Color.White;
            this.lblLoadingData.Location = new System.Drawing.Point(349, 148);
            this.lblLoadingData.Name = "lblLoadingData";
            this.lblLoadingData.Size = new System.Drawing.Size(103, 24);
            this.lblLoadingData.TabIndex = 2;
            this.lblLoadingData.Text = "Loading...";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.pnlHomeBody);
            this.Controls.Add(this.pnlHighlights);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(800, 520);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.pnlHighlights.ResumeLayout(false);
            this.pnlStaffCount.ResumeLayout(false);
            this.pnlStaffCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.pnlDeviceCount.ResumeLayout(false);
            this.pnlDeviceCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevices)).EndInit();
            this.pnlPatientCount.ResumeLayout(false);
            this.pnlPatientCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPatientCount)).EndInit();
            this.pnlHomeBody.ResumeLayout(false);
            this.pnlHomeBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHighlights;
        private System.Windows.Forms.Panel pnlStaffCount;
        private System.Windows.Forms.Label lblStaffCountValue;
        private System.Windows.Forms.PictureBox picStaff;
        private System.Windows.Forms.Label lblStaffCountTitle;
        private System.Windows.Forms.Panel pnlDeviceCount;
        private System.Windows.Forms.Label lblDevcesCountValue;
        private System.Windows.Forms.PictureBox picDevices;
        private System.Windows.Forms.Label lblDevicesCountTitle;
        private System.Windows.Forms.Panel pnlPatientCount;
        private System.Windows.Forms.Label lblPatientCountValue;
        private System.Windows.Forms.Label lblPatientCountTitle;
        private System.Windows.Forms.PictureBox picPatientCount;
        private System.Windows.Forms.Panel pnlHomeBody;
        private System.Windows.Forms.Label lblLoadingData;
    }
}
