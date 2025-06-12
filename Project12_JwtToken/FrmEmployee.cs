using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}
		public string tokenGet;
		SqlConnection connection = new SqlConnection("Server=EMRE\\SQLEXPRESS01;initial catalog=MyProject12;integrated security=true;");
		TokenValidator tokenValidator = new TokenValidator();
		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			richTextBox1.Text=tokenGet;
			var principal= tokenValidator.ValidateJwtToken(tokenGet);
			if (principal!=null)
			{
				
				
				SqlCommand cmd = new SqlCommand("select * from TblEmployee", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Geçersiz Token");
			}
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
