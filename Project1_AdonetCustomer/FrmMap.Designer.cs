namespace Project1_AdonetCustomer
{
	partial class FrmMap
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
			this.btnCity = new System.Windows.Forms.Button();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCity
			// 
			this.btnCity.Location = new System.Drawing.Point(102, 103);
			this.btnCity.Name = "btnCity";
			this.btnCity.Size = new System.Drawing.Size(254, 66);
			this.btnCity.TabIndex = 1;
			this.btnCity.Text = "Şehir İşlemleri";
			this.btnCity.UseVisualStyleBackColor = true;
			this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
			// 
			// btnCustomer
			// 
			this.btnCustomer.Location = new System.Drawing.Point(102, 176);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(254, 66);
			this.btnCustomer.TabIndex = 2;
			this.btnCustomer.Text = "Kişi İşlemleri";
			this.btnCustomer.UseVisualStyleBackColor = true;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(475, 371);
			this.Controls.Add(this.btnCustomer);
			this.Controls.Add(this.btnCity);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İşlemler";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCity;
		private System.Windows.Forms.Button btnCustomer;
	}
}