namespace BookManage
{
    partial class frmAdmin
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
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbLogout.Location = new System.Drawing.Point(1488, 59);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(104, 24);
            this.lbLogout.TabIndex = 12;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            this.lbLogout.MouseLeave += new System.EventHandler(this.lbLogout_MouseLeave);
            this.lbLogout.MouseHover += new System.EventHandler(this.lbLogout_MouseHover);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Crimson;
            this.lbName.Location = new System.Drawing.Point(1487, 9);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 31);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "tml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(1304, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chào mừng bạn,";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Green;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(1425, 985);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 74);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManage.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(237, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1040, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnBook
            // 
            this.btnBook.BackgroundImage = global::BookManage.Properties.Resources.bookmanage__1_;
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Location = new System.Drawing.Point(761, 712);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(516, 254);
            this.btnBook.TabIndex = 18;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackgroundImage = global::BookManage.Properties.Resources.borrowmanage1;
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrow.Location = new System.Drawing.Point(237, 712);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(516, 254);
            this.btnBorrow.TabIndex = 17;
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackgroundImage = global::BookManage.Properties.Resources.Authormanage;
            this.btnAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthor.Location = new System.Drawing.Point(761, 452);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(516, 254);
            this.btnAuthor.TabIndex = 16;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = global::BookManage.Properties.Resources.usersmanage;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Location = new System.Drawing.Point(237, 452);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(516, 254);
            this.btnUsers.TabIndex = 15;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1676, 1397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUsers;
    }
}