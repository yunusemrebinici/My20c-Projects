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
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}
		MyProject2Entities db = new MyProject2Entities();
		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.TblCategory.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			TblCategory tblCategory = new TblCategory();
			
			tblCategory.CategoryName=txtCategoryName.Text;
			db.TblCategory.Add(tblCategory);
			db.SaveChanges();
			MessageBox.Show("Ekleme İşlemi Yapıldı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			int id = int.Parse(txtCategoryId.Text);
			var values = db.TblCategory.Find(id);
			db.TblCategory.Remove(values);
			db.SaveChangesAsync();
			MessageBox.Show("Silme İşlemi Gerçekleşti");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var values = db.TblCategory.Find(id);
			values.CategoryName = txtCategoryName.Text;
			db.SaveChanges();
			MessageBox.Show("Güncelleme Başarılı");

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var name=txtCategoryName.Text;
			var values = db.TblCategory.Where(x=>x.CategoryName==name).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
