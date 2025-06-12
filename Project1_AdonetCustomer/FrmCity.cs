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

namespace Project1_AdonetCustomer
{
	public partial class FrmCity : Form
	{
		public FrmCity()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("Server=EMRE\\SQLEXPRESS01;initial catalog=DbCustomer;integrated security=true;");
		private void btnList_Click(object sender, EventArgs e)
		{
			
			
			SqlCommand cmd = new SqlCommand("Select * From TblCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
		
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("Insert into TblCity (CityName,CityCountry) values (@cityname,@citycountry)",sqlConnection);
			cmd.Parameters.AddWithValue("@cityname",txtCity.Text);
			cmd.Parameters.AddWithValue("@citycountry",txtCountry.Text);
			cmd.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Kayıt Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("Delete from TblCity where CityId=@P1",sqlConnection);
			cmd.Parameters.AddWithValue("@P1",int.Parse(txtCityId.Text));
			cmd.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Silme İşlemi Başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("update  TblCity set CityName=@cityname,CityCountry=@citycountry where CityId=@cityıd",sqlConnection);
			cmd.Parameters.AddWithValue("@cityname",txtCity.Text);
			cmd.Parameters.AddWithValue("@citycountry", txtCountry.Text);
			cmd.Parameters.AddWithValue("@cityıd",txtCityId.Text);
			cmd.ExecuteNonQuery();
		    sqlConnection.Close();
			MessageBox.Show("Güncelleme İşlemi Başarılı");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("select * from TblCity where CityName=@cityname", sqlConnection);
			cmd.Parameters.AddWithValue("@cityname",txtCity.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();

		}

		private void FrmCity_Load(object sender, EventArgs e)
		{

		}
	}
}
