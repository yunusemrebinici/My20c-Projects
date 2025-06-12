﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
	public partial class FrmMap : Form
	{
		public FrmMap()
		{
			InitializeComponent();
		}

		private void btnCity_Click(object sender, EventArgs e)
		{
			FrmCity city = new FrmCity();
			city.Show();
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			FrmCustomer customer = new FrmCustomer();
			customer.Show();
		}
	}
}
