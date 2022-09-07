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
            ((System.ComponentModel.ISupportInitialize)(this.gdvLabTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseLabTest
            // 
            this.btnCloseLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLabTest.ForeColor = System.Drawing.Color.White;
            this.btnCloseLabTest.Location = new System.Drawing.Point(516, 194);
            this.btnCloseLabTest.Name = "btnCloseLabTest";
            this.btnCloseLabTest.Size = new System.Drawing.Size(57, 23);
            this.btnCloseLabTest.TabIndex = 26;
            this.btnCloseLabTest.Text = "Close";
            this.btnCloseLabTest.UseVisualStyleBackColor = true;
            this.btnCloseLabTest.Click += new System.EventHandler(this.btnCloseLabTest_Click);
            // 
            // btnSaveLabTest
            // 
            this.btnSaveLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLabTest.ForeColor = System.Drawing.Color.White;
            this.btnSaveLabTest.Location = new System.Drawing.Point(453, 194);
            this.btnSaveLabTest.Name = "btnSaveLabTest";
            this.btnSaveLabTest.Size = new System.Drawing.Size(57, 23);
            this.btnSaveLabTest.TabIndex = 25;
            this.btnSaveLabTest.Text = "Save";
            this.btnSaveLabTest.UseVisualStyleBackColor = true;
            this.btnSaveLabTest.Click += new System.EventHandler(this.btnSaveLabTest_Click);
            // 
            // gdvLabTest
            // 
            this.gdvLabTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvLabTest.Location = new System.Drawing.Point(236, 236);
            this.gdvLabTest.Name = "gdvLabTest";
            this.gdvLabTest.Size = new System.Drawing.Size(337, 184);
            this.gdvLabTest.TabIndex = 24;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(236, 131);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(337, 57);
            this.txtRemarks.TabIndex = 23;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.ForeColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(181, 149);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 22;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtLabTetsName
            // 
            this.txtLabTetsName.Location = new System.Drawing.Point(236, 79);
            this.txtLabTetsName.Name = "txtLabTetsName";
            this.txtLabTetsName.Size = new System.Drawing.Size(337, 20);
            this.txtLabTetsName.TabIndex = 21;
            // 
            // lblLabTestName
            // 
            this.lblLabTestName.AutoSize = true;
            this.lblLabTestName.ForeColor = System.Drawing.Color.White;
            this.lblLabTestName.Location = new System.Drawing.Point(149, 82);
            this.lblLabTestName.Name = "lblLabTestName";
            this.lblLabTestName.Size = new System.Drawing.Size(77, 13);
            this.lblLabTestName.TabIndex = 20;
            this.lblLabTestName.Text = "LabTest Name";
            // 
            // txtNormalValue
            // 
            this.txtNormalValue.Location = new System.Drawing.Point(236, 105);
            this.txtNormalValue.Name = "txtNormalValue";
            this.txtNormalValue.Size = new System.Drawing.Size(337, 20);
            this.txtNormalValue.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Normal Value";
            // 
            // LabTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.txtNormalValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseLabTest);
            this.Controls.Add(this.btnSaveLabTest);
            this.Controls.Add(this.gdvLabTest);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtLabTetsName);
            this.Controls.Add(this.lblLabTestName);
            this.Name = "LabTestControl";
            this.Size = new System.Drawing.Size(723, 498);
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
    }
}
