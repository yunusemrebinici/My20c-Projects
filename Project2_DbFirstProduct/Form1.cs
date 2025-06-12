﻿using System;
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
	public partial class Map : Form
	{
		public Map()
		{
			InitializeComponent();
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			FrmCategory category = new FrmCategory();
			category.Show();
		}

		private void btnProduct_Click(object sender, EventArgs e)
		{
			FrmProduct product = new FrmProduct();
			product.Show();
		}
	}
}
