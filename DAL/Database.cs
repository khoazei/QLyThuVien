using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Database
    {
        SqlConnection Sqlconn;
        SqlDataAdapter adapter;
        DataSet ds;
        public Database()
        {

            string conn = "Data Source=ANH-BAO\\SQLEXPRESS;Initial Catalog=BOOK;Integrated Security=True";
            Sqlconn = new SqlConnection(conn);
            Sqlconn.Open();

        }
        public DataTable Execute(string sqlStr)
        {
            adapter = new SqlDataAdapter(sqlStr, Sqlconn);
            ds=new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua 
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, Sqlconn);
            //Mo ket noi 
            
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua 
            Sqlconn.Close();//Dong ket noi 
        }
        public int ExecuteNonQuery(string storedProcedure, string parameterName, object parameterValue)
        {   
                using (SqlCommand command = new SqlCommand(storedProcedure, Sqlconn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(parameterName, parameterValue);
                    return command.ExecuteNonQuery();
                }
            
        }
        public DataTable ExecuteQuery(string storedProcedureName, params SqlParameter[] parameters)
        {
			DataTable dataTable = new DataTable();

			try
			{
				using (SqlCommand command = new SqlCommand(storedProcedureName, Sqlconn))
				{
					command.CommandType = CommandType.StoredProcedure;

					if (parameters != null && parameters.Length > 0)
					{
						command.Parameters.AddRange(parameters);
					}

					Sqlconn.Open();

					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						adapter.Fill(dataTable);
					}
				}
			}
			catch (Exception ex)
			{
				LogError($"Error executing stored procedure: {storedProcedureName}\nError details: {ex.Message}");
			}
			finally
			{
				Sqlconn.Close();
			}
			return dataTable;

		}
		public void LogError(string errorMessage)
		{
			// Ghi log lỗi
			Console.WriteLine($"Error: {errorMessage}");
		}
		public void ExecuteNonQuery(string storedProcedure, params SqlParameter[] parameters)
		{
			try
			{
				using (SqlCommand command = new SqlCommand(storedProcedure, Sqlconn))
				{
					command.CommandType = CommandType.StoredProcedure;

					if (parameters != null && parameters.Length > 0)
					{
						command.Parameters.AddRange(parameters);
					}

					Sqlconn.Open();
					command.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				LogError($"Error executing stored procedure: {storedProcedure}\nError details: {ex.Message}");
			}
			finally
			{
				Sqlconn.Close();
			}
		}

	}


}
