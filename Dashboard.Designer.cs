
namespace Capacitymatrix
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMasterDataSubmenu = new System.Windows.Forms.Panel();
            this.btnCapacity = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMasterData = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.hmslabel3 = new System.Windows.Forms.Label();
            this.hmslabel2 = new System.Windows.Forms.Label();
            this.hmsLabel1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMasterDataSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelMasterDataSubmenu);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMasterData);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 561);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMasterDataSubmenu
            // 
            this.panelMasterDataSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMasterDataSubmenu.Controls.Add(this.btnCapacity);
            this.panelMasterDataSubmenu.Location = new System.Drawing.Point(0, 246);
            this.panelMasterDataSubmenu.Name = "panelMasterDataSubmenu";
            this.panelMasterDataSubmenu.Size = new System.Drawing.Size(250, 52);
            this.panelMasterDataSubmenu.TabIndex = 5;
            // 
            // btnCapacity
            // 
            this.btnCapacity.FlatAppearance.BorderSize = 0;
            this.btnCapacity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCapacity.ForeColor = System.Drawing.Color.LightGray;
            this.btnCapacity.Location = new System.Drawing.Point(0, 0);
            this.btnCapacity.Name = "btnCapacity";
            this.btnCapacity.Size = new System.Drawing.Size(250, 46);
            this.btnCapacity.TabIndex = 3;
            this.btnCapacity.Text = "Capacity Matrix";
            this.btnCapacity.UseVisualStyleBackColor = true;
            this.btnCapacity.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Location = new System.Drawing.Point(0, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 46);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMasterData
            // 
            this.btnMasterData.FlatAppearance.BorderSize = 0;
            this.btnMasterData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMasterData.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMasterData.Location = new System.Drawing.Point(0, 194);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Size = new System.Drawing.Size(250, 46);
            this.btnMasterData.TabIndex = 2;
            this.btnMasterData.Text = "Master Data Management";
            this.btnMasterData.UseVisualStyleBackColor = true;
            this.btnMasterData.Click += new System.EventHandler(this.btnMasterData_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Location = new System.Drawing.Point(0, 142);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(250, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.Controls.Add(this.btnClose);
            this.panelChildForm.Controls.Add(this.hmslabel3);
            this.panelChildForm.Controls.Add(this.hmslabel2);
            this.panelChildForm.Controls.Add(this.hmsLabel1);
            this.panelChildForm.Location = new System.Drawing.Point(254, 48);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(620, 514);
            this.panelChildForm.TabIndex = 1;
            // 
            // hmslabel3
            // 
            this.hmslabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hmslabel3.AutoSize = true;
            this.hmslabel3.Font = new System.Drawing.Font("Molot", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hmslabel3.ForeColor = System.Drawing.Color.SteelBlue;
            this.hmslabel3.Location = new System.Drawing.Point(190, 279);
            this.hmslabel3.Name = "hmslabel3";
            this.hmslabel3.Size = new System.Drawing.Size(236, 69);
            this.hmslabel3.TabIndex = 2;
            this.hmslabel3.Text = "System";
            // 
            // hmslabel2
            // 
            this.hmslabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hmslabel2.AutoSize = true;
            this.hmslabel2.Font = new System.Drawing.Font("Molot", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hmslabel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.hmslabel2.Location = new System.Drawing.Point(113, 199);
            this.hmslabel2.Name = "hmslabel2";
            this.hmslabel2.Size = new System.Drawing.Size(401, 69);
            this.hmslabel2.TabIndex = 1;
            this.hmslabel2.Text = "Management";
            // 
            // hmsLabel1
            // 
            this.hmsLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hmsLabel1.AutoSize = true;
            this.hmsLabel1.Font = new System.Drawing.Font("Molot", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hmsLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.hmsLabel1.Location = new System.Drawing.Point(204, 121);
            this.hmsLabel1.Name = "hmsLabel1";
            this.hmsLabel1.Size = new System.Drawing.Size(235, 69);
            this.hmsLabel1.TabIndex = 0;
            this.hmsLabel1.Text = "Order ";
            this.hmsLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(572, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(876, 564);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMasterDataSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMasterDataSubmenu;
        private System.Windows.Forms.Button btnCapacity;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMasterData;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label hmsLabel1;
        private System.Windows.Forms.Label hmslabel3;
        private System.Windows.Forms.Label hmslabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
    }
}