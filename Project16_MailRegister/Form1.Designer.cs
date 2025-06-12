namespace Project16_MailRegister
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSurName = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtPasswordAgain = new System.Windows.Forms.TextBox();
			this.btnCreateAccount = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label1.Location = new System.Drawing.Point(109, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adınız:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label2.Location = new System.Drawing.Point(71, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "SoyAdınız:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label3.Location = new System.Drawing.Point(113, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label4.Location = new System.Drawing.Point(96, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 26);
			this.label4.TabIndex = 0;
			this.label4.Text = "Şifreniz:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label5.Location = new System.Drawing.Point(57, 254);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 26);
			this.label5.TabIndex = 0;
			this.label5.Text = "Şifre Tekrar:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(229, 31);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(151, 26);
			this.txtName.TabIndex = 1;
			// 
			// txtSurName
			// 
			this.txtSurName.Location = new System.Drawing.Point(229, 86);
			this.txtSurName.Name = "txtSurName";
			this.txtSurName.Size = new System.Drawing.Size(151, 26);
			this.txtSurName.TabIndex = 1;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(229, 141);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(151, 26);
			this.txtMail.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(229, 196);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(151, 26);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtPasswordAgain
			// 
			this.txtPasswordAgain.Location = new System.Drawing.Point(229, 251);
			this.txtPasswordAgain.Name = "txtPasswordAgain";
			this.txtPasswordAgain.Size = new System.Drawing.Size(151, 26);
			this.txtPasswordAgain.TabIndex = 1;
			this.txtPasswordAgain.UseSystemPasswordChar = true;
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Location = new System.Drawing.Point(189, 312);
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Size = new System.Drawing.Size(235, 40);
			this.btnCreateAccount.TabIndex = 2;
			this.btnCreateAccount.Text = "Kayıt Ol";
			this.btnCreateAccount.UseVisualStyleBackColor = true;
			this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(572, 430);
			this.Controls.Add(this.btnCreateAccount);
			this.Controls.Add(this.txtPasswordAgain);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtSurName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Kayıt Ol";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSurName;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtPasswordAgain;
		private System.Windows.Forms.Button btnCreateAccount;
	}
}

