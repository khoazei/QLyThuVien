using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class CrudDocGia
	{
          DocGia dg=new DocGia();
		Database db=new Database();
		public DataTable LayDSDocGia()
		{
			string str = "sp_laydulieudocgia";
			DataTable dt = db.Execute(str);
			return dt;
		}
		public void ThemDocGia(string tendocgia, string ngaysinh, int diachi, string email, DateTime ngaylapthe, DateTime ngaynhap)
		{
			string storeProduce = "sp_themsach";
			string sqlThemNV = string.Format("EXEC {0} @tensach=N'{1}', @tacgia='{2}', @namxuatban=N'{3}', @nhaxuatban='{4}', @trigia='{5}', @ngaynhap='{6}'",
								  storeProduce, dg.TenDocGia, dg.NgaySinh,dg.DiaChi,dg.Email,dg.NgayLapThe,dg.NgayHetHan,dg.TienNo);
			db.ExecuteNonQuery(sqlThemNV);

		}
	}
}
