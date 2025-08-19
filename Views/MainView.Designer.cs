namespace POS_V1.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblUserLoggedin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flPanelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 65);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "POS Application";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.flPanelMenu);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 548);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::POS_V1.Properties.Resources.userLogo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flPanelMenu
            // 
            this.flPanelMenu.Controls.Add(this.btnDashboard);
            this.flPanelMenu.Controls.Add(this.btnProducts);
            this.flPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPanelMenu.Location = new System.Drawing.Point(0, 65);
            this.flPanelMenu.Name = "flPanelMenu";
            this.flPanelMenu.Size = new System.Drawing.Size(218, 409);
            this.flPanelMenu.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(218, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblUserLoggedin
            // 
            this.lblUserLoggedin.AutoSize = true;
            this.lblUserLoggedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoggedin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserLoggedin.Location = new System.Drawing.Point(72, 17);
            this.lblUserLoggedin.Name = "lblUserLoggedin";
            this.lblUserLoggedin.Size = new System.Drawing.Size(83, 20);
            this.lblUserLoggedin.TabIndex = 0;
            this.lblUserLoggedin.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblUserLoggedin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 65);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 474);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 74);
            this.panel4.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(218, 74);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProducts.Location = new System.Drawing.Point(0, 48);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(218, 48);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flPanelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flPanelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblUserLoggedin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProducts;
    }
}