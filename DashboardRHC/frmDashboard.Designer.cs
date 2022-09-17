
namespace DashboardRHC
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNameRHC = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.picSAFERHLogo = new System.Windows.Forms.PictureBox();
            this.pnlCommand = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlAdminOps = new System.Windows.Forms.Panel();
            this.btnStartCollectionService = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnStaffRequests = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.niSAFERH = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmrDashboard = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSAFERHLogo)).BeginInit();
            this.pnlCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlAdminOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(330, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.pnlHeader.Controls.Add(this.lblNameRHC);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Controls.Add(this.picSAFERHLogo);
            this.pnlHeader.Controls.Add(this.pnlCommand);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 92);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblNameRHC
            // 
            this.lblNameRHC.AutoSize = true;
            this.lblNameRHC.BackColor = System.Drawing.Color.Transparent;
            this.lblNameRHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNameRHC.ForeColor = System.Drawing.Color.White;
            this.lblNameRHC.Location = new System.Drawing.Point(223, 52);
            this.lblNameRHC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameRHC.Name = "lblNameRHC";
            this.lblNameRHC.Size = new System.Drawing.Size(183, 24);
            this.lblNameRHC.TabIndex = 8;
            this.lblNameRHC.Text = "RHC Khanqah Sharif";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(223, 18);
            this.lblAppTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(563, 25);
            this.lblAppTitle.TabIndex = 6;
            this.lblAppTitle.Text = "Sensing, ArtiFicial Intelligence and Edge Networking";
            // 
            // picSAFERHLogo
            // 
            this.picSAFERHLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSAFERHLogo.Image = global::DashboardRHC.Properties.Resources.SAFE_RH_LOGO;
            this.picSAFERHLogo.Location = new System.Drawing.Point(14, 18);
            this.picSAFERHLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picSAFERHLogo.Name = "picSAFERHLogo";
            this.picSAFERHLogo.Size = new System.Drawing.Size(184, 58);
            this.picSAFERHLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSAFERHLogo.TabIndex = 5;
            this.picSAFERHLogo.TabStop = false;
            this.picSAFERHLogo.Click += new System.EventHandler(this.picSAFERHLogo_Click);
            // 
            // pnlCommand
            // 
            this.pnlCommand.Controls.Add(this.lblUsername);
            this.pnlCommand.Controls.Add(this.picUser);
            this.pnlCommand.Controls.Add(this.btnMinimize);
            this.pnlCommand.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCommand.Location = new System.Drawing.Point(1027, 0);
            this.pnlCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCommand.Name = "pnlCommand";
            this.pnlCommand.Size = new System.Drawing.Size(373, 92);
            this.pnlCommand.TabIndex = 4;
            this.pnlCommand.MouseHover += new System.EventHandler(this.pnlCommand_MouseHover);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(69, 22);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Current Admin";
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = global::DashboardRHC.Properties.Resources.admin_icon;
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(14, 25);
            this.picUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(47, 46);
            this.picUser.TabIndex = 5;
            this.picUser.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlSidebar.Controls.Add(this.btnDevices);
            this.pnlSidebar.Controls.Add(this.btnStaff);
            this.pnlSidebar.Controls.Add(this.btnPatient);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 92);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(233, 831);
            this.pnlSidebar.TabIndex = 3;
            // 
            // btnDevices
            // 
            this.btnDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevices.FlatAppearance.BorderSize = 0;
            this.btnDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDevices.ForeColor = System.Drawing.Color.White;
            this.btnDevices.Location = new System.Drawing.Point(14, 184);
            this.btnDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Size = new System.Drawing.Size(219, 46);
            this.btnDevices.TabIndex = 3;
            this.btnDevices.Text = "Devices";
            this.btnDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevices.UseVisualStyleBackColor = false;
            this.btnDevices.Click += new System.EventHandler(this.Sidebar_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(14, 138);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(219, 46);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.Sidebar_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Location = new System.Drawing.Point(14, 92);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(219, 46);
            this.btnPatient.TabIndex = 1;
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.Sidebar_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(14, 47);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(219, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Sidebar_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.pnlAdminOps);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(233, 92);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1167, 831);
            this.pnlBody.TabIndex = 4;
            // 
            // pnlAdminOps
            // 
            this.pnlAdminOps.Controls.Add(this.btnStartCollectionService);
            this.pnlAdminOps.Controls.Add(this.btnLogout);
            this.pnlAdminOps.Controls.Add(this.btnChangePassword);
            this.pnlAdminOps.Controls.Add(this.btnAdmins);
            this.pnlAdminOps.Controls.Add(this.btnStaffRequests);
            this.pnlAdminOps.Controls.Add(this.btnNotifications);
            this.pnlAdminOps.Location = new System.Drawing.Point(794, 3);
            this.pnlAdminOps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdminOps.Name = "pnlAdminOps";
            this.pnlAdminOps.Size = new System.Drawing.Size(233, 175);
            this.pnlAdminOps.TabIndex = 0;
            this.pnlAdminOps.Visible = false;
            this.pnlAdminOps.MouseLeave += new System.EventHandler(this.pnlAdminOps_MouseLeave);
            this.pnlAdminOps.MouseHover += new System.EventHandler(this.pnlAdminOps_MouseHover);
            // 
            // btnStartCollectionService
            // 
            this.btnStartCollectionService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStartCollectionService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCollectionService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartCollectionService.FlatAppearance.BorderSize = 0;
            this.btnStartCollectionService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStartCollectionService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCollectionService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartCollectionService.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnStartCollectionService.Location = new System.Drawing.Point(0, 145);
            this.btnStartCollectionService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartCollectionService.Name = "btnStartCollectionService";
            this.btnStartCollectionService.Size = new System.Drawing.Size(233, 29);
            this.btnStartCollectionService.TabIndex = 13;
            this.btnStartCollectionService.Text = "Start Collection Serivice";
            this.btnStartCollectionService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartCollectionService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartCollectionService.UseVisualStyleBackColor = false;
            this.btnStartCollectionService.Click += new System.EventHandler(this.btnStartCollectionService_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.Location = new System.Drawing.Point(0, 116);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(233, 29);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 87);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(233, 29);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAdmins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmins.FlatAppearance.BorderSize = 0;
            this.btnAdmins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmins.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdmins.Location = new System.Drawing.Point(0, 58);
            this.btnAdmins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(233, 29);
            this.btnAdmins.TabIndex = 8;
            this.btnAdmins.Text = "Manage Admins";
            this.btnAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnStaffRequests
            // 
            this.btnStaffRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStaffRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffRequests.FlatAppearance.BorderSize = 0;
            this.btnStaffRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStaffRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStaffRequests.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnStaffRequests.Location = new System.Drawing.Point(0, 29);
            this.btnStaffRequests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStaffRequests.Name = "btnStaffRequests";
            this.btnStaffRequests.Size = new System.Drawing.Size(233, 29);
            this.btnStaffRequests.TabIndex = 5;
            this.btnStaffRequests.Text = "Staff Requests";
            this.btnStaffRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffRequests.UseVisualStyleBackColor = false;
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotifications.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 0);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(233, 29);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNotifications.UseVisualStyleBackColor = false;
            // 
            // niSAFERH
            // 
            this.niSAFERH.Text = "SAFE-RH MIS App";
            this.niSAFERH.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niSAFERH_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tmrDashboard
            // 
            this.tmrDashboard.Enabled = true;
            this.tmrDashboard.Interval = 3000;
            this.tmrDashboard.Tick += new System.EventHandler(this.tmrDashboard_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 923);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.Resize += new System.EventHandler(this.frmDashboard_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSAFERHLogo)).EndInit();
            this.pnlCommand.ResumeLayout(false);
            this.pnlCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlAdminOps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCommand;
        private System.Windows.Forms.PictureBox picSAFERHLogo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblNameRHC;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Panel pnlAdminOps;
        private System.Windows.Forms.Button btnStaffRequests;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.NotifyIcon niSAFERH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer tmrDashboard;
        private System.Windows.Forms.Button btnStartCollectionService;
    }
}

