using Dapper;
using Project5_DapperNorthwind.Dtos.CategoryDtos;
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

namespace Project5_DapperNorthwind
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Server=EMRE\\SQLEXPRESS01;initial catalog=MyProject5;integrated security=true;");
		private async void button1_Click(object sender, EventArgs e)
		{
			string query = "Select * From Categories";
			var values = await connection.QueryAsync<ResultCategoryDto>(query);

			dataGridView1.DataSource = values;
		}

		private async void btnCategoryAdd_Click(object sender, EventArgs e)
		{
			string query = "Insert into Categories (CategoryName,Description) values (@p1,@p2)";
			var parameters = new DynamicParameters();
			parameters.Add("@p1", txtCategoryName.Text);
			parameters.Add("@p2", txtCategoryDescription.Text);
			await connection.ExecuteAsync(query ,parameters);
		}

		private async void btnCategoryUpdate_Click(object sender, EventArgs e)
		{
			string query = "Update Categories set CategoryName=@categoryname,Description=@description where CategoryID=@categoryId";
			var paramaters = new DynamicParameters();
			paramaters.Add("@categoryname", txtCategoryName.Text);
			paramaters.Add("@description", txtCategoryDescription.Text);
			paramaters.Add("@categoryId", int.Parse(txtCategoryId.Text));
			await connection.ExecuteAsync(query ,paramaters);
		}

		private async void btnCategoryDelete_Click(object sender, EventArgs e)
		{
			string query = "delete from Categories where CategoryID=@categoryId";
			var paramaters = new DynamicParameters();
			paramaters.Add("@categoryId",txtCategoryId.Text);
			await connection.ExecuteAsync(query, paramaters);

		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			//Kategori Sayısı
			string query = "select count(*) from Categories";
			var result= await connection.ExecuteScalarAsync<int>(query);
			lblCategoryCount.Text = "Toplam Kategori : " + result;

			//Ürün Sayısı
			string query2 = "select count(*) from Products";
			var productResult=await connection.ExecuteScalarAsync<int>(query2);
			lblProductCount.Text= "Toplam Ürün : " + productResult;

			//Ortalama Ürün Stok Sayısı
			string query3 = "select Avg(UnitsInStock) from Products";
			var totalProductStock=await connection.ExecuteScalarAsync<int>(query3);
			lblProductStockAvg.Text= "Ortalama Ürün Stok Sayısı : " + totalProductStock;

			//Deniz Ürünleri Toplam Fiyatı
			string query4 = "select Sum(UnitPrice) from Products where CategoryID=(select CategoryID from Categories where CategoryName='SeaFood')";
			var totalSeaFoodPrice= await connection.ExecuteScalarAsync<decimal>(query4);
			lblTotalSeaFoodPrice.Text= "Deniz Ürünleri Toplam Fiyatı : " + totalSeaFoodPrice;
		}
	}
}
