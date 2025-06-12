namespace Project12_JwtToken
{
	partial class FrmTokenGenerator
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
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSurName = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.btnCreateToken = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 69);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(131, 124);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(100, 174);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "SoyAdı:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(111, 225);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "Email:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(216, 69);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(378, 27);
			this.txtUserName.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(216, 118);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(378, 27);
			this.txtName.TabIndex = 1;
			// 
			// txtSurName
			// 
			this.txtSurName.Location = new System.Drawing.Point(216, 167);
			this.txtSurName.Name = "txtSurName";
			this.txtSurName.Size = new System.Drawing.Size(378, 27);
			this.txtSurName.TabIndex = 1;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(216, 216);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(378, 27);
			this.txtMail.TabIndex = 1;
			// 
			// btnCreateToken
			// 
			this.btnCreateToken.Location = new System.Drawing.Point(317, 269);
			this.btnCreateToken.Name = "btnCreateToken";
			this.btnCreateToken.Size = new System.Drawing.Size(173, 40);
			this.btnCreateToken.TabIndex = 2;
			this.btnCreateToken.Text = "Token Oluştur";
			this.btnCreateToken.UseVisualStyleBackColor = true;
			this.btnCreateToken.Click += new System.EventHandler(this.btnCreateToken_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(57, 332);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(609, 136);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// FrmTokenGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(721, 492);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnCreateToken);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtSurName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmTokenGenerator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTokenGenerator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSurName;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.Button btnCreateToken;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}