using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
	public partial class searchbook : Form
	{
		Sach sach = new Sach();
		public searchbook()
		{
			InitializeComponent();
		}

		private void searchbook_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát ứng dụng", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
		public void HienThiSach()
		{
			DataTable dataTablebook = sach.LayDSSach();
			for (int i = 0; i < dataTablebook.Rows.Count; i++)
			{
				ListViewItem lvibook = lstbook.Items.Add(dataTablebook.Rows[i][0].ToString());
				lvibook.SubItems.Add(dataTablebook.Rows[i][1].ToString());
				lvibook.SubItems.Add(dataTablebook.Rows[i][2].ToString());
				lvibook.SubItems.Add(dataTablebook.Rows[i][3].ToString());
				lvibook.SubItems.Add(dataTablebook.Rows[i][4].ToString());
				lvibook.SubItems.Add(dataTablebook.Rows[i][5].ToString());
				lvibook.SubItems.Add(dataTablebook.Rows[i][6].ToString());


			}
		}
		private void searchbook_Load(object sender, EventArgs e)
		{

			HienThiSach();
		}

		private void lstbook_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtTimbook.Text, out int masach))
			{
				// Gọi phương thức TimSach từ lớp xử lý dữ liệu
				DataTable searchResult = sach.TimSach(masach);

				// Xóa dữ liệu cũ trong ListView
				lstbook.Items.Clear();

				// Kiểm tra kết quả và hiển thị thông báo cho người dùng
				if (searchResult.Rows.Count > 0)
				{

					// Hiển thị kết quả tìm kiếm trong ListView
					foreach (DataRow row in searchResult.Rows)
					{
						ListViewItem lvibook = lstbook.Items.Add(row[0].ToString());
						lvibook.SubItems.Add(row[1].ToString());
						lvibook.SubItems.Add(row[2].ToString());
						lvibook.SubItems.Add(row[3].ToString());
						lvibook.SubItems.Add(row[4].ToString());
						lvibook.SubItems.Add(row[5].ToString());
						lvibook.SubItems.Add(row[6].ToString());
					}

				}
				else
				{
					MessageBox.Show("Không tìm thấy sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

