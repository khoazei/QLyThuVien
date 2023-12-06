namespace QuanLyThuVien
{
	partial class searchbook
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
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			panel6 = new Panel();
			panel8 = new Panel();
			panel9 = new Panel();
			panel10 = new Panel();
			label2 = new Label();
			panel2 = new Panel();
			lstbook = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			panel4 = new Panel();
			btnTimKiem = new Button();
			groupBox1 = new GroupBox();
			txtTimbook = new TextBox();
			label8 = new Label();
			panel3 = new Panel();
			eventLog1 = new System.Diagnostics.EventLog();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			contextMenuStrip1 = new ContextMenuStrip(components);
			btnThoat = new Button();
			panel1.SuspendLayout();
			panel6.SuspendLayout();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)eventLog1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Cyan;
			panel1.Controls.Add(panel6);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.ForeColor = SystemColors.ControlText;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1129, 77);
			panel1.TabIndex = 0;
			// 
			// panel6
			// 
			panel6.Controls.Add(panel8);
			panel6.Controls.Add(panel9);
			panel6.Controls.Add(panel10);
			panel6.Dock = DockStyle.Right;
			panel6.Location = new Point(985, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(144, 77);
			panel6.TabIndex = 8;
			// 
			// panel8
			// 
			panel8.Dock = DockStyle.Fill;
			panel8.Location = new Point(84, 0);
			panel8.Name = "panel8";
			panel8.Size = new Size(60, 60);
			panel8.TabIndex = 2;
			// 
			// panel9
			// 
			panel9.Dock = DockStyle.Left;
			panel9.Location = new Point(0, 0);
			panel9.Name = "panel9";
			panel9.Size = new Size(84, 60);
			panel9.TabIndex = 1;
			// 
			// panel10
			// 
			panel10.Dock = DockStyle.Bottom;
			panel10.Location = new Point(0, 60);
			panel10.Name = "panel10";
			panel10.Size = new Size(144, 17);
			panel10.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Navy;
			label2.Location = new Point(99, 18);
			label2.Name = "label2";
			label2.Size = new Size(705, 58);
			label2.TabIndex = 1;
			label2.Text = "TRA CỨU THÔNG TIN MƯỢN SÁCH";
			// 
			// panel2
			// 
			panel2.BackColor = Color.Azure;
			panel2.Controls.Add(lstbook);
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Fill;
			panel2.ForeColor = Color.SlateBlue;
			panel2.Location = new Point(0, 77);
			panel2.Name = "panel2";
			panel2.Size = new Size(1129, 587);
			panel2.TabIndex = 1;
			// 
			// lstbook
			// 
			lstbook.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
			lstbook.GridLines = true;
			lstbook.Location = new Point(3, 251);
			lstbook.Name = "lstbook";
			lstbook.Size = new Size(984, 258);
			lstbook.TabIndex = 7;
			lstbook.UseCompatibleStateImageBehavior = false;
			lstbook.View = View.Details;
			lstbook.SelectedIndexChanged += lstbook_SelectedIndexChanged;
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
			// panel4
			// 
			panel4.Controls.Add(btnThoat);
			panel4.Controls.Add(btnTimKiem);
			panel4.Controls.Add(groupBox1);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(1129, 227);
			panel4.TabIndex = 6;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(732, 184);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(108, 39);
			btnTimKiem.TabIndex = 2;
			btnTimKiem.Text = "Tìm Sách";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.LavenderBlush;
			groupBox1.Controls.Add(txtTimbook);
			groupBox1.Controls.Add(label8);
			groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.FromArgb(192, 0, 0);
			groupBox1.Location = new Point(229, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(488, 217);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Tìm kiếm";
			// 
			// txtTimbook
			// 
			txtTimbook.BorderStyle = BorderStyle.FixedSingle;
			txtTimbook.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtTimbook.Location = new Point(6, 115);
			txtTimbook.Name = "txtTimbook";
			txtTimbook.Size = new Size(476, 32);
			txtTimbook.TabIndex = 0;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Calibri Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = Color.FromArgb(0, 0, 64);
			label8.ImageAlign = ContentAlignment.MiddleLeft;
			label8.Location = new Point(6, 64);
			label8.Name = "label8";
			label8.Size = new Size(189, 28);
			label8.TabIndex = 1;
			label8.Text = "Tìm kiếm Mã Sách :";
			// 
			// panel3
			// 
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 577);
			panel3.Name = "panel3";
			panel3.Size = new Size(1129, 10);
			panel3.TabIndex = 4;
			// 
			// eventLog1
			// 
			eventLog1.SynchronizingObject = this;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(865, 184);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 39);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// searchbook
			// 
			ClientSize = new Size(1129, 664);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "searchbook";
			FormClosing += searchbook_FormClosing;
			Load += searchbook_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel6.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)eventLog1).EndInit();
			ResumeLayout(false);
		}

		#endregion


		private Panel panel1;
		private Label label2;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private Panel panel2;
		private System.Diagnostics.EventLog eventLog1;
		private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
		private GroupBox groupBox1;
		private TextBox txtTimbook;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ContextMenuStrip contextMenuStrip1;
		private Bunifu.Framework.UI.BunifuImageButton btnDesSort;
		private Bunifu.Framework.UI.BunifuImageButton btnAscSort;
		private Panel panel3;
		private Panel panel4;
		private Label label8;
		private Bunifu.Framework.UI.BunifuFlatButton btnCustomerInformation;
		private Panel panel6;
		private Panel panel8;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private Panel panel9;
		private Panel panel10;
		private Bunifu.Framework.UI.BunifuImageButton btnSearch;
		private Bunifu.Framework.UI.BunifuImageButton btnCustomerRemove;
		private Bunifu.Framework.UI.BunifuFlatButton btnCustomerExpired;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
		private ListView lstbook;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private Button btnTimKiem;
		private Button btnThoat;
	}
}