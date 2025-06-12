using Project9_MongoDbOrder.entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		OrderOperation operation = new OrderOperation();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var order = new Order
			{

				CustomerName = txtCustomer.Text,
				District = txtDistrict.Text,
				City = txtCity.Text,
				TotalPrice = decimal.Parse(txtTotalPrice.Text)
			};
			operation.AddOrder(order);
			MessageBox.Show("Ekleme İşlemi Yapıldı");

		}

		private void btnList_Click(object sender, EventArgs e)
		{
			List<Order> orders = operation.GetAllOrders();
			dataGridView1.DataSource = orders;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string orderId = txtId.Text;
			operation.DeleteOrder(orderId);
			MessageBox.Show("Silme İşlemi Başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var order = new Order
			{
				OrderId = txtId.Text,
				CustomerName = txtCustomer.Text,
				District = txtDistrict.Text,
				City = txtCity.Text,
				TotalPrice = decimal.Parse(txtTotalPrice.Text)
			};
			operation.UpdateOrder(order);
			MessageBox.Show("Güncelleme İşlemi Başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			Order orders=operation.GetById(id);
			
			dataGridView1.DataSource = new List<Order> {orders};


		}
	}
}
