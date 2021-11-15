

namespace RentBicycle.View
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelFormMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSettingDropDown = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnEditAccount = new FontAwesome.Sharp.IconButton();
            this.btnCog = new FontAwesome.Sharp.IconButton();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblUserRole = new DevComponents.DotNetBar.LabelX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnAccManagement = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnProducts = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.timerPnlSetting = new System.Windows.Forms.Timer(this.components);
            this.panelFormMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSettingDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormMain
            // 
            this.panelFormMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormMain.BackColor = System.Drawing.Color.White;
            this.panelFormMain.Controls.Add(this.panelContent);
            this.panelFormMain.Controls.Add(this.panelTitle);
            this.panelFormMain.Controls.Add(this.panelMenu);
            this.panelFormMain.Location = new System.Drawing.Point(-2, 0);
            this.panelFormMain.Name = "panelFormMain";
            this.panelFormMain.Size = new System.Drawing.Size(1927, 1060);
            this.panelFormMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.Thistle;
            this.panelContent.Location = new System.Drawing.Point(360, 168);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1567, 892);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(170)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.panel1);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Location = new System.Drawing.Point(360, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1567, 171);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(8, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1074, 115);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSettingDropDown);
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Controls.Add(this.lblUserRole);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(1088, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 122);
            this.panel1.TabIndex = 2;
            // 
            // pnlSettingDropDown
            // 
            this.pnlSettingDropDown.Controls.Add(this.btnLogout);
            this.pnlSettingDropDown.Controls.Add(this.btnEditAccount);
            this.pnlSettingDropDown.Controls.Add(this.btnCog);
            this.pnlSettingDropDown.Location = new System.Drawing.Point(341, 28);
            this.pnlSettingDropDown.MaximumSize = new System.Drawing.Size(83, 88);
            this.pnlSettingDropDown.MinimumSize = new System.Drawing.Size(83, 29);
            this.pnlSettingDropDown.Name = "pnlSettingDropDown";
            this.pnlSettingDropDown.Size = new System.Drawing.Size(83, 29);
            this.pnlSettingDropDown.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 18;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLogout.Location = new System.Drawing.Point(3, 61);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditAccount.IconColor = System.Drawing.Color.Black;
            this.btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAccount.IconSize = 20;
            this.btnEditAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAccount.Location = new System.Drawing.Point(3, 32);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(77, 23);
            this.btnEditAccount.TabIndex = 1;
            this.btnEditAccount.Text = "Account";
            this.btnEditAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnCog
            // 
            this.btnCog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCog.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnCog.IconColor = System.Drawing.Color.Black;
            this.btnCog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCog.IconSize = 20;
            this.btnCog.Location = new System.Drawing.Point(3, 3);
            this.btnCog.Name = "btnCog";
            this.btnCog.Size = new System.Drawing.Size(77, 23);
            this.btnCog.TabIndex = 0;
            this.btnCog.UseVisualStyleBackColor = true;
            this.btnCog.Click += new System.EventHandler(this.btnCog_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(3, 3);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(127, 116);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 4;
            this.picAvatar.TabStop = false;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.Black;
            this.lblUserRole.Location = new System.Drawing.Point(136, 57);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(202, 23);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Null";
            this.lblUserRole.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(136, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(199, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Null";
            this.lblUserName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(170)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(170)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1437, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 32);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(170)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(153)))), ((int)(((byte)(170)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1518, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(162)))), ((int)(((byte)(186)))));
            this.panelMenu.Controls.Add(this.btnLogo);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnAccManagement);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(362, 1060);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogo.IconColor = System.Drawing.Color.Black;
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnLogo.Size = new System.Drawing.Size(359, 169);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.Text = "LNT\r\nBicycle Rent\r\n";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(10, 195);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(344, 109);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard ";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAccManagement
            // 
            this.btnAccManagement.FlatAppearance.BorderSize = 0;
            this.btnAccManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccManagement.ForeColor = System.Drawing.Color.White;
            this.btnAccManagement.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnAccManagement.IconColor = System.Drawing.Color.White;
            this.btnAccManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccManagement.Location = new System.Drawing.Point(10, 655);
            this.btnAccManagement.Name = "btnAccManagement";
            this.btnAccManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccManagement.Size = new System.Drawing.Size(344, 109);
            this.btnAccManagement.TabIndex = 9;
            this.btnAccManagement.Text = "Account Management";
            this.btnAccManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccManagement.UseVisualStyleBackColor = true;
            this.btnAccManagement.Click += new System.EventHandler(this.btnAccManagement_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnCustomer.IconColor = System.Drawing.Color.White;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(10, 425);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(344, 109);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Bicycle;
            this.btnProducts.IconColor = System.Drawing.Color.White;
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(10, 540);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(344, 109);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(162)))), ((int)(((byte)(186)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.White;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(10, 310);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(344, 109);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Orders / Bicycle Rent";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // timerPnlSetting
            // 
            this.timerPnlSetting.Interval = 15;
            this.timerPnlSetting.Tick += new System.EventHandler(this.timerPnlSetting_Tick_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panelFormMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelFormMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlSettingDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnAccManagement;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.LabelX lblUserRole;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnLogo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlSettingDropDown;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnEditAccount;
        private FontAwesome.Sharp.IconButton btnCog;
        private System.Windows.Forms.Timer timerPnlSetting;
    }
}