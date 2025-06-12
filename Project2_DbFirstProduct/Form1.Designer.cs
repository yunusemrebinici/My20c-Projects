namespace Project2_DbFirstProduct
{
	partial class Map
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
			this.btnCategory = new System.Windows.Forms.Button();
			this.btnProduct = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCategory
			// 
			this.btnCategory.Location = new System.Drawing.Point(159, 132);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(156, 57);
			this.btnCategory.TabIndex = 0;
			this.btnCategory.Text = "Category";
			this.btnCategory.UseVisualStyleBackColor = true;
			this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
			// 
			// btnProduct
			// 
			this.btnProduct.Location = new System.Drawing.Point(159, 209);
			this.btnProduct.Name = "btnProduct";
			this.btnProduct.Size = new System.Drawing.Size(156, 57);
			this.btnProduct.TabIndex = 0;
			this.btnProduct.Text = "Product";
			this.btnProduct.UseVisualStyleBackColor = true;
			this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
			// 
			// Map
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(487, 422);
			this.Controls.Add(this.btnProduct);
			this.Controls.Add(this.btnCategory);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Map";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Map";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCategory;
		private System.Windows.Forms.Button btnProduct;
	}
}

