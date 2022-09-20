
namespace DashboardRHC
{
    partial class PatientInsightBox
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
            this.components = new System.ComponentModel.Container();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.pnlBoxBody = new System.Windows.Forms.Panel();
            this.lblRepiratoryRate = new System.Windows.Forms.Label();
            this.lblBatteryLife = new System.Windows.Forms.Label();
            this.lblEnvHumidity = new System.Windows.Forms.Label();
            this.lblEnvTemp = new System.Windows.Forms.Label();
            this.lblO2Saturation = new System.Windows.Forms.Label();
            this.lblBodyTemperature = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.tmrDataRequest = new System.Windows.Forms.Timer(this.components);
            this.pnlBoxBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeviceName.ForeColor = System.Drawing.Color.White;
            this.lblDeviceName.Location = new System.Drawing.Point(7, 5);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(113, 18);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device Name";
            // 
            // pnlBoxBody
            // 
            this.pnlBoxBody.Controls.Add(this.lblRepiratoryRate);
            this.pnlBoxBody.Controls.Add(this.lblBatteryLife);
            this.pnlBoxBody.Controls.Add(this.lblEnvHumidity);
            this.pnlBoxBody.Controls.Add(this.lblEnvTemp);
            this.pnlBoxBody.Controls.Add(this.lblO2Saturation);
            this.pnlBoxBody.Controls.Add(this.lblBodyTemperature);
            this.pnlBoxBody.Location = new System.Drawing.Point(0, 23);
            this.pnlBoxBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBoxBody.Name = "pnlBoxBody";
            this.pnlBoxBody.Size = new System.Drawing.Size(233, 153);
            this.pnlBoxBody.TabIndex = 1;
            this.pnlBoxBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoxBody_Paint);
            // 
            // lblRepiratoryRate
            // 
            this.lblRepiratoryRate.AutoSize = true;
            this.lblRepiratoryRate.ForeColor = System.Drawing.Color.White;
            this.lblRepiratoryRate.Location = new System.Drawing.Point(16, 96);
            this.lblRepiratoryRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepiratoryRate.Name = "lblRepiratoryRate";
            this.lblRepiratoryRate.Size = new System.Drawing.Size(70, 15);
            this.lblRepiratoryRate.TabIndex = 14;
            this.lblRepiratoryRate.Text = "Resp Rate   :";
            // 
            // lblBatteryLife
            // 
            this.lblBatteryLife.AutoSize = true;
            this.lblBatteryLife.ForeColor = System.Drawing.Color.White;
            this.lblBatteryLife.Location = new System.Drawing.Point(16, 115);
            this.lblBatteryLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatteryLife.Name = "lblBatteryLife";
            this.lblBatteryLife.Size = new System.Drawing.Size(47, 15);
            this.lblBatteryLife.TabIndex = 13;
            this.lblBatteryLife.Text = "Battery:";
            // 
            // lblEnvHumidity
            // 
            this.lblEnvHumidity.AutoSize = true;
            this.lblEnvHumidity.ForeColor = System.Drawing.Color.White;
            this.lblEnvHumidity.Location = new System.Drawing.Point(18, 76);
            this.lblEnvHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvHumidity.Name = "lblEnvHumidity";
            this.lblEnvHumidity.Size = new System.Drawing.Size(75, 15);
            this.lblEnvHumidity.TabIndex = 11;
            this.lblEnvHumidity.Text = "Evno Humi  :";
            // 
            // lblEnvTemp
            // 
            this.lblEnvTemp.AutoSize = true;
            this.lblEnvTemp.ForeColor = System.Drawing.Color.White;
            this.lblEnvTemp.Location = new System.Drawing.Point(18, 57);
            this.lblEnvTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvTemp.Name = "lblEnvTemp";
            this.lblEnvTemp.Size = new System.Drawing.Size(71, 15);
            this.lblEnvTemp.TabIndex = 10;
            this.lblEnvTemp.Text = "Envo Temp :";
            // 
            // lblO2Saturation
            // 
            this.lblO2Saturation.AutoSize = true;
            this.lblO2Saturation.ForeColor = System.Drawing.Color.White;
            this.lblO2Saturation.Location = new System.Drawing.Point(18, 37);
            this.lblO2Saturation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblO2Saturation.Name = "lblO2Saturation";
            this.lblO2Saturation.Size = new System.Drawing.Size(70, 15);
            this.lblO2Saturation.TabIndex = 9;
            this.lblO2Saturation.Text = "O2 - HR      :";
            // 
            // lblBodyTemperature
            // 
            this.lblBodyTemperature.AutoSize = true;
            this.lblBodyTemperature.ForeColor = System.Drawing.Color.White;
            this.lblBodyTemperature.Location = new System.Drawing.Point(18, 17);
            this.lblBodyTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBodyTemperature.Name = "lblBodyTemperature";
            this.lblBodyTemperature.Size = new System.Drawing.Size(72, 15);
            this.lblBodyTemperature.TabIndex = 8;
            this.lblBodyTemperature.Text = "Body Temp :";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.Location = new System.Drawing.Point(121, 7);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(90, 15);
            this.lblPatientName.TabIndex = 12;
            this.lblPatientName.Text = "PatientName";
            this.lblPatientName.Click += new System.EventHandler(this.lblPatientName_Click);
            // 
            // tmrDataRequest
            // 
            this.tmrDataRequest.Enabled = true;
            this.tmrDataRequest.Interval = 2000;
            this.tmrDataRequest.Tick += new System.EventHandler(this.tmrDataRequest_Tick);
            // 
            // PatientInsightBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.pnlBoxBody);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.lblPatientName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PatientInsightBox";
            this.Size = new System.Drawing.Size(233, 178);
            this.pnlBoxBody.ResumeLayout(false);
            this.pnlBoxBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Panel pnlBoxBody;
        private System.Windows.Forms.Label lblRepiratoryRate;
        private System.Windows.Forms.Label lblBatteryLife;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblEnvHumidity;
        private System.Windows.Forms.Label lblEnvTemp;
        private System.Windows.Forms.Label lblO2Saturation;
        private System.Windows.Forms.Label lblBodyTemperature;
        private System.Windows.Forms.Timer tmrDataRequest;
    }
}
