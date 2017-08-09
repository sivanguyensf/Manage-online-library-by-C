namespace BookManage
{
    partial class frmManageBorrow
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
            this.tabQL = new System.Windows.Forms.TabControl();
            this.tabTraSach = new System.Windows.Forms.TabPage();
            this.grpTraSach = new System.Windows.Forms.GroupBox();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lbSachDocGia = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.txtThoiHanTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSachTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBNTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSachTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachMuon = new System.Windows.Forms.DataGridView();
            this.btnTimKiemDocGia = new System.Windows.Forms.Button();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMuonSach = new System.Windows.Forms.TabPage();
            this.grpMuonSach = new System.Windows.Forms.GroupBox();
            this.btnLamTuoi = new System.Windows.Forms.Button();
            this.dtpNgayTra = new System.Windows.Forms.GroupBox();
            this.lbrecount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnNhapMoiDocGia = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFillDetails = new System.Windows.Forms.Button();
            this.txtMaDocGiaPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPhieuMoi = new System.Windows.Forms.Button();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMaSachMuon = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnChoMuon = new System.Windows.Forms.Button();
            this.dtpNgayTraSach = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.dtpNgayMuonSach = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtISBNMuon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSachMuon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.rdtTacGia = new System.Windows.Forms.RadioButton();
            this.rdtISBN = new System.Windows.Forms.RadioButton();
            this.rdtTenSach = new System.Windows.Forms.RadioButton();
            this.dgvKetQuaTimSach = new System.Windows.Forms.DataGridView();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.tabQL.SuspendLayout();
            this.tabTraSach.SuspendLayout();
            this.grpTraSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMuon)).BeginInit();
            this.tabMuonSach.SuspendLayout();
            this.grpMuonSach.SuspendLayout();
            this.dtpNgayTra.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQL
            // 
            this.tabQL.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabQL.Controls.Add(this.tabTraSach);
            this.tabQL.Controls.Add(this.tabMuonSach);
            this.tabQL.ItemSize = new System.Drawing.Size(107, 35);
            this.tabQL.Location = new System.Drawing.Point(13, 13);
            this.tabQL.Margin = new System.Windows.Forms.Padding(4);
            this.tabQL.Name = "tabQL";
            this.tabQL.SelectedIndex = 0;
            this.tabQL.Size = new System.Drawing.Size(1698, 1200);
            this.tabQL.TabIndex = 1;
            this.tabQL.SelectedIndexChanged += new System.EventHandler(this.tabQL_SelectedIndexChanged);
            // 
            // tabTraSach
            // 
            this.tabTraSach.Controls.Add(this.grpTraSach);
            this.tabTraSach.Location = new System.Drawing.Point(4, 39);
            this.tabTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.tabTraSach.Name = "tabTraSach";
            this.tabTraSach.Padding = new System.Windows.Forms.Padding(4);
            this.tabTraSach.Size = new System.Drawing.Size(1690, 1157);
            this.tabTraSach.TabIndex = 0;
            this.tabTraSach.Text = "Quản lý trả sách";
            this.tabTraSach.UseVisualStyleBackColor = true;
            // 
            // grpTraSach
            // 
            this.grpTraSach.Controls.Add(this.txtMaMuon);
            this.grpTraSach.Controls.Add(this.label23);
            this.grpTraSach.Controls.Add(this.lbSachDocGia);
            this.grpTraSach.Controls.Add(this.btnTraSach);
            this.grpTraSach.Controls.Add(this.txtThoiHanTra);
            this.grpTraSach.Controls.Add(this.label6);
            this.grpTraSach.Controls.Add(this.txtMaSachTra);
            this.grpTraSach.Controls.Add(this.label5);
            this.grpTraSach.Controls.Add(this.txtISBNTra);
            this.grpTraSach.Controls.Add(this.label4);
            this.grpTraSach.Controls.Add(this.txtTenSachTra);
            this.grpTraSach.Controls.Add(this.label3);
            this.grpTraSach.Controls.Add(this.label2);
            this.grpTraSach.Controls.Add(this.dgvDanhSachMuon);
            this.grpTraSach.Controls.Add(this.btnTimKiemDocGia);
            this.grpTraSach.Controls.Add(this.txtMaDocGia);
            this.grpTraSach.Controls.Add(this.label1);
            this.grpTraSach.Location = new System.Drawing.Point(44, 30);
            this.grpTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.grpTraSach.Name = "grpTraSach";
            this.grpTraSach.Padding = new System.Windows.Forms.Padding(4);
            this.grpTraSach.Size = new System.Drawing.Size(1636, 1054);
            this.grpTraSach.TabIndex = 0;
            this.grpTraSach.TabStop = false;
            this.grpTraSach.Text = "Thống kê và quản lý trả sách";
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Location = new System.Drawing.Point(1130, 507);
            this.txtMaMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.ReadOnly = true;
            this.txtMaMuon.Size = new System.Drawing.Size(280, 29);
            this.txtMaMuon.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(965, 512);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 25);
            this.label23.TabIndex = 16;
            this.label23.Text = "Mã mượn";
            // 
            // lbSachDocGia
            // 
            this.lbSachDocGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSachDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSachDocGia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSachDocGia.Location = new System.Drawing.Point(38, 196);
            this.lbSachDocGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSachDocGia.Name = "lbSachDocGia";
            this.lbSachDocGia.Size = new System.Drawing.Size(814, 63);
            this.lbSachDocGia.TabIndex = 14;
            this.lbSachDocGia.Text = "Danh sách sách đang cho mượn";
            this.lbSachDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(1341, 705);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(258, 60);
            this.btnTraSach.TabIndex = 8;
            this.btnTraSach.Text = "Trả sách này";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // txtThoiHanTra
            // 
            this.txtThoiHanTra.Location = new System.Drawing.Point(1130, 594);
            this.txtThoiHanTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiHanTra.Name = "txtThoiHanTra";
            this.txtThoiHanTra.ReadOnly = true;
            this.txtThoiHanTra.Size = new System.Drawing.Size(280, 29);
            this.txtThoiHanTra.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(965, 598);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thời hạn";
            // 
            // txtMaSachTra
            // 
            this.txtMaSachTra.Location = new System.Drawing.Point(1130, 429);
            this.txtMaSachTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSachTra.Name = "txtMaSachTra";
            this.txtMaSachTra.ReadOnly = true;
            this.txtMaSachTra.Size = new System.Drawing.Size(280, 29);
            this.txtMaSachTra.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(965, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã sách";
            // 
            // txtISBNTra
            // 
            this.txtISBNTra.Location = new System.Drawing.Point(1130, 340);
            this.txtISBNTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBNTra.Name = "txtISBNTra";
            this.txtISBNTra.ReadOnly = true;
            this.txtISBNTra.Size = new System.Drawing.Size(280, 29);
            this.txtISBNTra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(965, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ISBN";
            // 
            // txtTenSachTra
            // 
            this.txtTenSachTra.Location = new System.Drawing.Point(1130, 264);
            this.txtTenSachTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSachTra.Name = "txtTenSachTra";
            this.txtTenSachTra.ReadOnly = true;
            this.txtTenSachTra.Size = new System.Drawing.Size(467, 29);
            this.txtTenSachTra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(965, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1176, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin sách";
            // 
            // dgvDanhSachMuon
            // 
            this.dgvDanhSachMuon.AllowUserToAddRows = false;
            this.dgvDanhSachMuon.AllowUserToDeleteRows = false;
            this.dgvDanhSachMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvDanhSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMuon.Location = new System.Drawing.Point(38, 272);
            this.dgvDanhSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachMuon.MultiSelect = false;
            this.dgvDanhSachMuon.Name = "dgvDanhSachMuon";
            this.dgvDanhSachMuon.ReadOnly = true;
            this.dgvDanhSachMuon.RowTemplate.Height = 24;
            this.dgvDanhSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMuon.Size = new System.Drawing.Size(814, 723);
            this.dgvDanhSachMuon.TabIndex = 2;
            // 
            // btnTimKiemDocGia
            // 
            this.btnTimKiemDocGia.Location = new System.Drawing.Point(575, 48);
            this.btnTimKiemDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemDocGia.Name = "btnTimKiemDocGia";
            this.btnTimKiemDocGia.Size = new System.Drawing.Size(153, 60);
            this.btnTimKiemDocGia.TabIndex = 1;
            this.btnTimKiemDocGia.Text = "Tìm kiếm";
            this.btnTimKiemDocGia.UseVisualStyleBackColor = true;
            this.btnTimKiemDocGia.Click += new System.EventHandler(this.btnTimKiemDocGia_Click);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(258, 62);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(246, 29);
            this.txtMaDocGia.TabIndex = 0;
            this.txtMaDocGia.TextChanged += new System.EventHandler(this.txtMaDocGia_TextChanged);
            this.txtMaDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDocGia_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // tabMuonSach
            // 
            this.tabMuonSach.Controls.Add(this.grpMuonSach);
            this.tabMuonSach.Location = new System.Drawing.Point(4, 39);
            this.tabMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.tabMuonSach.Name = "tabMuonSach";
            this.tabMuonSach.Padding = new System.Windows.Forms.Padding(4);
            this.tabMuonSach.Size = new System.Drawing.Size(1690, 1157);
            this.tabMuonSach.TabIndex = 1;
            this.tabMuonSach.Text = "Quản lý mượn sách";
            this.tabMuonSach.UseVisualStyleBackColor = true;
            // 
            // grpMuonSach
            // 
            this.grpMuonSach.Controls.Add(this.btnLamTuoi);
            this.grpMuonSach.Controls.Add(this.dtpNgayTra);
            this.grpMuonSach.Controls.Add(this.groupBox3);
            this.grpMuonSach.Controls.Add(this.btnTimSach);
            this.grpMuonSach.Controls.Add(this.rdtTacGia);
            this.grpMuonSach.Controls.Add(this.rdtISBN);
            this.grpMuonSach.Controls.Add(this.rdtTenSach);
            this.grpMuonSach.Controls.Add(this.dgvKetQuaTimSach);
            this.grpMuonSach.Controls.Add(this.txtTimSach);
            this.grpMuonSach.Location = new System.Drawing.Point(41, 30);
            this.grpMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.grpMuonSach.Name = "grpMuonSach";
            this.grpMuonSach.Padding = new System.Windows.Forms.Padding(4);
            this.grpMuonSach.Size = new System.Drawing.Size(1618, 1054);
            this.grpMuonSach.TabIndex = 2;
            this.grpMuonSach.TabStop = false;
            this.grpMuonSach.Text = "Mượn sách";
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Location = new System.Drawing.Point(1397, 51);
            this.btnLamTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.Size = new System.Drawing.Size(153, 60);
            this.btnLamTuoi.TabIndex = 20;
            this.btnLamTuoi.Text = "Làm tươi";
            this.btnLamTuoi.UseVisualStyleBackColor = true;
            this.btnLamTuoi.Click += new System.EventHandler(this.btnLamTuoi_Click);
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Controls.Add(this.lbrecount);
            this.dtpNgayTra.Controls.Add(this.label25);
            this.dtpNgayTra.Controls.Add(this.btnNhapMoiDocGia);
            this.dtpNgayTra.Controls.Add(this.txtDiaChi);
            this.dtpNgayTra.Controls.Add(this.label19);
            this.dtpNgayTra.Controls.Add(this.txtSDT);
            this.dtpNgayTra.Controls.Add(this.label18);
            this.dtpNgayTra.Controls.Add(this.txtTenDocGia);
            this.dtpNgayTra.Controls.Add(this.label17);
            this.dtpNgayTra.Controls.Add(this.btnFillDetails);
            this.dtpNgayTra.Controls.Add(this.txtMaDocGiaPhieu);
            this.dtpNgayTra.Controls.Add(this.label10);
            this.dtpNgayTra.Location = new System.Drawing.Point(8, 588);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Padding = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra.Size = new System.Drawing.Size(839, 458);
            this.dtpNgayTra.TabIndex = 19;
            this.dtpNgayTra.TabStop = false;
            this.dtpNgayTra.Text = "Thông tin độc giả";
            // 
            // lbrecount
            // 
            this.lbrecount.AutoSize = true;
            this.lbrecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecount.ForeColor = System.Drawing.Color.Red;
            this.lbrecount.Location = new System.Drawing.Point(384, 393);
            this.lbrecount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbrecount.Name = "lbrecount";
            this.lbrecount.Size = new System.Drawing.Size(0, 29);
            this.lbrecount.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(162, 398);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(192, 25);
            this.label25.TabIndex = 30;
            this.label25.Text = "Số sách được mượn:";
            // 
            // btnNhapMoiDocGia
            // 
            this.btnNhapMoiDocGia.Location = new System.Drawing.Point(518, 380);
            this.btnNhapMoiDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapMoiDocGia.Name = "btnNhapMoiDocGia";
            this.btnNhapMoiDocGia.Size = new System.Drawing.Size(136, 60);
            this.btnNhapMoiDocGia.TabIndex = 5;
            this.btnNhapMoiDocGia.Text = "Nhập mới";
            this.btnNhapMoiDocGia.UseVisualStyleBackColor = true;
            this.btnNhapMoiDocGia.Click += new System.EventHandler(this.btnNhapMoiDocGia_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(296, 302);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(357, 29);
            this.txtDiaChi.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(155, 309);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 25);
            this.label19.TabIndex = 21;
            this.label19.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(296, 220);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(357, 29);
            this.txtSDT.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(155, 225);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 25);
            this.label18.TabIndex = 19;
            this.label18.Text = "Số điện thoại";
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(296, 135);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(357, 29);
            this.txtTenDocGia.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(155, 140);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 25);
            this.label17.TabIndex = 17;
            this.label17.Text = "Họ và tên";
            // 
            // btnFillDetails
            // 
            this.btnFillDetails.Location = new System.Drawing.Point(573, 58);
            this.btnFillDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnFillDetails.Name = "btnFillDetails";
            this.btnFillDetails.Size = new System.Drawing.Size(81, 40);
            this.btnFillDetails.TabIndex = 1;
            this.btnFillDetails.Text = ">>";
            this.btnFillDetails.UseVisualStyleBackColor = true;
            this.btnFillDetails.Click += new System.EventHandler(this.btnFillDetails_Click);
            // 
            // txtMaDocGiaPhieu
            // 
            this.txtMaDocGiaPhieu.Location = new System.Drawing.Point(296, 58);
            this.txtMaDocGiaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGiaPhieu.Name = "txtMaDocGiaPhieu";
            this.txtMaDocGiaPhieu.Size = new System.Drawing.Size(246, 29);
            this.txtMaDocGiaPhieu.TabIndex = 0;
            this.txtMaDocGiaPhieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDocGiaPhieu_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã độc giả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPhieuMoi);
            this.groupBox3.Controls.Add(this.txtNXB);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtTheLoai);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtTacGia);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtMaSachMuon);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.btnChoMuon);
            this.groupBox3.Controls.Add(this.dtpNgayTraSach);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtSoluong);
            this.groupBox3.Controls.Add(this.dtpNgayMuonSach);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtISBNMuon);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTenSachMuon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(896, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(698, 891);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // btnPhieuMoi
            // 
            this.btnPhieuMoi.Enabled = false;
            this.btnPhieuMoi.Location = new System.Drawing.Point(220, 788);
            this.btnPhieuMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhieuMoi.Name = "btnPhieuMoi";
            this.btnPhieuMoi.Size = new System.Drawing.Size(153, 60);
            this.btnPhieuMoi.TabIndex = 32;
            this.btnPhieuMoi.Text = "Tạo phiếu mới";
            this.btnPhieuMoi.UseVisualStyleBackColor = true;
            this.btnPhieuMoi.Click += new System.EventHandler(this.btnPhieuMoi_Click);
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(220, 256);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.ReadOnly = true;
            this.txtNXB.Size = new System.Drawing.Size(375, 29);
            this.txtNXB.TabIndex = 30;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(55, 264);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 25);
            this.label27.TabIndex = 31;
            this.label27.Text = "NXB";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(220, 183);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(375, 29);
            this.txtTheLoai.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(55, 190);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 25);
            this.label22.TabIndex = 29;
            this.label22.Text = "Thể loại";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(220, 111);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.Size = new System.Drawing.Size(375, 29);
            this.txtTacGia.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(55, 118);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 25);
            this.label26.TabIndex = 28;
            this.label26.Text = "Tác giả";
            // 
            // txtMaSachMuon
            // 
            this.txtMaSachMuon.Location = new System.Drawing.Point(220, 492);
            this.txtMaSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSachMuon.Name = "txtMaSachMuon";
            this.txtMaSachMuon.Size = new System.Drawing.Size(221, 29);
            this.txtMaSachMuon.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(55, 500);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 25);
            this.label24.TabIndex = 20;
            this.label24.Text = "Nhập độc giả";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 694);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 25);
            this.label21.TabIndex = 25;
            this.label21.Text = "Ngày trả";
            // 
            // btnChoMuon
            // 
            this.btnChoMuon.Location = new System.Drawing.Point(406, 788);
            this.btnChoMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoMuon.Name = "btnChoMuon";
            this.btnChoMuon.Size = new System.Drawing.Size(212, 60);
            this.btnChoMuon.TabIndex = 10;
            this.btnChoMuon.Text = "Thêm vào phiếu";
            this.btnChoMuon.UseVisualStyleBackColor = true;
            this.btnChoMuon.Click += new System.EventHandler(this.btnChoMuon_Click);
            // 
            // dtpNgayTraSach
            // 
            this.dtpNgayTraSach.Location = new System.Drawing.Point(220, 687);
            this.dtpNgayTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTraSach.Name = "dtpNgayTraSach";
            this.dtpNgayTraSach.Size = new System.Drawing.Size(375, 29);
            this.dtpNgayTraSach.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 602);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Ngày mượn";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(220, 414);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.ReadOnly = true;
            this.txtSoluong.Size = new System.Drawing.Size(221, 29);
            this.txtSoluong.TabIndex = 2;
            // 
            // dtpNgayMuonSach
            // 
            this.dtpNgayMuonSach.Location = new System.Drawing.Point(220, 594);
            this.dtpNgayMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuonSach.Name = "dtpNgayMuonSach";
            this.dtpNgayMuonSach.Size = new System.Drawing.Size(375, 29);
            this.dtpNgayMuonSach.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số lượng";
            // 
            // txtISBNMuon
            // 
            this.txtISBNMuon.Location = new System.Drawing.Point(220, 336);
            this.txtISBNMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBNMuon.Name = "txtISBNMuon";
            this.txtISBNMuon.ReadOnly = true;
            this.txtISBNMuon.Size = new System.Drawing.Size(221, 29);
            this.txtISBNMuon.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 344);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "ISBN";
            // 
            // txtTenSachMuon
            // 
            this.txtTenSachMuon.Location = new System.Drawing.Point(220, 33);
            this.txtTenSachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSachMuon.Name = "txtTenSachMuon";
            this.txtTenSachMuon.ReadOnly = true;
            this.txtTenSachMuon.Size = new System.Drawing.Size(375, 29);
            this.txtTenSachMuon.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên Sách";
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(1166, 51);
            this.btnTimSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(153, 60);
            this.btnTimSach.TabIndex = 4;
            this.btnTimSach.Text = "Tìm kiếm";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // rdtTacGia
            // 
            this.rdtTacGia.AutoSize = true;
            this.rdtTacGia.Location = new System.Drawing.Point(953, 68);
            this.rdtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.rdtTacGia.Name = "rdtTacGia";
            this.rdtTacGia.Size = new System.Drawing.Size(102, 29);
            this.rdtTacGia.TabIndex = 3;
            this.rdtTacGia.Tag = "SearchSelection";
            this.rdtTacGia.Text = "Tác giả";
            this.rdtTacGia.UseVisualStyleBackColor = true;
            this.rdtTacGia.Click += new System.EventHandler(this.rdtTacGia_Click);
            // 
            // rdtISBN
            // 
            this.rdtISBN.AutoSize = true;
            this.rdtISBN.Location = new System.Drawing.Point(733, 68);
            this.rdtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.rdtISBN.Name = "rdtISBN";
            this.rdtISBN.Size = new System.Drawing.Size(83, 29);
            this.rdtISBN.TabIndex = 2;
            this.rdtISBN.Tag = "SearchSelection";
            this.rdtISBN.Text = "ISBN";
            this.rdtISBN.UseVisualStyleBackColor = true;
            this.rdtISBN.Click += new System.EventHandler(this.rdtISBN_Click);
            // 
            // rdtTenSach
            // 
            this.rdtTenSach.AutoSize = true;
            this.rdtTenSach.Checked = true;
            this.rdtTenSach.Location = new System.Drawing.Point(509, 66);
            this.rdtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.rdtTenSach.Name = "rdtTenSach";
            this.rdtTenSach.Size = new System.Drawing.Size(119, 29);
            this.rdtTenSach.TabIndex = 1;
            this.rdtTenSach.TabStop = true;
            this.rdtTenSach.Tag = "SearchSelection";
            this.rdtTenSach.Text = "Tên sách";
            this.rdtTenSach.UseVisualStyleBackColor = true;
            this.rdtTenSach.Click += new System.EventHandler(this.rdtTenSach_Click);
            // 
            // dgvKetQuaTimSach
            // 
            this.dgvKetQuaTimSach.AllowUserToAddRows = false;
            this.dgvKetQuaTimSach.AllowUserToDeleteRows = false;
            this.dgvKetQuaTimSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimSach.Location = new System.Drawing.Point(63, 154);
            this.dgvKetQuaTimSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQuaTimSach.MultiSelect = false;
            this.dgvKetQuaTimSach.Name = "dgvKetQuaTimSach";
            this.dgvKetQuaTimSach.ReadOnly = true;
            this.dgvKetQuaTimSach.RowTemplate.Height = 24;
            this.dgvKetQuaTimSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaTimSach.Size = new System.Drawing.Size(784, 390);
            this.dgvKetQuaTimSach.TabIndex = 5;
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(63, 66);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(403, 29);
            this.txtTimSach.TabIndex = 0;
            this.txtTimSach.Text = "Nhập tên sách cần tìm";
            this.txtTimSach.Enter += new System.EventHandler(this.txtTimSach_Enter);
            this.txtTimSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimSach_KeyPress);
            this.txtTimSach.Leave += new System.EventHandler(this.txtTimSach_Leave);
            // 
            // frmManageBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1733, 1634);
            this.Controls.Add(this.tabQL);
            this.Name = "frmManageBorrow";
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.frmManageBorrow_Load);
            this.tabQL.ResumeLayout(false);
            this.tabTraSach.ResumeLayout(false);
            this.grpTraSach.ResumeLayout(false);
            this.grpTraSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMuon)).EndInit();
            this.tabMuonSach.ResumeLayout(false);
            this.grpMuonSach.ResumeLayout(false);
            this.grpMuonSach.PerformLayout();
            this.dtpNgayTra.ResumeLayout(false);
            this.dtpNgayTra.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQL;
        private System.Windows.Forms.TabPage tabTraSach;
        private System.Windows.Forms.GroupBox grpTraSach;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbSachDocGia;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox txtThoiHanTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSachTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBNTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSachTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDanhSachMuon;
        private System.Windows.Forms.Button btnTimKiemDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMuonSach;
        private System.Windows.Forms.GroupBox grpMuonSach;
        private System.Windows.Forms.Button btnLamTuoi;
        private System.Windows.Forms.GroupBox dtpNgayTra;
        private System.Windows.Forms.Label lbrecount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnNhapMoiDocGia;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnFillDetails;
        private System.Windows.Forms.TextBox txtMaDocGiaPhieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPhieuMoi;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMaSachMuon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnChoMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayTraSach;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.DateTimePicker dtpNgayMuonSach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtISBNMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSachMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.RadioButton rdtTacGia;
        private System.Windows.Forms.RadioButton rdtISBN;
        private System.Windows.Forms.RadioButton rdtTenSach;
        private System.Windows.Forms.DataGridView dgvKetQuaTimSach;
        private System.Windows.Forms.TextBox txtTimSach;
    }
}