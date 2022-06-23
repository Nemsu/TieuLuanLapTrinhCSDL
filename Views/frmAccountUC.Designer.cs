﻿
namespace TieuLuanLapTrinhCSDL.Views
{
    partial class frmAccountUC
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
            this.toolTipAccountType = new System.Windows.Forms.ToolTip(this.components);
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnInsertAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.cboStaffID_Account = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.txtStaffName_Account = new System.Windows.Forms.TextBox();
            this.lblStaffName_Account = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAccountType
            // 
            this.nudAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nudAccountType.Location = new System.Drawing.Point(392, 104);
            this.nudAccountType.Margin = new System.Windows.Forms.Padding(2);
            this.nudAccountType.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAccountType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(107, 27);
            this.nudAccountType.TabIndex = 6;
            this.toolTipAccountType.SetToolTip(this.nudAccountType, "1 : Quản lý\r\n2 : Bán vé");
            this.nudAccountType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.ValueChanged += new System.EventHandler(this.nudAccountType_ValueChanged);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnUpdateAccount.Location = new System.Drawing.Point(351, 66);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(73, 34);
            this.btnUpdateAccount.TabIndex = 34;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnInsertAccount
            // 
            this.btnInsertAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnInsertAccount.Location = new System.Drawing.Point(266, 66);
            this.btnInsertAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertAccount.Name = "btnInsertAccount";
            this.btnInsertAccount.Size = new System.Drawing.Size(81, 34);
            this.btnInsertAccount.TabIndex = 35;
            this.btnInsertAccount.Text = "Thêm";
            this.btnInsertAccount.UseVisualStyleBackColor = true;
            this.btnInsertAccount.Click += new System.EventHandler(this.btnInsertAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnShowAccount.Location = new System.Drawing.Point(266, 28);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(68, 34);
            this.btnShowAccount.TabIndex = 31;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.Transparent;
            this.grpAccount.Controls.Add(this.btnShowAccount);
            this.grpAccount.Controls.Add(this.btnUpdateAccount);
            this.grpAccount.Controls.Add(this.nudAccountType);
            this.grpAccount.Controls.Add(this.btnInsertAccount);
            this.grpAccount.Controls.Add(this.btnDeleteAccount);
            this.grpAccount.Controls.Add(this.cboStaffID_Account);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.btnResetPass);
            this.grpAccount.Controls.Add(this.txtStaffName_Account);
            this.grpAccount.Controls.Add(this.lblStaffName_Account);
            this.grpAccount.Controls.Add(this.lblAccountType);
            this.grpAccount.Controls.Add(this.lblStaffID_Account);
            this.grpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.grpAccount.Location = new System.Drawing.Point(11, 11);
            this.grpAccount.Margin = new System.Windows.Forms.Padding(2);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Padding = new System.Windows.Forms.Padding(2);
            this.grpAccount.Size = new System.Drawing.Size(550, 157);
            this.grpAccount.TabIndex = 30;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin tài khoản";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDeleteAccount.Location = new System.Drawing.Point(428, 66);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(71, 34);
            this.btnDeleteAccount.TabIndex = 33;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // cboStaffID_Account
            // 
            this.cboStaffID_Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaffID_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboStaffID_Account.FormattingEnabled = true;
            this.cboStaffID_Account.Location = new System.Drawing.Point(151, 66);
            this.cboStaffID_Account.Margin = new System.Windows.Forms.Padding(2);
            this.cboStaffID_Account.Name = "cboStaffID_Account";
            this.cboStaffID_Account.Size = new System.Drawing.Size(111, 28);
            this.cboStaffID_Account.TabIndex = 5;
            this.cboStaffID_Account.SelectedIndexChanged += new System.EventHandler(this.cboStaffID_Account_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUsername.Location = new System.Drawing.Point(54, 30);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 22);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtUsername.Location = new System.Drawing.Point(151, 27);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(111, 27);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(338, 27);
            this.btnResetPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(161, 35);
            this.btnResetPass.TabIndex = 32;
            this.btnResetPass.Text = "Reset mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // txtStaffName_Account
            // 
            this.txtStaffName_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtStaffName_Account.Location = new System.Drawing.Point(151, 103);
            this.txtStaffName_Account.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffName_Account.Name = "txtStaffName_Account";
            this.txtStaffName_Account.ReadOnly = true;
            this.txtStaffName_Account.Size = new System.Drawing.Size(111, 27);
            this.txtStaffName_Account.TabIndex = 2;
            // 
            // lblStaffName_Account
            // 
            this.lblStaffName_Account.AutoSize = true;
            this.lblStaffName_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStaffName_Account.Location = new System.Drawing.Point(54, 106);
            this.lblStaffName_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffName_Account.Name = "lblStaffName_Account";
            this.lblStaffName_Account.Size = new System.Drawing.Size(77, 22);
            this.lblStaffName_Account.TabIndex = 4;
            this.lblStaffName_Account.Text = "Tên NV:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAccountType.Location = new System.Drawing.Point(266, 108);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(122, 22);
            this.lblAccountType.TabIndex = 4;
            this.lblAccountType.Text = "Loại tài khoản";
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStaffID_Account.Location = new System.Drawing.Point(54, 69);
            this.lblStaffID_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(64, 22);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Mã NV";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(12, 173);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.Size = new System.Drawing.Size(549, 310);
            this.dtgvAccount.TabIndex = 29;
            // 
            // frmAccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 504);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.dtgvAccount);
            this.Name = "frmAccountUC";
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipAccountType;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnInsertAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.ComboBox cboStaffID_Account;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStaffName_Account;
        private System.Windows.Forms.Label lblStaffName_Account;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.DataGridView dtgvAccount;
    }
}