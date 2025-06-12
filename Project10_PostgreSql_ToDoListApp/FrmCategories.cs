using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSql_ToDoListApp
{
	public partial class FrmCategories : Form
	{
		public FrmCategories()
		{
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("Server=localHost;port=5432;Database=DbProject10ToDoApp;user ID= postgres;Password=123456");

		void listele()
		{
			NpgsqlCommand cmd = new NpgsqlCommand("Select  * from categories", connection);
			NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			listele();
		}

		private void FrmCategories_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			connection.Open();
			string query = "insert into categories (categoryname) values (@categoryname)";
			using (var command=new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryname",txtCategoryName.Text);
				command.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Kayıt İşlemi Başarılı");
				listele();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			connection.Open();
			string query = "delete from categories where categoryid=@categoryid";
			using (var command=new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryid", int.Parse(txtİd.Text));
				command.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Silme İşlemi Başarılı");
				listele();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			connection.Open();
			string query = "update categories set categoryname=@categoryname where categoryid=@categoryid";
			using (var command=new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryname",txtCategoryName.Text);
				command.Parameters.AddWithValue("@categoryid", int.Parse(txtİd.Text));
				command.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Güncelleme İşlemi Başarılı");
				listele();

			}
		}

		private void btnGetAllList_Click(object sender, EventArgs e)
		{
			var query = "select * from todolists ";
		    NpgsqlCommand command = new NpgsqlCommand(query, connection);
			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
			DataTable dt=new DataTable();
		    adapter.Fill(dt);
			dataGridView1.DataSource= dt;

		}
	}
}
