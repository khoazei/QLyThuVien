namespace QuanLyThuVien
{
	partial class login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			label3 = new Label();
			pictureBox1 = new PictureBox();
			btnExit = new Button();
			btnLogin = new Button();
			label1 = new Label();
			txtPassword = new TextBox();
			txtUsername = new TextBox();
			button2 = new Button();
			button1 = new Button();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(0, 0, 64);
			label3.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(14, 288);
			label3.Name = "label3";
			label3.Size = new Size(289, 79);
			label3.TabIndex = 18;
			label3.Text = "Thu Vien";
			label3.Click += label3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.BackColor = Color.FromArgb(0, 0, 64);
			pictureBox1.Location = new Point(-4, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(324, 563);
			pictureBox1.TabIndex = 17;
			pictureBox1.TabStop = false;
			// 
			// btnExit
			// 
			btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnExit.BackColor = Color.FromArgb(192, 192, 255);
			btnExit.Font = new Font("Microsoft Sans Serif", 16.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnExit.Location = new Point(607, 409);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(177, 77);
			btnExit.TabIndex = 3;
			btnExit.Text = "Thoát";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			// 
			// btnLogin
			// 
			btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnLogin.BackColor = Color.FromArgb(192, 192, 255);
			btnLogin.Font = new Font("Microsoft Sans Serif", 16.8F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogin.ForeColor = SystemColors.ActiveCaptionText;
			btnLogin.Location = new Point(373, 409);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(193, 77);
			btnLogin.TabIndex = 2;
			btnLogin.Text = "Đăng nhập";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(0, 0, 64);
			label1.Location = new Point(389, 55);
			label1.Name = "label1";
			label1.Size = new Size(394, 69);
			label1.TabIndex = 14;
			label1.Text = "ĐĂNG NHẬP";
			// 
			// txtPassword
			// 
			txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtPassword.Font = new Font("Microsoft Sans Serif", 16.8F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(448, 300);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(297, 39);
			txtPassword.TabIndex = 1;
			// 
			// txtUsername
			// 
			txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtUsername.Font = new Font("Microsoft Sans Serif", 16.8F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.Location = new Point(448, 209);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(297, 39);
			txtUsername.TabIndex = 0;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button2.BackgroundImageLayout = ImageLayout.Zoom;
			button2.Enabled = false;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.Location = new Point(373, 209);
			button2.Name = "button2";
			button2.Size = new Size(45, 49);
			button2.TabIndex = 11;
			button2.TextImageRelation = TextImageRelation.ImageAboveText;
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button1.Enabled = false;
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.Location = new Point(373, 300);
			button1.Name = "button1";
			button1.Size = new Size(45, 49);
			button1.TabIndex = 10;
			button1.TabStop = false;
			button1.TextImageRelation = TextImageRelation.ImageAboveText;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb(0, 0, 64);
			label2.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(30, 209);
			label2.Name = "label2";
			label2.Size = new Size(273, 79);
			label2.TabIndex = 19;
			label2.Text = "Quan Ly";
			// 
			// login
			// 
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 563);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(pictureBox1);
			Controls.Add(btnExit);
			Controls.Add(btnLogin);
			Controls.Add(label1);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "login";
			Text = "Đăng nhập";
			FormClosing += login_FormClosing;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private PictureBox pictureBox1;
		private Button btnExit;
		private Button btnLogin;
		private Label label1;
		private TextBox txtPassword;
		private TextBox txtUsername;
		private Button button2;
		private Button button1;
		private Label label2;
	}
}

