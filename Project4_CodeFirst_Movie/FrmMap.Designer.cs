namespace Project4_CodeFirst_Movie
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
			this.btnCategory = new System.Windows.Forms.Button();
			this.btnMovie = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCategory
			// 
			this.btnCategory.Location = new System.Drawing.Point(82, 46);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(273, 84);
			this.btnCategory.TabIndex = 0;
			this.btnCategory.Text = "Category";
			this.btnCategory.UseVisualStyleBackColor = true;
			this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
			// 
			// btnMovie
			// 
			this.btnMovie.Location = new System.Drawing.Point(82, 166);
			this.btnMovie.Name = "btnMovie";
			this.btnMovie.Size = new System.Drawing.Size(273, 84);
			this.btnMovie.TabIndex = 0;
			this.btnMovie.Text = "Movie";
			this.btnMovie.UseVisualStyleBackColor = true;
			this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(433, 313);
			this.Controls.Add(this.btnMovie);
			this.Controls.Add(this.btnCategory);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMap";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCategory;
		private System.Windows.Forms.Button btnMovie;
	}
}