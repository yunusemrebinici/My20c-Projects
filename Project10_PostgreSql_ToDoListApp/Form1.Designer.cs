namespace Project10_PostgreSql_ToDoListApp
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
			this.txtİd = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPriorty = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.rdbFinished = new System.Windows.Forms.RadioButton();
			this.rdbContinues = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnFinished = new System.Windows.Forms.Button();
			this.btnContinues = new System.Windows.Forms.Button();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnCategories = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "İşlem İd:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Başlık:";
			// 
			// txtİd
			// 
			this.txtİd.Location = new System.Drawing.Point(132, 17);
			this.txtİd.Name = "txtİd";
			this.txtİd.Size = new System.Drawing.Size(160, 27);
			this.txtİd.TabIndex = 3;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(321, 18);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(118, 33);
			this.btnList.TabIndex = 4;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(132, 60);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(160, 27);
			this.txtTitle.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Kategori:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Öncelik:";
			// 
			// txtPriorty
			// 
			this.txtPriorty.Location = new System.Drawing.Point(132, 142);
			this.txtPriorty.Name = "txtPriorty";
			this.txtPriorty.Size = new System.Drawing.Size(160, 27);
			this.txtPriorty.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Açıklama:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(132, 192);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(160, 198);
			this.txtDescription.TabIndex = 3;
			// 
			// rdbFinished
			// 
			this.rdbFinished.AutoSize = true;
			this.rdbFinished.Location = new System.Drawing.Point(132, 396);
			this.rdbFinished.Name = "rdbFinished";
			this.rdbFinished.Size = new System.Drawing.Size(131, 24);
			this.rdbFinished.TabIndex = 5;
			this.rdbFinished.TabStop = true;
			this.rdbFinished.Text = "Tamamlandı";
			this.rdbFinished.UseVisualStyleBackColor = true;
			// 
			// rdbContinues
			// 
			this.rdbContinues.AutoSize = true;
			this.rdbContinues.Location = new System.Drawing.Point(132, 426);
			this.rdbContinues.Name = "rdbContinues";
			this.rdbContinues.Size = new System.Drawing.Size(147, 24);
			this.rdbContinues.TabIndex = 5;
			this.rdbContinues.TabStop = true;
			this.rdbContinues.Text = "Devam Ediyor";
			this.rdbContinues.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(321, 59);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(118, 33);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Oluştur";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(321, 100);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(118, 33);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(321, 141);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(118, 33);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnFinished
			// 
			this.btnFinished.Location = new System.Drawing.Point(321, 192);
			this.btnFinished.Name = "btnFinished";
			this.btnFinished.Size = new System.Drawing.Size(118, 66);
			this.btnFinished.TabIndex = 4;
			this.btnFinished.Text = "Bitenler";
			this.btnFinished.UseVisualStyleBackColor = true;
			this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
			// 
			// btnContinues
			// 
			this.btnContinues.Location = new System.Drawing.Point(321, 266);
			this.btnContinues.Name = "btnContinues";
			this.btnContinues.Size = new System.Drawing.Size(118, 66);
			this.btnContinues.TabIndex = 4;
			this.btnContinues.Text = "Devam Edenler";
			this.btnContinues.UseVisualStyleBackColor = true;
			this.btnContinues.Click += new System.EventHandler(this.btnContinues_Click);
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(132, 103);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(160, 28);
			this.cmbCategory.TabIndex = 6;
			// 
			// btnCategories
			// 
			this.btnCategories.Location = new System.Drawing.Point(321, 339);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Size = new System.Drawing.Size(118, 53);
			this.btnCategories.TabIndex = 7;
			this.btnCategories.Text = "Kategori Sayfası";
			this.btnCategories.UseVisualStyleBackColor = true;
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(474, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(668, 421);
			this.dataGridView1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1183, 490);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategories);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.rdbContinues);
			this.Controls.Add(this.rdbFinished);
			this.Controls.Add(this.btnContinues);
			this.Controls.Add(this.btnFinished);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtPriorty);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtİd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtİd;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPriorty;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.RadioButton rdbFinished;
		private System.Windows.Forms.RadioButton rdbContinues;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnFinished;
		private System.Windows.Forms.Button btnContinues;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

