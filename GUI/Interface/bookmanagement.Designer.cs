
namespace QuanLyThuVien
{
	partial class frmQuanLy
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			grpTimKiemSach = new GroupBox();
			grpCapNhat = new GroupBox();
			dtpNgayNhap = new DateTimePicker();
			label2 = new Label();
			label1 = new Label();
			txtTriGia = new TextBox();
			txtNhaXuatBan = new TextBox();
			txtNamXuatBan = new TextBox();
			btnHuy = new Button();
			btnLuu = new Button();
			btnThoat = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			txtTacgia = new TextBox();
			txtTenSach = new TextBox();
			lblMaTheLoai = new Label();
			lblNamXB = new Label();
			lblMaNXB = new Label();
			lblTenSach = new Label();
			lstsach = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			grpCapNhat.SuspendLayout();
			SuspendLayout();
			// 
			// grpTimKiemSach
			// 
			grpTimKiemSach.BackColor = SystemColors.GradientActiveCaption;
			grpTimKiemSach.Location = new Point(14, 16);
			grpTimKiemSach.Margin = new Padding(3, 4, 3, 4);
			grpTimKiemSach.Name = "grpTimKiemSach";
			grpTimKiemSach.Padding = new Padding(3, 4, 3, 4);
			grpTimKiemSach.Size = new Size(1197, 133);
			grpTimKiemSach.TabIndex = 0;
			grpTimKiemSach.TabStop = false;
			grpTimKiemSach.Text = "Quản Lý Sách";
			// 
			// grpCapNhat
			// 
			grpCapNhat.Controls.Add(dtpNgayNhap);
			grpCapNhat.Controls.Add(label2);
			grpCapNhat.Controls.Add(label1);
			grpCapNhat.Controls.Add(txtTriGia);
			grpCapNhat.Controls.Add(txtNhaXuatBan);
			grpCapNhat.Controls.Add(txtNamXuatBan);
			grpCapNhat.Controls.Add(btnHuy);
			grpCapNhat.Controls.Add(btnLuu);
			grpCapNhat.Controls.Add(btnThoat);
			grpCapNhat.Controls.Add(btnXoa);
			grpCapNhat.Controls.Add(btnSua);
			grpCapNhat.Controls.Add(btnThem);
			grpCapNhat.Controls.Add(txtTacgia);
			grpCapNhat.Controls.Add(txtTenSach);
			grpCapNhat.Controls.Add(lblMaTheLoai);
			grpCapNhat.Controls.Add(lblNamXB);
			grpCapNhat.Controls.Add(lblMaNXB);
			grpCapNhat.Controls.Add(lblTenSach);
			grpCapNhat.Location = new Point(14, 171);
			grpCapNhat.Margin = new Padding(3, 4, 3, 4);
			grpCapNhat.Name = "grpCapNhat";
			grpCapNhat.Padding = new Padding(3, 4, 3, 4);
			grpCapNhat.Size = new Size(1197, 213);
			grpCapNhat.TabIndex = 1;
			grpCapNhat.TabStop = false;
			grpCapNhat.Text = "Cập nhật";
			// 
			// dtpNgayNhap
			// 
			dtpNgayNhap.Location = new Point(968, 31);
			dtpNgayNhap.Name = "dtpNgayNhap";
			dtpNgayNhap.Size = new Size(223, 27);
			dtpNgayNhap.TabIndex = 22;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(862, 38);
			label2.Name = "label2";
			label2.Size = new Size(91, 20);
			label2.TabIndex = 21;
			label2.Text = "Ngày Nhập :";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(610, 96);
			label1.Name = "label1";
			label1.Size = new Size(58, 20);
			label1.TabIndex = 20;
			label1.Text = "Trị Giá :";
			// 
			// txtTriGia
			// 
			txtTriGia.BorderStyle = BorderStyle.FixedSingle;
			txtTriGia.Location = new Point(702, 89);
			txtTriGia.Name = "txtTriGia";
			txtTriGia.Size = new Size(154, 27);
			txtTriGia.TabIndex = 19;
			// 
			// txtNhaXuatBan
			// 
			txtNhaXuatBan.BorderStyle = BorderStyle.FixedSingle;
			txtNhaXuatBan.Location = new Point(702, 34);
			txtNhaXuatBan.Name = "txtNhaXuatBan";
			txtNhaXuatBan.Size = new Size(154, 27);
			txtNhaXuatBan.TabIndex = 18;
			// 
			// txtNamXuatBan
			// 
			txtNamXuatBan.BorderStyle = BorderStyle.FixedSingle;
			txtNamXuatBan.Location = new Point(414, 89);
			txtNamXuatBan.Name = "txtNamXuatBan";
			txtNamXuatBan.Size = new Size(151, 27);
			txtNamXuatBan.TabIndex = 16;
			// 
			// btnHuy
			// 
			btnHuy.Location = new Point(771, 161);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(94, 29);
			btnHuy.TabIndex = 15;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(634, 158);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 29);
			btnLuu.TabIndex = 14;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnThoat
			// 
			btnThoat.BackColor = SystemColors.Info;
			btnThoat.Location = new Point(502, 159);
			btnThoat.Margin = new Padding(3, 4, 3, 4);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(91, 31);
			btnThoat.TabIndex = 13;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			btnXoa.BackColor = SystemColors.Info;
			btnXoa.Location = new Point(214, 158);
			btnXoa.Margin = new Padding(3, 4, 3, 4);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(91, 31);
			btnXoa.TabIndex = 12;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = false;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.BackColor = SystemColors.Info;
			btnSua.Location = new Point(365, 156);
			btnSua.Margin = new Padding(3, 4, 3, 4);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(91, 31);
			btnSua.TabIndex = 11;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = false;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.BackColor = SystemColors.Info;
			btnThem.Location = new Point(62, 159);
			btnThem.Margin = new Padding(3, 4, 3, 4);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(91, 31);
			btnThem.TabIndex = 4;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = false;
			btnThem.Click += btnThem_Click;
			// 
			// txtTacgia
			// 
			txtTacgia.BorderStyle = BorderStyle.FixedSingle;
			txtTacgia.Location = new Point(411, 37);
			txtTacgia.Margin = new Padding(3, 4, 3, 4);
			txtTacgia.Name = "txtTacgia";
			txtTacgia.Size = new Size(154, 27);
			txtTacgia.TabIndex = 7;
			// 
			// txtTenSach
			// 
			txtTenSach.BorderStyle = BorderStyle.FixedSingle;
			txtTenSach.Location = new Point(111, 41);
			txtTenSach.Margin = new Padding(3, 4, 3, 4);
			txtTenSach.Name = "txtTenSach";
			txtTenSach.Size = new Size(154, 27);
			txtTenSach.TabIndex = 6;
			// 
			// lblMaTheLoai
			// 
			lblMaTheLoai.AutoSize = true;
			lblMaTheLoai.Location = new Point(597, 37);
			lblMaTheLoai.Name = "lblMaTheLoai";
			lblMaTheLoai.Size = new Size(106, 20);
			lblMaTheLoai.TabIndex = 4;
			lblMaTheLoai.Text = "Nhà Xuất Bản :";
			// 
			// lblNamXB
			// 
			lblNamXB.AutoSize = true;
			lblNamXB.Location = new Point(286, 91);
			lblNamXB.Name = "lblNamXB";
			lblNamXB.Size = new Size(111, 20);
			lblNamXB.TabIndex = 3;
			lblNamXB.Text = "Năm Xuất Bản :";
			// 
			// lblMaNXB
			// 
			lblMaNXB.AutoSize = true;
			lblMaNXB.Location = new Point(286, 41);
			lblMaNXB.Name = "lblMaNXB";
			lblMaNXB.Size = new Size(63, 20);
			lblMaNXB.TabIndex = 2;
			lblMaNXB.Text = "Tác Giả :";
			// 
			// lblTenSach
			// 
			lblTenSach.AutoSize = true;
			lblTenSach.Location = new Point(17, 43);
			lblTenSach.Name = "lblTenSach";
			lblTenSach.Size = new Size(74, 20);
			lblTenSach.TabIndex = 1;
			lblTenSach.Text = "Tên Sách :";
			// 
			// lstsach
			// 
			lstsach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
			lstsach.FullRowSelect = true;
			lstsach.GridLines = true;
			lstsach.Location = new Point(87, 411);
			lstsach.Name = "lstsach";
			lstsach.Size = new Size(978, 299);
			lstsach.TabIndex = 8;
			lstsach.UseCompatibleStateImageBehavior = false;
			lstsach.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Mã sách";
			columnHeader1.Width = 140;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Tên Sách";
			columnHeader2.Width = 140;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Tác Giả";
			columnHeader3.Width = 140;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Năm Xuất Bản";
			columnHeader4.Width = 140;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Nhà Xuất Bản";
			columnHeader5.Width = 140;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Trị Giá";
			columnHeader6.Width = 140;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Ngày Nhập";
			columnHeader7.Width = 140;
			// 
			// frmQuanLy
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 192);
			ClientSize = new Size(1235, 741);
			Controls.Add(lstsach);
			Controls.Add(grpCapNhat);
			Controls.Add(grpTimKiemSach);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmQuanLy";
			Text = "Quản lý sách";
			FormClosing += frmQuanLy_FormClosing;
			Load += frmQuanLy_Load;
			grpCapNhat.ResumeLayout(false);
			grpCapNhat.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpTimKiemSach;
		private GroupBox grpCapNhat;
		private TextBox txtTacgia;
		private TextBox txtTenSach;
		private Label lblMaTheLoai;
		private Label lblNamXB;
		private Label lblMaNXB;
		private Label lblTenSach;
		private Button btnThoat;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
		private ListView lstsach;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private Button btnLuu;
		private Button btnHuy;
		private TextBox txtNhaXuatBan;
		private TextBox txtNamXuatBan;
		private Label label1;
		private TextBox txtTriGia;
		private Label label2;
		private DateTimePicker dtpNgayNhap;
	}
}

