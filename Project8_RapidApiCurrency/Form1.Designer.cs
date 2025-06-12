namespace Project8_RapidApiCurrency
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
			this.lblDolar = new System.Windows.Forms.Label();
			this.lblEuro = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBirim = new System.Windows.Forms.TextBox();
			this.txtSonuc = new System.Windows.Forms.TextBox();
			this.rdbDolar = new System.Windows.Forms.RadioButton();
			this.rdbEuro = new System.Windows.Forms.RadioButton();
			this.rdbSterlin = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.lblSterlin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDolar
			// 
			this.lblDolar.AutoSize = true;
			this.lblDolar.Location = new System.Drawing.Point(196, 45);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.Size = new System.Drawing.Size(77, 25);
			this.lblDolar.TabIndex = 0;
			this.lblDolar.Text = "lblDolar";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Location = new System.Drawing.Point(351, 45);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(77, 25);
			this.lblEuro.TabIndex = 1;
			this.lblEuro.Text = "lblDolar";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(115, 286);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Birim Tutar:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(67, 372);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 25);
			this.label8.TabIndex = 1;
			this.label8.Text = "Ödenecek Tutar:";
			// 
			// txtBirim
			// 
			this.txtBirim.Location = new System.Drawing.Point(264, 284);
			this.txtBirim.Name = "txtBirim";
			this.txtBirim.Size = new System.Drawing.Size(265, 30);
			this.txtBirim.TabIndex = 2;
			// 
			// txtSonuc
			// 
			this.txtSonuc.Location = new System.Drawing.Point(264, 369);
			this.txtSonuc.Name = "txtSonuc";
			this.txtSonuc.Size = new System.Drawing.Size(265, 30);
			this.txtSonuc.TabIndex = 2;
			// 
			// rdbDolar
			// 
			this.rdbDolar.AutoSize = true;
			this.rdbDolar.Location = new System.Drawing.Point(201, 212);
			this.rdbDolar.Name = "rdbDolar";
			this.rdbDolar.Size = new System.Drawing.Size(79, 29);
			this.rdbDolar.TabIndex = 3;
			this.rdbDolar.TabStop = true;
			this.rdbDolar.Text = "Dolar";
			this.rdbDolar.UseVisualStyleBackColor = true;
			// 
			// rdbEuro
			// 
			this.rdbEuro.AutoSize = true;
			this.rdbEuro.Location = new System.Drawing.Point(345, 212);
			this.rdbEuro.Name = "rdbEuro";
			this.rdbEuro.Size = new System.Drawing.Size(74, 29);
			this.rdbEuro.TabIndex = 3;
			this.rdbEuro.TabStop = true;
			this.rdbEuro.Text = "Euro";
			this.rdbEuro.UseVisualStyleBackColor = true;
			// 
			// rdbSterlin
			// 
			this.rdbSterlin.AutoSize = true;
			this.rdbSterlin.Location = new System.Drawing.Point(485, 212);
			this.rdbSterlin.Name = "rdbSterlin";
			this.rdbSterlin.Size = new System.Drawing.Size(88, 29);
			this.rdbSterlin.TabIndex = 3;
			this.rdbSterlin.TabStop = true;
			this.rdbSterlin.Text = "Sterlin";
			this.rdbSterlin.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(334, 419);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(137, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "İşlemi Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblSterlin
			// 
			this.lblSterlin.AutoSize = true;
			this.lblSterlin.Location = new System.Drawing.Point(496, 45);
			this.lblSterlin.Name = "lblSterlin";
			this.lblSterlin.Size = new System.Drawing.Size(77, 25);
			this.lblSterlin.TabIndex = 1;
			this.lblSterlin.Text = "lblDolar";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 548);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rdbSterlin);
			this.Controls.Add(this.rdbEuro);
			this.Controls.Add(this.rdbDolar);
			this.Controls.Add(this.txtSonuc);
			this.Controls.Add(this.txtBirim);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblSterlin);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.lblDolar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDolar;
		private System.Windows.Forms.Label lblEuro;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBirim;
		private System.Windows.Forms.TextBox txtSonuc;
		private System.Windows.Forms.RadioButton rdbDolar;
		private System.Windows.Forms.RadioButton rdbEuro;
		private System.Windows.Forms.RadioButton rdbSterlin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblSterlin;
	}
}

