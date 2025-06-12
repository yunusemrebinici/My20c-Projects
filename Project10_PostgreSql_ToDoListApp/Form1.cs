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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		NpgsqlConnection connection = new NpgsqlConnection("Server=localHost;port=5432;Database=DbProject10ToDoApp;user ID= postgres;Password=123456");

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories fr=new FrmCategories();
			fr.Show();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			connection.Open();
			
			int cmb = int.Parse(cmbCategory.SelectedValue.ToString());
			//byte status = 1;
			//if (rdbContinues.Checked==true)
			//{
			//	status = 1;
			//}
			//else if (rdbFinished.Checked==true)
			//{
			//	status = 0;
   //         }
			string query = "insert into todolists (title,description,status,priority,categoryid) values (@title,@description,B'0',@priority,@categoryid)";
			using (var command = new NpgsqlCommand(query,connection))
			{
				command.Parameters.AddWithValue("@title",txtTitle.Text);
				command.Parameters.AddWithValue("@description",txtDescription.Text);
				
				command.Parameters.AddWithValue("@priority",txtPriorty.Text);
				command.Parameters.AddWithValue("@categoryid", cmb);
				command.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Ekleme İşlemi gerçekleşti");
			}

		}
		void list()
		{
			string query = "select todolistsid,title ,description,status,priority,categoryname from todolists inner join categories on todolists.categoryid = categories.categoryid";			
			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query,connection);
			DataTable dt=new DataTable();	
			adapter.Fill(dt);
			dataGridView1.DataSource=dt;
		}
		void cmblist()
		{
			string query = "select * from categories";
			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query,connection);
			DataTable dt=new DataTable();
			adapter.Fill(dt);
			cmbCategory.DisplayMember = "categoryname";
			cmbCategory.ValueMember = "categoryid";	
			cmbCategory.DataSource = dt;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			list();
			cmblist();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			list();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			connection.Open();
			string query = "delete from todolists where todolistsid=@todolistid";
			using (var command=new Npgsql.NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@todolistid",int.Parse(txtİd.Text));
				command.ExecuteNonQuery();
				MessageBox.Show("Silme İşlemi Gerçekleşti");
				list();
			}
			connection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			connection.Open();
			int id = int.Parse(txtİd.Text);

			int ctgname = int.Parse(cmbCategory.SelectedValue.ToString());
			string query = "update todolists set categoryid=@categoryid,title=@title,description=@des,priority=@pri where todolistsid=@todolistid";
			using (var command=new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@todolistid", id);
				command.Parameters.AddWithValue("@categoryid",ctgname);
				command.Parameters.AddWithValue("@title", txtTitle.Text);
				command.Parameters.AddWithValue("@des",txtDescription.Text);
				command.Parameters.AddWithValue("@pri",txtPriorty.Text);
				command.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Silme İşlemi Başarılı");
				list();
			}
		}

		private void btnContinues_Click(object sender, EventArgs e)
		{
			string query = "select todolistsid,title ,description,status,priority,categoryname from todolists inner join categories on todolists.categoryid = categories.categoryid where status='0'";
			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void btnFinished_Click(object sender, EventArgs e)
		{
			string query = "select todolistsid,title ,description,status,priority,categoryname from todolists inner join categories on todolists.categoryid = categories.categoryid where status='1'";
			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}
	}
}
