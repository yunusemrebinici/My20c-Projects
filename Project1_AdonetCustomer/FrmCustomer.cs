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
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("Server=EMRE\\SQLEXPRESS01;initial catalog=DbCustomer;integrated security=true;");
		private void btnList_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("Execute CustomerListWithCity ", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;

		}

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("select * from TblCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			cmbCity.DisplayMember = "CityName";
			cmbCity.ValueMember = "CityId";
			cmbCity.DataSource = dt;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("insert into TblCustomer (CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity) values (@P1,@P2,@P3,@P4,@P5)", sqlConnection);
			cmd.Parameters.AddWithValue("@P1", txtCustomerName.Text);
			cmd.Parameters.AddWithValue("@P2", txtCustomerSurname.Text);
			cmd.Parameters.AddWithValue("@P3", int.Parse(txtCustomerBalance.Text));
			cmd.Parameters.AddWithValue("@P5", cmbCity.SelectedValue);
			if (rdbActive.Checked == true)
			{
				cmd.Parameters.AddWithValue("@P4", true);
			}
			if (rdbPassive.Checked == true)
			{
				cmd.Parameters.AddWithValue("@P4", false);
			}
			cmd.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Ekleme İşlemi Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("delete  from TblCustomer where CustomerId=@P1", sqlConnection);
			cmd.Parameters.AddWithValue("@P1", txtCustomerId.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Silme İşlemi Başarılı");
			sqlConnection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("update TblCustomer set CustomerName=@p1,CustomerSurname=@p2,CustomerCity=@p3,CustomerBalance=@p4,CustomerStatus=@p5 where CustomerId=@p6", sqlConnection);
			cmd.Parameters.AddWithValue("@p1", txtCustomerName.Text);
			cmd.Parameters.AddWithValue("@p2", txtCustomerSurname.Text);
			cmd.Parameters.AddWithValue("@p3", cmbCity.SelectedValue);
			cmd.Parameters.AddWithValue("@p4", txtCustomerBalance.Text);
			if (rdbActive.Checked == true)
			{
				cmd.Parameters.AddWithValue("@p5", true);
			}
			if (rdbPassive.Checked == true)
			{
				cmd.Parameters.AddWithValue("@p5", false);
			}
			cmd.Parameters.AddWithValue("@p6", int.Parse(txtCustomerId.Text));
			cmd.ExecuteNonQuery();
			MessageBox.Show("Güncelleme Başarılı");
			sqlConnection.Close();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand cmd = new SqlCommand("Select * from TblCustomer where CustomerId=@p1", sqlConnection);
			cmd.Parameters.AddWithValue("@p1", txtCustomerId.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			cmd.ExecuteNonQuery();
			sqlConnection.Close();
		}
	}
}
