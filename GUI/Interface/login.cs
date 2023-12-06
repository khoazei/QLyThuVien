using BLL;

namespace QuanLyThuVien
{
	public partial class login : Form
	{
		Login lg = new Login();
		public login()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			manager manager = new manager();
			string taiKhoan = txtUsername.Text;
			string matKhau = txtPassword.Text;
			if (lg.CheckLogin(taiKhoan, matKhau) == true)
			{
				MessageBox.Show("Đăng Nhập Thành Công");
				this.Hide();
				manager.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu");
			}
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
	}
}