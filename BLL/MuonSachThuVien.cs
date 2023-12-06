using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class MuonSachThuVien
	{
		public Database db=new Database();
		public void MuonSach(int maDocGia, DateTime ngayMuon, int maSach)
		{
			try
			{
				db.ExecuteNonQuery("sp_muonsach",
					new SqlParameter("@MaDocGia", maDocGia),
					new SqlParameter("@NgayMuon", ngayMuon),
					new SqlParameter("@MaSach", maSach));

				Console.WriteLine("Mượn sách thành công.");
			}
			catch (Exception ex)
			{
				db.LogError($"Error executing MuonSach: {ex.Message}");
			}
		}
	}
}
