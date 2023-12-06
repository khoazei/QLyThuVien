using GUI;
using GUI.Interface;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien;
public partial class manager : Form
{
	public manager()
	{
		InitializeComponent();
	}

	private void bunifuFlatButton1_Click(object sender, EventArgs e)
	{
		frmDocgia docgia = new frmDocgia();
		this.Hide();
		docgia.ShowDialog();
		this.Show();
	}

	private void pictureBox4_Click(object sender, EventArgs e)
	{

	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void bunifuFlatButton5_Click(object sender, EventArgs e)
	{
		frmQuanLy bookmanagement = new frmQuanLy();
		this.Hide();
		bookmanagement.ShowDialog();
		this.Show();
	}

	private void bunifuFlatButton4_Click(object sender, EventArgs e)
	{

		this.Hide();

		this.Show();
	}

	private void bunifuFlatButton3_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void manager_FormClosing(object sender, FormClosingEventArgs e)
	{

		if (MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
		{
			e.Cancel = true;
		}
	}

	private void bunifuFlatButton2_Click(object sender, EventArgs e)
	{
		searchbook searchbook = new searchbook();
		this.Hide();
		searchbook.ShowDialog();
		this.Show();
	}

	private void manager_Load(object sender, EventArgs e)
	{

	}

	private void bunifuFlatButton6_Click(object sender, EventArgs e)
	{

	}
}
