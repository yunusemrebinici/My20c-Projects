using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		MyProject16Entities context= new MyProject16Entities();
		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
			TblUser user = new TblUser();
			Random rnd=new Random();
			int confirmCode=rnd.Next(100000,1000000);

			user.Name = txtName.Text;
			user.Surname=txtSurName.Text;
			user.Email = txtMail.Text;
			user.IsConfirm=false;
			user.ConfirmCode=confirmCode.ToString();

			if (txtPassword.Text==txtPasswordAgain.Text)
			{
				user.Password = txtPassword.Text;
				context.TblUser.Add(user);
				context.SaveChanges();

				#region MailKodları

				MimeMessage mimeMessage = new MimeMessage();

				MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister", "murocak169@gmail.com");
				mimeMessage.From.Add(mailboxAddressFrom);

				MailboxAddress mailboxAddressTo = new MailboxAddress("user", txtMail.Text);
				mimeMessage.To.Add(mailboxAddressTo);

				var bodyBuilder = new BodyBuilder();
				bodyBuilder.TextBody = "Email Adresinizin Konfirmasyon Kodu: " + confirmCode;
				mimeMessage.Body = bodyBuilder.ToMessageBody();

				mimeMessage.Subject = "Email Konfirmasyon Kodu";

				SmtpClient smtpClient = new SmtpClient();
				smtpClient.Connect("smtp.gmail.com", 587, false);
				smtpClient.Authenticate("murocak169@gmail.com", "rtmwyerwwpoypgaq");
				smtpClient.Send(mimeMessage);
				smtpClient.Disconnect(true);
				MessageBox.Show("Mail Adresinize Doğrulama Kodu  Gönderilmiştir");
				FrmMailConfirm frmMail = new FrmMailConfirm();
				frmMail.email = txtMail.Text;
				frmMail.Show();

				#endregion

			}
			else
			{
				MessageBox.Show("Parola Eşleşmiyor");
			}
			


		
		}
	}
}
