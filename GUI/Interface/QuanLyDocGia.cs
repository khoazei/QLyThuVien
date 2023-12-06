using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Interface
{
	public partial class frmDocgia : Form
	{
		CrudDocGia dg = new CrudDocGia();
		public frmDocgia()
		{
			InitializeComponent();
		}
		public void HienThiDocGia()
		{
			lstDocgia.Items.Clear();
			DataTable dataTablesach = dg.LayDSDocGia();
			for (int i = 0; i < dataTablesach.Rows.Count; i++)
			{
				ListViewItem k = lstDocgia.Items.Add(dataTablesach.Rows[i][0].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][1].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][2].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][3].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][4].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][5].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][6].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][7].ToString());
				k.SubItems.Add(dataTablesach.Rows[i][8].ToString());

			}
		}

		private void frmDocgia_Load(object sender, EventArgs e)
		{
			HienThiDocGia();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{

		}
	}
}
