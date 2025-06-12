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

namespace Project18_DashboardSuperStoreDataset
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("server=EMRE\\SQLEXPRESS01;initial catalog=MyProject17;integrated security=true");
		private void Form1_Load(object sender, EventArgs e)
		{
			#region witget
			connection.Open();
			SqlCommand cmd = new SqlCommand("select Count(*) from superstore ",connection);
			SqlDataReader rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				lblProductCount.Text = rdr[0].ToString();
			}
			connection.Close();

			connection.Open();
			SqlCommand cmd2 = new SqlCommand("select Count(Distinct(State)) from superstore ", connection);
			SqlDataReader rdr2 = cmd2.ExecuteReader();
			while (rdr2.Read())
			{
				lblCityCount.Text = rdr2[0].ToString();
			}
			connection.Close();

			connection.Open();
			SqlCommand cmd3 = new SqlCommand("select Count(*) from superstore where Country='Turkey'", connection);
			SqlDataReader rdr3 = cmd3.ExecuteReader();
			while (rdr3.Read())
			{
				lblOrderCountByTurkiye.Text = rdr3[0].ToString();
			}
			connection.Close();

			connection.Open();
			SqlCommand cmd4 = new SqlCommand("select Sum(Quantity) from superstore", connection);
			SqlDataReader rdr4 = cmd4.ExecuteReader();
			while (rdr4.Read())
			{
				lblOrderCount.Text = rdr4[0].ToString();
			}
			connection.Close();
			#endregion

			#region chart

			connection.Open();
			SqlCommand cmd5 = new SqlCommand("SELECT TOP (7) Country, COUNT(*) FROM superstore GROUP BY Country ORDER BY COUNT(*) DESC", connection);
			using (SqlDataReader rd5 = cmd5.ExecuteReader())
			{
				while (rd5.Read())
				{
					chart1.Series["Series1"].Points.AddXY(rd5[0].ToString(), rd5[1]);
				}
			}
			connection.Close();

			///chart2
			connection.Open();
			SqlCommand cmd6 = new SqlCommand("SELECT TOP (5) Country, sum(Quantity) FROM superstore GROUP BY Country ORDER BY sum(quantity) DESC", connection);
			using (SqlDataReader rd6 = cmd6.ExecuteReader())
			{
				while (rd6.Read())
				{
					chart2.Series["Series1"].Points.AddXY(rd6[0].ToString(), rd6[1]);
				}
			}
			connection.Close();

			///chart3
			connection.Open();
			SqlCommand cmd7 = new SqlCommand("SELECT Order_Priority, Count(*) FROM superstore GROUP BY Order_Priority order by Order_Priority desc", connection);
			using (SqlDataReader rd7 = cmd7.ExecuteReader())
			{
				while (rd7.Read())
				{
					chart3.Series["Series1"].Points.AddXY(rd7[0].ToString(), rd7[1]);
				}
			}
			connection.Close();

			#endregion
		}
	}
}
