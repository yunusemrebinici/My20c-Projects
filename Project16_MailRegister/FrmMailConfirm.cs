using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
	public partial class FrmMailConfirm : Form
	{
		public FrmMailConfirm()
		{
			InitializeComponent();
		}
		public string email;
		MyProject16Entities context =new  MyProject16Entities();
		private void btnConfirmActivation_Click(object sender, EventArgs e)
		{
			
			var value =context.TblUser.Where(x=>x.Email==email).Select(y=>y.ConfirmCode).FirstOrDefault();
			if (txtActivationNumber.Text==value.ToString())
			{

				var value2 = context.TblUser.Where(x=>x.Email==email).FirstOrDefault();
				value2.IsConfirm = true;
				context.TblUser.AddOrUpdate(value2);
				context.SaveChanges();
				MessageBox.Show("Hesabınız Aktif Edildi");

			}
			else
			{
				MessageBox.Show("Kod Hatalı");
			}
		}

		private void FrmMailConfirm_Load(object sender, EventArgs e)
		{
			txtActivationMail.Text = email;
		}
	}
}
