using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_DbFirstProduct
{
	public partial class FrmProduct : Form
	{
		public FrmProduct()
		{
			InitializeComponent();
		}
		MyProject2Entities db=new MyProject2Entities();
		private void btnList_Click(object sender, EventArgs e)
		{
			var values =db.TblProduct.
				Join(db.TblCategory,
				product=>product.ProductCategory,
				category=>category.CategoryId,
				(product,category)=>new
				{
					ürünId = product.ProductId,
					ÜrünAdı=product.ProductName,
					ÜrünFiyatı=product.ProductPrice,
					Kategori=category.CategoryName,
				}	
				).ToList();
			dataGridView1.DataSource = values;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			TblProduct product = new TblProduct();
			product.ProductName=txtProductName.Text;
			product.ProductPrice = int.Parse(txtProductPrice.Text);
			product.ProductCategory = int.Parse(cmbProductCategory.SelectedValue.ToString());
			db.TblProduct.Add(product);
			db.SaveChanges();
			MessageBox.Show("Ekleme İşlemi Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductId.Text);
			TblProduct product=db.TblProduct.Find(id);
			db.TblProduct.Remove(product);
			db.SaveChanges();
			MessageBox.Show("Silme İşlemi Başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id=int.Parse(txtProductId.Text);
			TblProduct product= db.TblProduct.Find(id);
			product.ProductName= txtProductName.Text;
			product.ProductPrice = int.Parse(txtProductPrice.Text);
			product.ProductCategory = int.Parse(cmbProductCategory.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Güncelleme İşlemi Başarılı");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string name=txtProductName.Text;
			var value = db.TblProduct.Where(x=>x.ProductName==name).ToList();
			dataGridView1.DataSource = value;
		}

		private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			var values = db.TblCategory.ToList();
			cmbProductCategory.DisplayMember = "CategoryName";
			cmbProductCategory.ValueMember = "CategoryId";
			cmbProductCategory.DataSource = values;
		}
	}
}
