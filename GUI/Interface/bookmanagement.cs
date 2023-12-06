using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
	public partial class frmQuanLy : Form
	{
		public bool ThemMoi = false;
		Sach isach = new Sach();
		public frmQuanLy()
		{
			InitializeComponent();
		}

		private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát ứng dụng", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			HienThiDanhSachBook();
		}
		public void HienThiDanhSachBook()
		{
			lstsach.Items.Clear();
			DataTable dataTablesach = isach.LayDSSach();
			for (int i = 0; i < dataTablesach.Rows.Count; i++)
			{
				ListViewItem k = lstsach.Items.Add(dataTablesach.Rows[i][0].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][1].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][2].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][3].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][4].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][5].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][6].ToString());
			}
		}
		void setButton(bool val)
		{
			btnThem.Enabled = val;
			btnXoa.Enabled = val;
			btnSua.Enabled = val;
			btnThoat.Enabled = val;
			btnLuu.Enabled = !val;
			btnHuy.Enabled = !val;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			ThemMoi = true;
			setButton(false);
			txtTenSach.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			//DateTime ngay = dtpNgayNhap.Value.ToString("MM/dd/yyyy");
			if (ThemMoi)
			{
				int namXuatBan;
				if (int.TryParse(txtNamXuatBan.Text, out namXuatBan))
				{
					// Dữ liệu hợp lệ, có thể chuyển đổi thành số nguyên.
					// Tiếp tục xử lý ở đây.
					float triGia;
					if (float.TryParse(txtTriGia.Text, out triGia))
					{
						// Dữ liệu hợp lệ, có thể chuyển đổi thành số thực.
						// Tiếp tục xử lý ở đây.
						// Gọi hàm ThemSach và truyền các giá trị đã kiểm tra.
						isach.ThemSach(txtTenSach.Text, txtTacgia.Text, namXuatBan,txtNhaXuatBan.Text, triGia, DateTime.ParseExact(dtpNgayNhap.Value.ToString("dd/MM/yyyy").ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture));
					}
					else
					{
						// Hiển thị thông báo lỗi hoặc thực hiện xử lý khác khi triGia không hợp lệ.
						MessageBox.Show("Giá trị tri giá không hợp lệ.");
					}
				}
				else
				{
					// Hiển thị thông báo lỗi hoặc thực hiện xử lý khác khi namXuatBan không hợp lệ.
					MessageBox.Show("Năm xuất bản không hợp lệ.");
				}
			}
			else
			{




				// Các dòng tiếp theo tương tự

				DateTime ngaynhap = dtpNgayNhap.Value;
				float trigia;
				if (float.TryParse(txtTriGia.Text, out trigia))
				{
					string tensach = txtTenSach.Text;
					string tacgia = txtTacgia.Text;
					int namxuatban = int.Parse(txtNamXuatBan.Text);
					string nhaxuatban = txtTacgia.Text;
					// Gọi phương thức cập nhật sách
					isach.CapNhapSach(int.Parse(lstsach.SelectedItems[0].SubItems[0].Text), tensach, tacgia, namxuatban, nhaxuatban, trigia, ngaynhap);
				}
				else
				{
					// Hiển thị thông báo lỗi hoặc thực hiện xử lý phù hợp
					MessageBox.Show("Giá trị nhập vào không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


				// Sau khi cập nhật xong, thiết lập trạng thái để cho phép thêm mới
				setButton(true);
				MessageBox.Show("Cập Nhập Thành Công");

			}
			HienThiDanhSachBook();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lstsach.SelectedIndices.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Bạn Có Chắc Muốn Xóa Bằng Cấp Không ", "Xóa Bằng Cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					isach.XoaSach(lstsach.SelectedItems[0].SubItems[0].Text);
					lstsach.Items.RemoveAt(lstsach.SelectedIndices[0]);
					MessageBox.Show("Xóa Thành Công");
				}

			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (lstsach.SelectedIndices.Count > 0)
			{
				// Lấy thông tin từ ListView và hiển thị lên các TextBox và DateTimePicker
				txtTenSach.Text = lstsach.SelectedItems[0].SubItems[1].Text;
				txtTacgia.Text = lstsach.SelectedItems[0].SubItems[2].Text;
				txtNamXuatBan.Text = lstsach.SelectedItems[0].SubItems[3].Text;
				txtNhaXuatBan.Text = lstsach.SelectedItems[0].SubItems[4].Text;
				txtTriGia.Text = lstsach.SelectedItems[0].SubItems[5].Text;
				// Các dòng tiếp theo tương tự

				// Nếu có thông tin ngày nhập, thiết lập giá trị cho DateTimePicker
				if (lstsach.SelectedItems[0].SubItems.Count > 7)
				{
					dtpNgayNhap.Value = DateTime.ParseExact(lstsach.SelectedItems[0].SubItems[6].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
				}

				// Thiết lập trạng thái để cho phép cập nhật
				ThemMoi = false;
				setButton(false);
			}
			else
			{
				MessageBox.Show("Bạn phải chọn mẩu tin cập nhật", "Sửa mẩu tin");
			}

		}

		//private void lstsach_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//    if (lstsach.SelectedIndices.Count > 0)
		//    {
		//        txtTenSach.Text = lstsach.SelectedItems[0].SubItems[1].Text;
		//        txtMaTacGia.Text = lstsach.SelectedItems[0].SubItems[2].Text;
		//        txtNamXuatBan.Text = lstsach.SelectedItems[0].SubItems[3].Text;
		//        txtMaNXB.Text = lstsach.SelectedItems[0].SubItems[4].Text;
		//        txtLoai.Text = lstsach.SelectedItems[0].SubItems[5].Text;
		//        txtTriGia.Text = lstsach.SelectedItems[0].SubItems[6].Text;
		//        if (lstsach.SelectedItems[0].SubItems.Count > 7)
		//        {
		//            dtpNgayNhap.Value = DateTime.ParseExact(lstsach.SelectedItems[0].SubItems[7].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
		//        }
		//        else
		//        {

		//        }

		//    }
		//}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			setButton(true);
		}

	}
}
