namespace POS_V1.Views
{
    partial class LoginView
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
            this.panelLeftLogin = new System.Windows.Forms.Panel();
            this.panelRightLogin = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPosSystem = new System.Windows.Forms.Label();
            this.pictureLoginLogo = new System.Windows.Forms.PictureBox();
            this.panelLeftLogin.SuspendLayout();
            this.panelRightLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftLogin
            // 
            this.panelLeftLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLeftLogin.BackgroundImage = global::POS_V1.Properties.Resources.loginBG;
            this.panelLeftLogin.Controls.Add(this.lblPosSystem);
            this.panelLeftLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLeftLogin.Name = "panelLeftLogin";
            this.panelLeftLogin.Size = new System.Drawing.Size(468, 611);
            this.panelLeftLogin.TabIndex = 0;
            // 
            // panelRightLogin
            // 
            this.panelRightLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.panelRightLogin.Controls.Add(this.panelLogin);
            this.panelRightLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightLogin.Location = new System.Drawing.Point(465, 0);
            this.panelRightLogin.Name = "panelRightLogin";
            this.panelRightLogin.Size = new System.Drawing.Size(469, 611);
            this.panelRightLogin.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.tbUsername);
            this.panelLogin.Controls.Add(this.pictureLoginLogo);
            this.panelLogin.Controls.Add(this.btnCancel);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(72, 148);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(323, 329);
            this.panelLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(25, 272);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 39);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(164, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(25, 184);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(272, 27);
            this.tbUsername.TabIndex = 4;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(126, 151);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 28);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(25, 220);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(272, 27);
            this.tbPassword.TabIndex = 6;
            // 
            // lblPosSystem
            // 
            this.lblPosSystem.AutoSize = true;
            this.lblPosSystem.BackColor = System.Drawing.Color.Transparent;
            this.lblPosSystem.Font = new System.Drawing.Font("Microsoft YaHei", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPosSystem.Location = new System.Drawing.Point(125, 250);
            this.lblPosSystem.Name = "lblPosSystem";
            this.lblPosSystem.Size = new System.Drawing.Size(218, 111);
            this.lblPosSystem.TabIndex = 7;
            this.lblPosSystem.Text = "Welcome\r\nTO\r\nPOS Inventory\r\n";
            this.lblPosSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureLoginLogo
            // 
            this.pictureLoginLogo.Image = global::POS_V1.Properties.Resources.inventory_logo;
            this.pictureLoginLogo.Location = new System.Drawing.Point(85, 12);
            this.pictureLoginLogo.Name = "pictureLoginLogo";
            this.pictureLoginLogo.Size = new System.Drawing.Size(152, 131);
            this.pictureLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLoginLogo.TabIndex = 2;
            this.pictureLoginLogo.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panelRightLogin);
            this.Controls.Add(this.panelLeftLogin);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginView";
            this.panelLeftLogin.ResumeLayout(false);
            this.panelLeftLogin.PerformLayout();
            this.panelRightLogin.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftLogin;
        private System.Windows.Forms.Panel panelRightLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.PictureBox pictureLoginLogo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPosSystem;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}