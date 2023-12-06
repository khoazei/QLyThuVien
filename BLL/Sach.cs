using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
	public class Sach
	{
		Database db;
		public Sach()
		{

			db = new Database();
		}
		public DataTable LayDSSach()
		{
			string str = "sp_hienthi";
			DataTable dt = db.Execute(str);
			return dt;
		}
		public void ThemSach(string tensach, string tacgia, int namxuatban, string nhaxuatban, float trigia, DateTime ngaynhap)
		{
			string storeProduce = "sp_themsach";
			string sqlThemNV = string.Format("EXEC {0} @tensach=N'{1}', @tacgia='{2}', @namxuatban=N'{3}', @nhaxuatban='{4}', @trigia='{5}', @ngaynhap='{6}'",
								  storeProduce, tensach, tacgia, namxuatban, nhaxuatban, trigia, ngaynhap);
			db.ExecuteNonQuery(sqlThemNV);

		}
		public void XoaSach(string index)
		{
			string sqlSach = "sp_xoasach";
			db.ExecuteNonQuery(sqlSach, "@masach", index);
		}
		public void CapNhapSach(int index, string tensach, string tacgia, int namxuatban, string nhaxuatban, float trigia, DateTime ngaynhap)
		{

			//Chuẩn bị câu lẹnh truy vấn
			string str = string.Format("update SACH SET TenSach='{0}', TacGia='{1}', NamXuatBan={2}, NhaXuatBan='{3}', TriGia={4}, NgayNhap='{5}' where MaSach={6}", tensach, tacgia, namxuatban, nhaxuatban, trigia, ngaynhap.ToString("yyyy-MM-dd"), index);
			db.ExecuteNonQuery(str);
		}
		public DataTable TimSach(int masach)
		{
			SqlParameter parameter = new SqlParameter("@masach", SqlDbType.Int);
			parameter.Value = masach; // Gán giá trị cho tham số
			DataTable searchResult = db.ExecuteQuery("sp_timsach", parameter);
			return searchResult;
		}
		

	}
}