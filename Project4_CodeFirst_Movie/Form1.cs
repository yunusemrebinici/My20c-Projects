using Project4_CodeFirst_Movie.DAL.Context;
using Project4_CodeFirst_Movie.DAL.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_CodeFirst_Movie
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Context Context=new Context();
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var value=Context.Categories.ToList();
			dataGridView1.DataSource = value;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.CategoryName=txtCategoryName.Text;
			Context.Categories.Add(category);	
			Context.SaveChanges();

			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id=int.Parse(txtCategoryId.Text);
		    var remove =Context.Categories.Find(id);
			Context.Categories.Remove(remove);	
			Context.SaveChanges();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id =int.Parse(txtCategoryId.Text);
			var update=Context.Categories.Find(id);	
			update.CategoryName = txtCategoryName.Text;
			Context.SaveChanges();

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var value = txtCategoryName.Text;
			var values = Context.Categories.Where(x => x.CategoryName == txtCategoryName.Text).ToList();
			dataGridView1.DataSource=values;
		}

		private void txtCategoryName_TextChanged(object sender, EventArgs e)
		{
			var value=txtCategoryName.Text;
			var values = Context.Categories.Where(x=>x.CategoryName==value).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
