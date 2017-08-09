namespace BookManage
{
    partial class frmManageAuthor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAuthorList = new System.Windows.Forms.DataGridView();
            this.btnAuthorExit = new System.Windows.Forms.Button();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.btnAuthorUpdate = new System.Windows.Forms.Button();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsAuthorList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthorList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAuthorList);
            this.groupBox2.Location = new System.Drawing.Point(704, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(660, 411);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tác Giả";
            // 
            // dgvAuthorList
            // 
            this.dgvAuthorList.AllowUserToAddRows = false;
            this.dgvAuthorList.AllowUserToDeleteRows = false;
            this.dgvAuthorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorList.Location = new System.Drawing.Point(8, 32);
            this.dgvAuthorList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuthorList.Name = "dgvAuthorList";
            this.dgvAuthorList.RowTemplate.Height = 24;
            this.dgvAuthorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthorList.Size = new System.Drawing.Size(644, 370);
            this.dgvAuthorList.TabIndex = 0;
            // 
            // btnAuthorExit
            // 
            this.btnAuthorExit.Location = new System.Drawing.Point(1080, 487);
            this.btnAuthorExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorExit.Name = "btnAuthorExit";
            this.btnAuthorExit.Size = new System.Drawing.Size(161, 75);
            this.btnAuthorExit.TabIndex = 13;
            this.btnAuthorExit.Text = "Thoát";
            this.btnAuthorExit.UseVisualStyleBackColor = true;
            this.btnAuthorExit.Click += new System.EventHandler(this.btnAuthorExit_Click);
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.Location = new System.Drawing.Point(836, 487);
            this.btnAuthorDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(161, 75);
            this.btnAuthorDelete.TabIndex = 12;
            this.btnAuthorDelete.Text = "Xóa";
            this.btnAuthorDelete.UseVisualStyleBackColor = true;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // btnAuthorUpdate
            // 
            this.btnAuthorUpdate.Location = new System.Drawing.Point(592, 487);
            this.btnAuthorUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorUpdate.Name = "btnAuthorUpdate";
            this.btnAuthorUpdate.Size = new System.Drawing.Size(161, 75);
            this.btnAuthorUpdate.TabIndex = 11;
            this.btnAuthorUpdate.Text = "Sửa";
            this.btnAuthorUpdate.UseVisualStyleBackColor = true;
            this.btnAuthorUpdate.Click += new System.EventHandler(this.btnAuthorUpdate_Click);
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Enabled = false;
            this.btnAuthorSave.Location = new System.Drawing.Point(362, 487);
            this.btnAuthorSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(161, 75);
            this.btnAuthorSave.TabIndex = 10;
            this.btnAuthorSave.Text = "Lưu";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Location = new System.Drawing.Point(123, 487);
            this.btnAuthorAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(161, 75);
            this.btnAuthorAdd.TabIndex = 9;
            this.btnAuthorAdd.Text = "Thêm";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAuthorID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(627, 402);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Tác Giả";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Enabled = false;
            this.txtAuthorName.Location = new System.Drawing.Point(176, 236);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(416, 29);
            this.txtAuthorName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Tác Giả :";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Enabled = false;
            this.txtAuthorID.Location = new System.Drawing.Point(176, 142);
            this.txtAuthorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(416, 29);
            this.txtAuthorID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tác Giả  :";
            // 
            // frmManageAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1374, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAuthorExit);
            this.Controls.Add(this.btnAuthorDelete);
            this.Controls.Add(this.btnAuthorUpdate);
            this.Controls.Add(this.btnAuthorSave);
            this.Controls.Add(this.btnAuthorAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageAuthor";
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.frmManageAuthor_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuthorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAuthorList;
        private System.Windows.Forms.Button btnAuthorExit;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.Button btnAuthorUpdate;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsAuthorList;
    }
}