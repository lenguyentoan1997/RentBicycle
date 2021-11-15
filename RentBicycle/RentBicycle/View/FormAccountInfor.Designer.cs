
namespace RentBicycle.View
{
    partial class FormAccountInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountInfor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccSave = new FontAwesome.Sharp.IconButton();
            this.txtAccNewPass = new System.Windows.Forms.TextBox();
            this.txtAccOldPass = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new FontAwesome.Sharp.IconButton();
            this.picAccountAvatar = new System.Windows.Forms.PictureBox();
            this.txtImgName = new System.Windows.Forms.TextBox();
            this.txtPassMatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeDOB = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txt = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeDOB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.dateTimeDOB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAccountPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPassMatch);
            this.panel1.Controls.Add(this.txtImgName);
            this.panel1.Controls.Add(this.btnAccSave);
            this.panel1.Controls.Add(this.txtAccNewPass);
            this.panel1.Controls.Add(this.txtAccOldPass);
            this.panel1.Controls.Add(this.txtAccountName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.picAccountAvatar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1587, 644);
            this.panel1.TabIndex = 0;
            // 
            // btnAccSave
            // 
            this.btnAccSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAccSave.IconColor = System.Drawing.Color.Black;
            this.btnAccSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccSave.IconSize = 30;
            this.btnAccSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccSave.Location = new System.Drawing.Point(631, 530);
            this.btnAccSave.Name = "btnAccSave";
            this.btnAccSave.Size = new System.Drawing.Size(107, 40);
            this.btnAccSave.TabIndex = 20;
            this.btnAccSave.Text = "Save";
            this.btnAccSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccSave.UseVisualStyleBackColor = true;
            // 
            // txtAccNewPass
            // 
            this.txtAccNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNewPass.Location = new System.Drawing.Point(561, 376);
            this.txtAccNewPass.Multiline = true;
            this.txtAccNewPass.Name = "txtAccNewPass";
            this.txtAccNewPass.PasswordChar = '●';
            this.txtAccNewPass.Size = new System.Drawing.Size(250, 34);
            this.txtAccNewPass.TabIndex = 19;
            // 
            // txtAccOldPass
            // 
            this.txtAccOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccOldPass.Location = new System.Drawing.Point(561, 301);
            this.txtAccOldPass.Multiline = true;
            this.txtAccOldPass.Name = "txtAccOldPass";
            this.txtAccOldPass.PasswordChar = '●';
            this.txtAccOldPass.Size = new System.Drawing.Size(250, 34);
            this.txtAccOldPass.TabIndex = 18;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(561, 116);
            this.txtAccountName.Multiline = true;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(250, 34);
            this.txtAccountName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnOpenFile.IconColor = System.Drawing.Color.Black;
            this.btnOpenFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenFile.IconSize = 30;
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(959, 355);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(139, 44);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "Open File\r\n";
            this.btnOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // picAccountAvatar
            // 
            this.picAccountAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAccountAvatar.Image")));
            this.picAccountAvatar.Location = new System.Drawing.Point(910, 116);
            this.picAccountAvatar.Name = "picAccountAvatar";
            this.picAccountAvatar.Size = new System.Drawing.Size(230, 191);
            this.picAccountAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccountAvatar.TabIndex = 0;
            this.picAccountAvatar.TabStop = false;
            // 
            // txtImgName
            // 
            this.txtImgName.BackColor = System.Drawing.Color.Thistle;
            this.txtImgName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgName.Location = new System.Drawing.Point(910, 314);
            this.txtImgName.Multiline = true;
            this.txtImgName.Name = "txtImgName";
            this.txtImgName.ReadOnly = true;
            this.txtImgName.Size = new System.Drawing.Size(230, 35);
            this.txtImgName.TabIndex = 21;
            this.txtImgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassMatch
            // 
            this.txtPassMatch.BackColor = System.Drawing.Color.Thistle;
            this.txtPassMatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassMatch.Location = new System.Drawing.Point(561, 498);
            this.txtPassMatch.Name = "txtPassMatch";
            this.txtPassMatch.ReadOnly = true;
            this.txtPassMatch.Size = new System.Drawing.Size(250, 15);
            this.txtPassMatch.TabIndex = 22;
            this.txtPassMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone";
            // 
            // txtAccountPhone
            // 
            this.txtAccountPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountPhone.Location = new System.Drawing.Point(561, 178);
            this.txtAccountPhone.Multiline = true;
            this.txtAccountPhone.Name = "txtAccountPhone";
            this.txtAccountPhone.Size = new System.Drawing.Size(250, 34);
            this.txtAccountPhone.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date Of Birthday";
            // 
            // dateTimeDOB
            // 
            // 
            // 
            // 
            this.dateTimeDOB.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeDOB.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeDOB.ButtonDropDown.Visible = true;
            this.dateTimeDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOB.Location = new System.Drawing.Point(561, 244);
            // 
            // 
            // 
            this.dateTimeDOB.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeDOB.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeDOB.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeDOB.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeDOB.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeDOB.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeDOB.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeDOB.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeDOB.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeDOB.MonthCalendar.DisplayMonth = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            this.dateTimeDOB.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeDOB.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeDOB.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeDOB.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeDOB.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeDOB.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeDOB.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(250, 26);
            this.dateTimeDOB.TabIndex = 26;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(313, 447);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(236, 31);
            this.txt.TabIndex = 27;
            this.txt.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(561, 447);
            this.txtConfirmPass.Multiline = true;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.Size = new System.Drawing.Size(250, 34);
            this.txtConfirmPass.TabIndex = 28;
            // 
            // FormAccountInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 646);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccountInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccountInfor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAccountInfor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeDOB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAccountAvatar;
        private FontAwesome.Sharp.IconButton btnOpenFile;
        private FontAwesome.Sharp.IconButton btnAccSave;
        private System.Windows.Forms.TextBox txtAccNewPass;
        private System.Windows.Forms.TextBox txtAccOldPass;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImgName;
        private System.Windows.Forms.TextBox txtPassMatch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label txt;
    }
}