
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
            this.pnlHighlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlHighlights.Controls.Add(this.pnlStaffCount);
            this.pnlHighlights.Controls.Add(this.pnlDeviceCount);
            this.pnlHighlights.Controls.Add(this.pnlPatientCount);
            this.pnlHighlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHighlights.Location = new System.Drawing.Point(0, 0);
            this.pnlHighlights.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHighlights.Name = "pnlHighlights";
            this.pnlHighlights.Size = new System.Drawing.Size(933, 231);
            this.pnlHighlights.TabIndex = 0;
            // 
            // pnlStaffCount
            // 
            this.pnlStaffCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.pnlStaffCount.Controls.Add(this.lblStaffCountValue);
            this.pnlStaffCount.Controls.Add(this.picStaff);
            this.pnlStaffCount.Controls.Add(this.lblStaffCountTitle);
            this.pnlStaffCount.Location = new System.Drawing.Point(642, 28);
            this.pnlStaffCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlStaffCount.Name = "pnlStaffCount";
            this.pnlStaffCount.Size = new System.Drawing.Size(233, 173);
            this.pnlStaffCount.TabIndex = 4;
            // 
            // lblStaffCountValue
            // 
            this.lblStaffCountValue.AutoSize = true;
            this.lblStaffCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStaffCountValue.ForeColor = System.Drawing.Color.White;
            this.lblStaffCountValue.Location = new System.Drawing.Point(28, 88);
            this.lblStaffCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffCountValue.Name = "lblStaffCountValue";
            this.lblStaffCountValue.Size = new System.Drawing.Size(60, 42);
            this.lblStaffCountValue.TabIndex = 8;
            this.lblStaffCountValue.Text = "15";
            // 
            // picStaff
            // 
            this.picStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStaff.Location = new System.Drawing.Point(130, 81);
            this.picStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(55, 61);
            this.picStaff.TabIndex = 6;
            this.picStaff.TabStop = false;
            // 
            // lblStaffCountTitle
            // 
            this.lblStaffCountTitle.AutoSize = true;
            this.lblStaffCountTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStaffCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStaffCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblStaffCountTitle.Location = new System.Drawing.Point(80, 16);
            this.lblStaffCountTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffCountTitle.Name = "lblStaffCountTitle";
            this.lblStaffCountTitle.Size = new System.Drawing.Size(60, 29);
            this.lblStaffCountTitle.TabIndex = 7;
            this.lblStaffCountTitle.Text = "Staff";
            // 
            // pnlDeviceCount
            // 
            this.pnlDeviceCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.pnlDeviceCount.Controls.Add(this.lblDevcesCountValue);
            this.pnlDeviceCount.Controls.Add(this.picDevices);
            this.pnlDeviceCount.Controls.Add(this.lblDevicesCountTitle);
            this.pnlDeviceCount.Location = new System.Drawing.Point(350, 28);
            this.pnlDeviceCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlDeviceCount.Name = "pnlDeviceCount";
            this.pnlDeviceCount.Size = new System.Drawing.Size(233, 173);
            this.pnlDeviceCount.TabIndex = 3;
            // 
            // lblDevcesCountValue
            // 
            this.lblDevcesCountValue.AutoSize = true;
            this.lblDevcesCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDevcesCountValue.ForeColor = System.Drawing.Color.White;
            this.lblDevcesCountValue.Location = new System.Drawing.Point(34, 84);
            this.lblDevcesCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevcesCountValue.Name = "lblDevcesCountValue";
            this.lblDevcesCountValue.Size = new System.Drawing.Size(60, 42);
            this.lblDevcesCountValue.TabIndex = 5;
            this.lblDevcesCountValue.Text = "15";
            // 
            // picDevices
            // 
            this.picDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDevices.Location = new System.Drawing.Point(114, 77);
            this.picDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDevices.Name = "picDevices";
            this.picDevices.Size = new System.Drawing.Size(96, 61);
            this.picDevices.TabIndex = 3;
            this.picDevices.TabStop = false;
            // 
            // lblDevicesCountTitle
            // 
            this.lblDevicesCountTitle.AutoSize = true;
            this.lblDevicesCountTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDevicesCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDevicesCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblDevicesCountTitle.Location = new System.Drawing.Point(62, 16);
            this.lblDevicesCountTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevicesCountTitle.Name = "lblDevicesCountTitle";
            this.lblDevicesCountTitle.Size = new System.Drawing.Size(99, 29);
            this.lblDevicesCountTitle.TabIndex = 4;
            this.lblDevicesCountTitle.Text = "Devices";
            // 
            // pnlPatientCount
            // 
            this.pnlPatientCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.pnlPatientCount.Controls.Add(this.lblPatientCountValue);
            this.pnlPatientCount.Controls.Add(this.lblPatientCountTitle);
            this.pnlPatientCount.Controls.Add(this.picPatientCount);
            this.pnlPatientCount.Location = new System.Drawing.Point(58, 28);
            this.pnlPatientCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPatientCount.Name = "pnlPatientCount";
            this.pnlPatientCount.Size = new System.Drawing.Size(233, 173);
            this.pnlPatientCount.TabIndex = 2;
            // 
            // lblPatientCountValue
            // 
            this.lblPatientCountValue.AutoSize = true;
            this.lblPatientCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatientCountValue.ForeColor = System.Drawing.Color.White;
            this.lblPatientCountValue.Location = new System.Drawing.Point(33, 84);
            this.lblPatientCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientCountValue.Name = "lblPatientCountValue";
            this.lblPatientCountValue.Size = new System.Drawing.Size(60, 42);
            this.lblPatientCountValue.TabIndex = 2;
            this.lblPatientCountValue.Text = "15";
            // 
            // lblPatientCountTitle
            // 
            this.lblPatientCountTitle.AutoSize = true;
            this.lblPatientCountTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPatientCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatientCountTitle.ForeColor = System.Drawing.Color.White;
            this.lblPatientCountTitle.Location = new System.Drawing.Point(55, 16);
            this.lblPatientCountTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientCountTitle.Name = "lblPatientCountTitle";
            this.lblPatientCountTitle.Size = new System.Drawing.Size(99, 29);
            this.lblPatientCountTitle.TabIndex = 1;
            this.lblPatientCountTitle.Text = "Patients";
            // 
            // picPatientCount
            // 
            this.picPatientCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPatientCount.Location = new System.Drawing.Point(103, 73);
            this.picPatientCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPatientCount.Name = "picPatientCount";
            this.picPatientCount.Size = new System.Drawing.Size(97, 69);
            this.picPatientCount.TabIndex = 0;
            this.picPatientCount.TabStop = false;
            // 
            // pnlHomeBody
            // 
            this.pnlHomeBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlHomeBody.Controls.Add(this.lblLoadingData);
            this.pnlHomeBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeBody.Location = new System.Drawing.Point(0, 231);
            this.pnlHomeBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHomeBody.Name = "pnlHomeBody";
            this.pnlHomeBody.Size = new System.Drawing.Size(933, 369);
            this.pnlHomeBody.TabIndex = 1;
            // 
            // lblLoadingData
            // 
            this.lblLoadingData.AutoSize = true;
            this.lblLoadingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoadingData.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLoadingData.Location = new System.Drawing.Point(407, 171);
            this.lblLoadingData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadingData.Name = "lblLoadingData";
            this.lblLoadingData.Size = new System.Drawing.Size(103, 24);
            this.lblLoadingData.TabIndex = 2;
            this.lblLoadingData.Text = "Loading...";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.pnlHomeBody);
            this.Controls.Add(this.pnlHighlights);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(933, 600);
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
