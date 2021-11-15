
namespace RentBicycle.View
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtRegisPass = new System.Windows.Forms.TextBox();
            this.lblIconPass = new DevComponents.DotNetBar.LabelX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.txtRegisEmail = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblLogin = new DevComponents.DotNetBar.LabelX();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.separatorControl2);
            this.panelRegister.Controls.Add(this.txtRegisPass);
            this.panelRegister.Controls.Add(this.lblIconPass);
            this.panelRegister.Controls.Add(this.lblPassword);
            this.panelRegister.Controls.Add(this.txtRegisEmail);
            this.panelRegister.Controls.Add(this.labelX6);
            this.panelRegister.Controls.Add(this.separatorControl1);
            this.panelRegister.Controls.Add(this.labelX5);
            this.panelRegister.Controls.Add(this.lblLogin);
            this.panelRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelRegister.Location = new System.Drawing.Point(-1, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(796, 529);
            this.panelRegister.TabIndex = 0;
            this.panelRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegister_Paint);
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.BackColor = System.Drawing.Color.Thistle;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegister.Location = new System.Drawing.Point(203, 367);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(373, 76);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "\r\nSign Up";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl2.Location = new System.Drawing.Point(246, 299);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(290, 19);
            this.separatorControl2.TabIndex = 23;
            // 
            // txtRegisPass
            // 
            this.txtRegisPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRegisPass.Location = new System.Drawing.Point(304, 273);
            this.txtRegisPass.Multiline = true;
            this.txtRegisPass.Name = "txtRegisPass";
            this.txtRegisPass.Size = new System.Drawing.Size(219, 20);
            this.txtRegisPass.TabIndex = 22;
            this.txtRegisPass.Text = "Enter Password";
            this.txtRegisPass.Enter += new System.EventHandler(this.txtRegisPass_Enter);
            this.txtRegisPass.Leave += new System.EventHandler(this.txtRegisPass_Leave);
            // 
            // lblIconPass
            // 
            this.lblIconPass.Image = ((System.Drawing.Image)(resources.GetObject("lblIconPass.Image")));
            this.lblIconPass.Location = new System.Drawing.Point(260, 263);
            this.lblIconPass.Name = "lblIconPass";
            this.lblIconPass.Size = new System.Drawing.Size(38, 37);
            this.lblIconPass.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(260, 234);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 23);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "<font color=\"#000000\">Password</font><font color=\"#000000\"></font>";
            // 
            // txtRegisEmail
            // 
            this.txtRegisEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRegisEmail.Location = new System.Drawing.Point(304, 173);
            this.txtRegisEmail.Multiline = true;
            this.txtRegisEmail.Name = "txtRegisEmail";
            this.txtRegisEmail.Size = new System.Drawing.Size(219, 20);
            this.txtRegisEmail.TabIndex = 19;
            this.txtRegisEmail.Text = "Enter Email";
            this.txtRegisEmail.Enter += new System.EventHandler(this.txtRegisEmail_Enter);
            this.txtRegisEmail.Leave += new System.EventHandler(this.txtRegisEmail_Leave);
            // 
            // labelX6
            // 
            this.labelX6.Image = ((System.Drawing.Image)(resources.GetObject("labelX6.Image")));
            this.labelX6.Location = new System.Drawing.Point(260, 163);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(38, 37);
            this.labelX6.TabIndex = 18;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(246, 199);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(290, 19);
            this.separatorControl1.TabIndex = 17;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(260, 134);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "<font color=\"#000000\">Email</font><font color=\"#000000\"></font>";
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.lblLogin.Location = new System.Drawing.Point(331, 21);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(133, 88);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "<b><font color=\"#000000\">Register<font color=\"#000000\"></font></font><font color=" +
    "\"#000000\"></font></b>";
            // 
            // FormRegister
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 529);
            this.Controls.Add(this.panelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegister;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.TextBox txtRegisPass;
        private DevComponents.DotNetBar.LabelX lblIconPass;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private System.Windows.Forms.TextBox txtRegisEmail;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblLogin;
        private DevComponents.DotNetBar.ButtonX btnRegister;
    }
}