namespace Project16_MailRegister
{
	partial class FrmMailConfirm
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
			this.txtActivationMail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtActivationNumber = new System.Windows.Forms.TextBox();
			this.btnConfirmActivation = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label1.Location = new System.Drawing.Point(70, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email Adresi:";
			// 
			// txtActivationMail
			// 
			this.txtActivationMail.Location = new System.Drawing.Point(218, 128);
			this.txtActivationMail.Name = "txtActivationMail";
			this.txtActivationMail.ReadOnly = true;
			this.txtActivationMail.Size = new System.Drawing.Size(253, 28);
			this.txtActivationMail.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.label2.Location = new System.Drawing.Point(70, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "6 Haneli Kod:";
			// 
			// txtActivationNumber
			// 
			this.txtActivationNumber.Location = new System.Drawing.Point(218, 182);
			this.txtActivationNumber.Name = "txtActivationNumber";
			this.txtActivationNumber.Size = new System.Drawing.Size(253, 28);
			this.txtActivationNumber.TabIndex = 1;
			// 
			// btnConfirmActivation
			// 
			this.btnConfirmActivation.Location = new System.Drawing.Point(244, 240);
			this.btnConfirmActivation.Name = "btnConfirmActivation";
			this.btnConfirmActivation.Size = new System.Drawing.Size(204, 33);
			this.btnConfirmActivation.TabIndex = 2;
			this.btnConfirmActivation.Text = "Aktivasyonu Tamamla";
			this.btnConfirmActivation.UseVisualStyleBackColor = true;
			this.btnConfirmActivation.Click += new System.EventHandler(this.btnConfirmActivation_Click);
			// 
			// FrmMailConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(638, 415);
			this.Controls.Add(this.btnConfirmActivation);
			this.Controls.Add(this.txtActivationNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtActivationMail);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmMailConfirm";
			this.Text = "Mail Aktivasyon Formu";
			this.Load += new System.EventHandler(this.FrmMailConfirm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtActivationMail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtActivationNumber;
		private System.Windows.Forms.Button btnConfirmActivation;
	}
}