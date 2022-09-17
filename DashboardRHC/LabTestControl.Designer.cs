namespace DashboardRHC
{
    partial class LabTestControl
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
            this.btnCloseLabTest = new System.Windows.Forms.Button();
            this.btnSaveLabTest = new System.Windows.Forms.Button();
            this.gdvLabTest = new System.Windows.Forms.DataGridView();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtLabTetsName = new System.Windows.Forms.TextBox();
            this.lblLabTestName = new System.Windows.Forms.Label();
            this.txtNormalValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLabTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseLabTest
            // 
            this.btnCloseLabTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCloseLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLabTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseLabTest.ForeColor = System.Drawing.Color.White;
            this.btnCloseLabTest.Location = new System.Drawing.Point(601, 252);
            this.btnCloseLabTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloseLabTest.Name = "btnCloseLabTest";
            this.btnCloseLabTest.Size = new System.Drawing.Size(66, 27);
            this.btnCloseLabTest.TabIndex = 26;
            this.btnCloseLabTest.Text = "Close";
            this.btnCloseLabTest.UseVisualStyleBackColor = false;
            this.btnCloseLabTest.Click += new System.EventHandler(this.btnCloseLabTest_Click);
            // 
            // btnSaveLabTest
            // 
            this.btnSaveLabTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnSaveLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLabTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveLabTest.ForeColor = System.Drawing.Color.White;
            this.btnSaveLabTest.Location = new System.Drawing.Point(527, 252);
            this.btnSaveLabTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveLabTest.Name = "btnSaveLabTest";
            this.btnSaveLabTest.Size = new System.Drawing.Size(66, 27);
            this.btnSaveLabTest.TabIndex = 25;
            this.btnSaveLabTest.Text = "Save";
            this.btnSaveLabTest.UseVisualStyleBackColor = false;
            this.btnSaveLabTest.Click += new System.EventHandler(this.btnSaveLabTest_Click);
            // 
            // gdvLabTest
            // 
            this.gdvLabTest.BackgroundColor = System.Drawing.Color.LightCyan;
            this.gdvLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvLabTest.Location = new System.Drawing.Point(274, 300);
            this.gdvLabTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gdvLabTest.Name = "gdvLabTest";
            this.gdvLabTest.Size = new System.Drawing.Size(393, 212);
            this.gdvLabTest.TabIndex = 24;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(274, 179);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(392, 65);
            this.txtRemarks.TabIndex = 23;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.lblRemarks.Location = new System.Drawing.Point(171, 179);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(75, 19);
            this.lblRemarks.TabIndex = 22;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtLabTetsName
            // 
            this.txtLabTetsName.Location = new System.Drawing.Point(274, 119);
            this.txtLabTetsName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLabTetsName.Name = "txtLabTetsName";
            this.txtLabTetsName.Size = new System.Drawing.Size(392, 23);
            this.txtLabTetsName.TabIndex = 21;
            // 
            // lblLabTestName
            // 
            this.lblLabTestName.AutoSize = true;
            this.lblLabTestName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLabTestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.lblLabTestName.Location = new System.Drawing.Point(128, 118);
            this.lblLabTestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabTestName.Name = "lblLabTestName";
            this.lblLabTestName.Size = new System.Drawing.Size(122, 19);
            this.lblLabTestName.TabIndex = 20;
            this.lblLabTestName.Text = "Lab Test Name";
            // 
            // txtNormalValue
            // 
            this.txtNormalValue.Location = new System.Drawing.Point(274, 149);
            this.txtNormalValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNormalValue.Name = "txtNormalValue";
            this.txtNormalValue.Size = new System.Drawing.Size(392, 23);
            this.txtNormalValue.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(129, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Normal Value";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.lblTitle.Location = new System.Drawing.Point(34, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 25);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Lab Test";
            // 
            // LabTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNormalValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseLabTest);
            this.Controls.Add(this.btnSaveLabTest);
            this.Controls.Add(this.gdvLabTest);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtLabTetsName);
            this.Controls.Add(this.lblLabTestName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LabTestControl";
            this.Size = new System.Drawing.Size(844, 575);
            ((System.ComponentModel.ISupportInitialize)(this.gdvLabTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseLabTest;
        private System.Windows.Forms.Button btnSaveLabTest;
        private System.Windows.Forms.DataGridView gdvLabTest;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtLabTetsName;
        private System.Windows.Forms.Label lblLabTestName;
        private System.Windows.Forms.TextBox txtNormalValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}
