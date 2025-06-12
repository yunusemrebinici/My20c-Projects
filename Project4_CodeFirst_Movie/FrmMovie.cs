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
	public partial class FrmMovie : Form
	{
		public FrmMovie()
		{
			InitializeComponent();
		}
		Context db = new Context();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Movie movie = new Movie();

			movie.MovieTitle=txtMovieName.Text;
			movie.Description=txtDescription.Text;
			movie.Duration=int.Parse(txtDuration.Text);
			movie.CreateDate = DateTime.Parse(mskDate.Text);
			movie.CategoryId=Convert.ToInt32(cmbCategory.SelectedValue);
			db.Movies.Add(movie);
			db.SaveChanges();
			MessageBox.Show("Ekleme Başarılı");
			
		}
		void cmblist()
		{
			 
			cmbCategory.ValueMember = "CategoryId";
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.DataSource = db.Categories.ToList();
		}
		void list()
		{
			var values=db.Movies
				.Join(db.Categories,
			     movie =>movie.CategoryId,
				 category =>category.CategoryId,
				 (movie,category) => new
				 {
					 FilmId= movie.MovieId,
					 Film=movie.MovieTitle,
					 Konu=movie.Description,
					 Dakika=movie.Duration,
					 Tarih=movie.CreateDate,
					 Kategori=movie.CategoryId,
					 
				 }
				).ToList();	
			dataGridView1.DataSource = values;
		}

		private void FrmMovie_Load(object sender, EventArgs e)
		{
			cmblist();
			list();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			list();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id =Convert.ToInt32(txtMovieId.Text);
			var deleteValue=db.Movies.Find(id);
			db.Movies.Remove(deleteValue);
			db.SaveChanges();
			MessageBox.Show("Silme İşlemi Başarılı");
			
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtMovieId.Text);
			var value = db.Movies.Find(id);
			value.MovieTitle = txtMovieName.Text;
			value.Description = txtDescription.Text;
			value.Duration = int.Parse(txtDuration.Text);
			value.CreateDate = DateTime.Parse(mskDate.Text);
			value.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
			db.SaveChanges();
			MessageBox.Show("Güncelleme Başarılı");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string find=txtMovieName.Text;
			var value=db.Movies.Where(x=>x.MovieTitle==find).ToList();
			dataGridView1.DataSource = value;
		}
	}
}
