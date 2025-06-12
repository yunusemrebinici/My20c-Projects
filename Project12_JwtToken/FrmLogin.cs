using Project12_JwtToken.JWT;
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

namespace Project12_JwtToken
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			
		}
		SqlConnection connection = new SqlConnection("Server=EMRE\\SQLEXPRESS01;initial catalog=MyProject12;integrated security=true;");
		FrmEmployee frm = new FrmEmployee();
		private void btnLogin_Click(object sender, EventArgs e)
		{
			TokenGenerator generator = new TokenGenerator();
			
			connection.Open();
			SqlCommand cmd = new SqlCommand("select * from TblUser where UserName=@p1 and Password=@p2",connection);
			cmd.Parameters.AddWithValue("@p1",txtUserName.Text);
			cmd.Parameters.AddWithValue("@p2", int.Parse(txtPassword.Text));
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
				string token = generator.GenerateJwtToken(txtUserName.Text);
				frm.tokenGet = token;
				MessageBox.Show(frm.tokenGet);	
				frm.Show();
				
			}
			else
			{
				MessageBox.Show("Kullanıcı adı , şifre hatalı");
				txtPassword.Clear();
				txtUserName.Clear();
				txtUserName.Focus();
			}
			connection.Close();
		}
	}
}
