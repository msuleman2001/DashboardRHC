namespace DashboardRHC
{
    partial class MedicineControl
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
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.gdvMedicine = new System.Windows.Forms.DataGridView();
            this.btnSaveMedicine = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPotency = new System.Windows.Forms.TextBox();
            this.lblPotency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.ForeColor = System.Drawing.Color.White;
            this.lblMedicineName.Location = new System.Drawing.Point(38, 40);
            this.lblMedicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(91, 15);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(140, 37);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(392, 23);
            this.txtMedicineName.TabIndex = 0;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(140, 95);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(392, 84);
            this.txtRemarks.TabIndex = 2;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.ForeColor = System.Drawing.Color.White;
            this.lblRemarks.Location = new System.Drawing.Point(77, 98);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblRemarks.TabIndex = 2;
            this.lblRemarks.Text = "Remarks";
            // 
            // gdvMedicine
            // 
            this.gdvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvMedicine.Location = new System.Drawing.Point(140, 218);
            this.gdvMedicine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gdvMedicine.Name = "gdvMedicine";
            this.gdvMedicine.RowHeadersVisible = false;
            this.gdvMedicine.Size = new System.Drawing.Size(393, 212);
            this.gdvMedicine.TabIndex = 4;
            // 
            // btnSaveMedicine
            // 
            this.btnSaveMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSaveMedicine.Location = new System.Drawing.Point(392, 185);
            this.btnSaveMedicine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveMedicine.Name = "btnSaveMedicine";
            this.btnSaveMedicine.Size = new System.Drawing.Size(66, 27);
            this.btnSaveMedicine.TabIndex = 18;
            this.btnSaveMedicine.Text = "Save";
            this.btnSaveMedicine.UseVisualStyleBackColor = true;
            this.btnSaveMedicine.Click += new System.EventHandler(this.btnSaveMedicine_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(467, 185);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 27);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPotency
            // 
            this.txtPotency.Location = new System.Drawing.Point(141, 66);
            this.txtPotency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPotency.Name = "txtPotency";
            this.txtPotency.Size = new System.Drawing.Size(392, 23);
            this.txtPotency.TabIndex = 1;
            // 
            // lblPotency
            // 
            this.lblPotency.AutoSize = true;
            this.lblPotency.ForeColor = System.Drawing.Color.White;
            this.lblPotency.Location = new System.Drawing.Point(77, 69);
            this.lblPotency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPotency.Name = "lblPotency";
            this.lblPotency.Size = new System.Drawing.Size(50, 15);
            this.lblPotency.TabIndex = 20;
            this.lblPotency.Text = "Potency";
            // 
            // MedicineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtPotency);
            this.Controls.Add(this.lblPotency);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveMedicine);
            this.Controls.Add(this.gdvMedicine);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblMedicineName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MedicineControl";
            this.Size = new System.Drawing.Size(608, 462);
            this.Load += new System.EventHandler(this.MedicineControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DataGridView gdvMedicine;
        private System.Windows.Forms.Button btnSaveMedicine;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPotency;
        private System.Windows.Forms.Label lblPotency;
    }
}
