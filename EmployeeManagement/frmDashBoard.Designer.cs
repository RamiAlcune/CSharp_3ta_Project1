namespace EmployeeManagement
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DashBoardPannel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentlyUserlabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnINFO = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaidEmployess = new Guna.UI2.WinForms.Guna2Button();
            this.UsersSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.userControlEmployeeMainMenu1 = new EmployeeManagement.UserControlEmployeeMainMenu();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.DashBoardPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1184, 38);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1136, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(50)))));
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel2.Controls.Add(this.CurrentlyUserlabel);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.btnINFO);
            this.guna2Panel2.Controls.Add(this.btnPaidEmployess);
            this.guna2Panel2.Controls.Add(this.UsersSetting);
            this.guna2Panel2.Controls.Add(this.btnEmployees);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 38);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(168, 523);
            this.guna2Panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ESM~DashBoard";
            // 
            // DashBoardPannel
            // 
            this.DashBoardPannel.Controls.Add(this.userControlEmployeeMainMenu1);
            this.DashBoardPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardPannel.Location = new System.Drawing.Point(168, 38);
            this.DashBoardPannel.Name = "DashBoardPannel";
            this.DashBoardPannel.Size = new System.Drawing.Size(1016, 523);
            this.DashBoardPannel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin";
            // 
            // CurrentlyUserlabel
            // 
            this.CurrentlyUserlabel.AutoSize = true;
            this.CurrentlyUserlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentlyUserlabel.ForeColor = System.Drawing.Color.White;
            this.CurrentlyUserlabel.Location = new System.Drawing.Point(58, 48);
            this.CurrentlyUserlabel.Name = "CurrentlyUserlabel";
            this.CurrentlyUserlabel.Size = new System.Drawing.Size(53, 19);
            this.CurrentlyUserlabel.TabIndex = 6;
            this.CurrentlyUserlabel.Text = "NULL";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::EmployeeManagement.Properties.Resources.HomeDashBoard;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(3, 149);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(165, 38);
            this.guna2Button1.TabIndex = 8;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackgroundImage = global::EmployeeManagement.Properties.Resources.Admin;
            this.guna2CirclePictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(3, 36);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(58, 54);
            this.guna2CirclePictureBox2.TabIndex = 7;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // btnINFO
            // 
            this.btnINFO.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnINFO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnINFO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnINFO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnINFO.FillColor = System.Drawing.Color.Transparent;
            this.btnINFO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnINFO.ForeColor = System.Drawing.Color.White;
            this.btnINFO.Image = global::EmployeeManagement.Properties.Resources.infoDashBoard;
            this.btnINFO.ImageSize = new System.Drawing.Size(40, 40);
            this.btnINFO.Location = new System.Drawing.Point(3, 331);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(165, 38);
            this.btnINFO.TabIndex = 3;
            // 
            // btnPaidEmployess
            // 
            this.btnPaidEmployess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaidEmployess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaidEmployess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaidEmployess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaidEmployess.FillColor = System.Drawing.Color.Transparent;
            this.btnPaidEmployess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaidEmployess.ForeColor = System.Drawing.Color.White;
            this.btnPaidEmployess.Image = global::EmployeeManagement.Properties.Resources.PaidUsersDashBoard;
            this.btnPaidEmployess.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPaidEmployess.Location = new System.Drawing.Point(3, 239);
            this.btnPaidEmployess.Name = "btnPaidEmployess";
            this.btnPaidEmployess.Size = new System.Drawing.Size(165, 38);
            this.btnPaidEmployess.TabIndex = 2;
            // 
            // UsersSetting
            // 
            this.UsersSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UsersSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UsersSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UsersSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UsersSetting.FillColor = System.Drawing.Color.Transparent;
            this.UsersSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsersSetting.ForeColor = System.Drawing.Color.White;
            this.UsersSetting.Image = global::EmployeeManagement.Properties.Resources.usersSettingsDashBoard;
            this.UsersSetting.ImageSize = new System.Drawing.Size(40, 40);
            this.UsersSetting.Location = new System.Drawing.Point(3, 285);
            this.UsersSetting.Name = "UsersSetting";
            this.UsersSetting.Size = new System.Drawing.Size(165, 38);
            this.UsersSetting.TabIndex = 1;
            // 
            // btnEmployees
            // 
            this.btnEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployees.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::EmployeeManagement.Properties.Resources.UsersDashBoard;
            this.btnEmployees.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployees.Location = new System.Drawing.Point(3, 193);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(165, 38);
            this.btnEmployees.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImage = global::EmployeeManagement.Properties.Resources.Logo;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Image = global::EmployeeManagement.Properties.Resources.Logo;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(29, 38);
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // userControlEmployeeMainMenu1
            // 
            this.userControlEmployeeMainMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.userControlEmployeeMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlEmployeeMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.userControlEmployeeMainMenu1.Name = "userControlEmployeeMainMenu1";
            this.userControlEmployeeMainMenu1.Size = new System.Drawing.Size(1016, 523);
            this.userControlEmployeeMainMenu1.TabIndex = 0;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.DashBoardPannel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashBoard";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.DashBoardPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnEmployees;
        private Guna.UI2.WinForms.Guna2Button UsersSetting;
        private Guna.UI2.WinForms.Guna2Button btnPaidEmployess;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnINFO;
        private Guna.UI2.WinForms.Guna2Panel DashBoardPannel;
        private System.Windows.Forms.Label CurrentlyUserlabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private UserControlEmployeeMainMenu userControlEmployeeMainMenu1;
    }
}