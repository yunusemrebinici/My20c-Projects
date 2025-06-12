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
	public partial class FrmMap : Form
	{
		public FrmMap()
		{
			InitializeComponent();
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			Form1 category= new Form1();
			category.Show();
		}

		private void btnMovie_Click(object sender, EventArgs e)
		{
			FrmMovie movie= new FrmMovie();
			movie.Show();
		}
	}
}
