using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
	public class Login
	{
		Database db=new Database();
		public bool CheckLogin(string username, string password)
		{
			string query = "sp_login";
			SqlParameter[] parameters =
			{
			new SqlParameter("@taikhoan", username),
			new SqlParameter("@matkhau", password)
			};

			DataTable resultTable = db.ExecuteQuery(query, parameters);

			if (resultTable.Rows.Count > 0)
			{
				// Có ít nhất một bản ghi, đăng nhập thành công
				return true;
			}
			else
			{
				// Không có bản ghi nào, đăng nhập thất bại
				return false;
			}
		}

	}
}
