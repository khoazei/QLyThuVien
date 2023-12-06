namespace GUI.Interface
{
	partial class frmDocgia
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
			label1 = new Label();
			lstDocgia = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			btnThoat = new Button();
			btnLuu = new Button();
			btnHuy = new Button();
			label2 = new Label();
			txtName = new TextBox();
			label3 = new Label();
			label4 = new Label();
			txtDiaChi = new TextBox();
			label5 = new Label();
			txtEmail = new TextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			txtNo = new TextBox();
			dtpNgaysinh = new DateTimePicker();
			dtpNgaylapthe = new DateTimePicker();
			dtpNgayHethan = new DateTimePicker();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(435, -10);
			label1.Name = "label1";
			label1.Size = new Size(506, 81);
			label1.TabIndex = 0;
			label1.Text = "Quản Lý Độc Giả";
			// 
			// lstDocgia
			// 
			lstDocgia.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
			lstDocgia.GridLines = true;
			lstDocgia.Location = new Point(88, 366);
			lstDocgia.Name = "lstDocgia";
			lstDocgia.Size = new Size(934, 349);
			lstDocgia.TabIndex = 2;
			lstDocgia.UseCompatibleStateImageBehavior = false;
			lstDocgia.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Mã Độc Giả";
			columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Họ Tên Độc Giả";
			columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Ngày Sinh";
			columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Địa Chỉ";
			columnHeader4.Width = 120;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Email";
			columnHeader5.Width = 120;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Ngày Lập Thẻ";
			columnHeader6.Width = 120;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Ngày Hết Hạn";
			columnHeader7.Width = 120;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Tiền Nợ";
			columnHeader8.Width = 120;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(1144, 94);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(159, 34);
			btnThem.TabIndex = 3;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(1144, 169);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(159, 29);
			btnXoa.TabIndex = 4;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(1144, 230);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(159, 29);
			btnSua.TabIndex = 5;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(1144, 300);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(159, 29);
			btnThoat.TabIndex = 6;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			// 
			// btnLuu
			// 
			btnLuu.Location = new Point(1144, 366);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(159, 29);
			btnLuu.TabIndex = 7;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			// 
			// btnHuy
			// 
			btnHuy.Location = new Point(1144, 433);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(159, 29);
			btnHuy.TabIndex = 8;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(56, 39);
			label2.Name = "label2";
			label2.Size = new Size(96, 20);
			label2.TabIndex = 0;
			label2.Text = "Tên Độc Giả :";
			// 
			// txtName
			// 
			txtName.Location = new Point(158, 36);
			txtName.Name = "txtName";
			txtName.Size = new Size(176, 27);
			txtName.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(69, 101);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 3;
			label3.Text = "Ngày Sinh :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(405, 41);
			label4.Name = "label4";
			label4.Size = new Size(64, 20);
			label4.TabIndex = 4;
			label4.Text = "Địa Chỉ :";
			// 
			// txtDiaChi
			// 
			txtDiaChi.Location = new Point(481, 36);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(186, 27);
			txtDiaChi.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(405, 98);
			label5.Name = "label5";
			label5.Size = new Size(53, 20);
			label5.TabIndex = 6;
			label5.Text = "Email :";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(481, 94);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(186, 27);
			txtEmail.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(45, 168);
			label6.Name = "label6";
			label6.Size = new Size(107, 20);
			label6.TabIndex = 8;
			label6.Text = "Ngày Lập Thẻ :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(348, 164);
			label7.Name = "label7";
			label7.Size = new Size(110, 20);
			label7.TabIndex = 10;
			label7.Text = "Ngày Hết Hạn :";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(702, 35);
			label8.Name = "label8";
			label8.Size = new Size(68, 20);
			label8.TabIndex = 12;
			label8.Text = "Tiền Nợ :";
			// 
			// txtNo
			// 
			txtNo.Location = new Point(776, 35);
			txtNo.Name = "txtNo";
			txtNo.Size = new Size(178, 27);
			txtNo.TabIndex = 13;
			// 
			// dtpNgaysinh
			// 
			dtpNgaysinh.Location = new Point(158, 98);
			dtpNgaysinh.Name = "dtpNgaysinh";
			dtpNgaysinh.Size = new Size(176, 27);
			dtpNgaysinh.TabIndex = 14;
			// 
			// dtpNgaylapthe
			// 
			dtpNgaylapthe.Location = new Point(158, 163);
			dtpNgaylapthe.Name = "dtpNgaylapthe";
			dtpNgaylapthe.Size = new Size(176, 27);
			dtpNgaylapthe.TabIndex = 15;
			// 
			// dtpNgayHethan
			// 
			dtpNgayHethan.Location = new Point(481, 163);
			dtpNgayHethan.Name = "dtpNgayHethan";
			dtpNgayHethan.Size = new Size(186, 27);
			dtpNgayHethan.TabIndex = 16;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dtpNgayHethan);
			groupBox1.Controls.Add(dtpNgaylapthe);
			groupBox1.Controls.Add(dtpNgaysinh);
			groupBox1.Controls.Add(txtNo);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(txtName);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(88, 95);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(967, 234);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quản Lý Độc Giả";
			// 
			// frmDocgia
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1413, 727);
			Controls.Add(btnHuy);
			Controls.Add(btnLuu);
			Controls.Add(btnThoat);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(lstDocgia);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "frmDocgia";
			Text = "QuanLyDocGia";
			Load += frmDocgia_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ListView lstDocgia;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThoat;
		private Button btnLuu;
		private Button btnHuy;
		private Label label2;
		private TextBox txtName;
		private Label label3;
		private Label label4;
		private TextBox txtDiaChi;
		private Label label5;
		private TextBox txtEmail;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox txtNo;
		private DateTimePicker dtpNgaysinh;
		private DateTimePicker dtpNgaylapthe;
		private DateTimePicker dtpNgayHethan;
		private GroupBox groupBox1;
	}
}