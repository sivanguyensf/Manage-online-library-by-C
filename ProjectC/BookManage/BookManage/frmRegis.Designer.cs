namespace BookManage
{
    partial class frmRegis
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
            this.btnReCap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbShowErrCap = new System.Windows.Forms.Label();
            this.txtReCap = new System.Windows.Forms.TextBox();
            this.txtCapcha = new System.Windows.Forms.TextBox();
            this.lbShowErrPwd = new System.Windows.Forms.Label();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbShowErrID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReCap
            // 
            this.btnReCap.Location = new System.Drawing.Point(651, 274);
            this.btnReCap.Margin = new System.Windows.Forms.Padding(6);
            this.btnReCap.Name = "btnReCap";
            this.btnReCap.Size = new System.Drawing.Size(56, 42);
            this.btnReCap.TabIndex = 19;
            this.btnReCap.Text = "Đổi";
            this.btnReCap.UseVisualStyleBackColor = true;
            this.btnReCap.Click += new System.EventHandler(this.btnReCap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(431, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Capcha";
            // 
            // lbShowErrCap
            // 
            this.lbShowErrCap.AutoSize = true;
            this.lbShowErrCap.Location = new System.Drawing.Point(547, 322);
            this.lbShowErrCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShowErrCap.Name = "lbShowErrCap";
            this.lbShowErrCap.Size = new System.Drawing.Size(64, 25);
            this.lbShowErrCap.TabIndex = 27;
            this.lbShowErrCap.Text = "label3";
            this.lbShowErrCap.Visible = false;
            // 
            // txtReCap
            // 
            this.txtReCap.Location = new System.Drawing.Point(411, 322);
            this.txtReCap.Margin = new System.Windows.Forms.Padding(6);
            this.txtReCap.Name = "txtReCap";
            this.txtReCap.Size = new System.Drawing.Size(124, 29);
            this.txtReCap.TabIndex = 20;
            // 
            // txtCapcha
            // 
            this.txtCapcha.Location = new System.Drawing.Point(321, 280);
            this.txtCapcha.Margin = new System.Windows.Forms.Padding(6);
            this.txtCapcha.Name = "txtCapcha";
            this.txtCapcha.ReadOnly = true;
            this.txtCapcha.Size = new System.Drawing.Size(316, 29);
            this.txtCapcha.TabIndex = 26;
            this.txtCapcha.TabStop = false;
            // 
            // lbShowErrPwd
            // 
            this.lbShowErrPwd.AutoSize = true;
            this.lbShowErrPwd.Location = new System.Drawing.Point(431, 184);
            this.lbShowErrPwd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShowErrPwd.Name = "lbShowErrPwd";
            this.lbShowErrPwd.Size = new System.Drawing.Size(64, 25);
            this.lbShowErrPwd.TabIndex = 25;
            this.lbShowErrPwd.Text = "label5";
            this.lbShowErrPwd.Visible = false;
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(431, 134);
            this.txtRePwd.Margin = new System.Windows.Forms.Padding(6);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.PasswordChar = '*';
            this.txtRePwd.Size = new System.Drawing.Size(318, 29);
            this.txtRePwd.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Xác nhận mật khẩu :";
            // 
            // lbShowErrID
            // 
            this.lbShowErrID.AutoSize = true;
            this.lbShowErrID.Location = new System.Drawing.Point(316, 58);
            this.lbShowErrID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbShowErrID.Name = "lbShowErrID";
            this.lbShowErrID.Size = new System.Drawing.Size(115, 25);
            this.lbShowErrID.TabIndex = 22;
            this.lbShowErrID.Text = "lbShowMsg";
            this.lbShowErrID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(613, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 42);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(245, 385);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 42);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(431, 89);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(6);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(318, 29);
            this.txtPwd.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(431, 23);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(318, 29);
            this.txtID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tài khoản :";
            // 
            // frmRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 472);
            this.Controls.Add(this.btnReCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbShowErrCap);
            this.Controls.Add(this.txtReCap);
            this.Controls.Add(this.txtCapcha);
            this.Controls.Add(this.lbShowErrPwd);
            this.Controls.Add(this.txtRePwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbShowErrID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbShowErrCap;
        private System.Windows.Forms.TextBox txtReCap;
        private System.Windows.Forms.TextBox txtCapcha;
        private System.Windows.Forms.Label lbShowErrPwd;
        private System.Windows.Forms.TextBox txtRePwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbShowErrID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}