namespace Project5_DapperNorthwind
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.btnCategoryAdd = new System.Windows.Forms.Button();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtCategoryDescription = new System.Windows.Forms.TextBox();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.btnCategoryUpdate = new System.Windows.Forms.Button();
			this.btnCategoryDelete = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblProductStockAvg = new System.Windows.Forms.Label();
			this.lblTotalSeaFoodPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 224);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(850, 224);
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCategoryAdd
			// 
			this.btnCategoryAdd.Location = new System.Drawing.Point(80, 66);
			this.btnCategoryAdd.Name = "btnCategoryAdd";
			this.btnCategoryAdd.Size = new System.Drawing.Size(164, 35);
			this.btnCategoryAdd.TabIndex = 2;
			this.btnCategoryAdd.Text = "Kategori Ekle";
			this.btnCategoryAdd.UseVisualStyleBackColor = true;
			this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategoryName.Location = new System.Drawing.Point(296, 60);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(130, 27);
			this.txtCategoryName.TabIndex = 3;
			// 
			// txtCategoryDescription
			// 
			this.txtCategoryDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategoryDescription.Location = new System.Drawing.Point(296, 100);
			this.txtCategoryDescription.Multiline = true;
			this.txtCategoryDescription.Name = "txtCategoryDescription";
			this.txtCategoryDescription.Size = new System.Drawing.Size(130, 87);
			this.txtCategoryDescription.TabIndex = 3;
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(296, 25);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(130, 22);
			this.txtCategoryId.TabIndex = 4;
			// 
			// btnCategoryUpdate
			// 
			this.btnCategoryUpdate.Location = new System.Drawing.Point(80, 107);
			this.btnCategoryUpdate.Name = "btnCategoryUpdate";
			this.btnCategoryUpdate.Size = new System.Drawing.Size(163, 36);
			this.btnCategoryUpdate.TabIndex = 5;
			this.btnCategoryUpdate.Text = "Kategori Güncelle";
			this.btnCategoryUpdate.UseVisualStyleBackColor = true;
			this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
			// 
			// btnCategoryDelete
			// 
			this.btnCategoryDelete.Location = new System.Drawing.Point(81, 149);
			this.btnCategoryDelete.Name = "btnCategoryDelete";
			this.btnCategoryDelete.Size = new System.Drawing.Size(163, 38);
			this.btnCategoryDelete.TabIndex = 5;
			this.btnCategoryDelete.Text = "Kategori Sil";
			this.btnCategoryDelete.UseVisualStyleBackColor = true;
			this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
			this.groupBox1.Controls.Add(this.lblTotalSeaFoodPrice);
			this.groupBox1.Controls.Add(this.lblProductStockAvg);
			this.groupBox1.Controls.Add(this.lblProductCount);
			this.groupBox1.Controls.Add(this.lblCategoryCount);
			this.groupBox1.Location = new System.Drawing.Point(490, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 175);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dapper İstatistik";
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Location = new System.Drawing.Point(29, 29);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(37, 16);
			this.lblCategoryCount.TabIndex = 0;
			this.lblCategoryCount.Text = "label";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Location = new System.Drawing.Point(29, 66);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(37, 16);
			this.lblProductCount.TabIndex = 1;
			this.lblProductCount.Text = "label";
			// 
			// lblProductStockAvg
			// 
			this.lblProductStockAvg.AutoSize = true;
			this.lblProductStockAvg.Location = new System.Drawing.Point(29, 105);
			this.lblProductStockAvg.Name = "lblProductStockAvg";
			this.lblProductStockAvg.Size = new System.Drawing.Size(44, 16);
			this.lblProductStockAvg.TabIndex = 1;
			this.lblProductStockAvg.Text = "label2";
			// 
			// lblTotalSeaFoodPrice
			// 
			this.lblTotalSeaFoodPrice.AutoSize = true;
			this.lblTotalSeaFoodPrice.Location = new System.Drawing.Point(29, 144);
			this.lblTotalSeaFoodPrice.Name = "lblTotalSeaFoodPrice";
			this.lblTotalSeaFoodPrice.Size = new System.Drawing.Size(44, 16);
			this.lblTotalSeaFoodPrice.TabIndex = 1;
			this.lblTotalSeaFoodPrice.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 448);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCategoryDelete);
			this.Controls.Add(this.btnCategoryUpdate);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.txtCategoryDescription);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.btnCategoryAdd);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCategoryAdd;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtCategoryDescription;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Button btnCategoryUpdate;
		private System.Windows.Forms.Button btnCategoryDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblCategoryCount;
		private System.Windows.Forms.Label lblTotalSeaFoodPrice;
		private System.Windows.Forms.Label lblProductStockAvg;
		private System.Windows.Forms.Label lblProductCount;
	}
}

