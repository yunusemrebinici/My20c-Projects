namespace Project14_SqlAllRelation
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.myProject14DataSet = new Project14_SqlAllRelation.MyProject14DataSet();
			this.teamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.teamDetailsTableAdapter = new Project14_SqlAllRelation.MyProject14DataSetTableAdapters.TeamDetailsTableAdapter();
			this.teamDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.teamValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myProject14DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDetailIdDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn,
            this.teamColorDataGridViewTextBoxColumn,
            this.teamCityDataGridViewTextBoxColumn,
            this.teamValueDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.teamDetailsBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1350, 292);
			this.dataGridView1.TabIndex = 0;
			// 
			// myProject14DataSet
			// 
			this.myProject14DataSet.DataSetName = "MyProject14DataSet";
			this.myProject14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// teamDetailsBindingSource
			// 
			this.teamDetailsBindingSource.DataMember = "TeamDetails";
			this.teamDetailsBindingSource.DataSource = this.myProject14DataSet;
			// 
			// teamDetailsTableAdapter
			// 
			this.teamDetailsTableAdapter.ClearBeforeFill = true;
			// 
			// teamDetailIdDataGridViewTextBoxColumn
			// 
			this.teamDetailIdDataGridViewTextBoxColumn.DataPropertyName = "TeamDetailId";
			this.teamDetailIdDataGridViewTextBoxColumn.HeaderText = "TeamDetailId";
			this.teamDetailIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.teamDetailIdDataGridViewTextBoxColumn.Name = "teamDetailIdDataGridViewTextBoxColumn";
			this.teamDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// teamIdDataGridViewTextBoxColumn
			// 
			this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
			this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
			this.teamIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
			// 
			// teamColorDataGridViewTextBoxColumn
			// 
			this.teamColorDataGridViewTextBoxColumn.DataPropertyName = "TeamColor";
			this.teamColorDataGridViewTextBoxColumn.HeaderText = "TeamColor";
			this.teamColorDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.teamColorDataGridViewTextBoxColumn.Name = "teamColorDataGridViewTextBoxColumn";
			// 
			// teamCityDataGridViewTextBoxColumn
			// 
			this.teamCityDataGridViewTextBoxColumn.DataPropertyName = "TeamCity";
			this.teamCityDataGridViewTextBoxColumn.HeaderText = "TeamCity";
			this.teamCityDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.teamCityDataGridViewTextBoxColumn.Name = "teamCityDataGridViewTextBoxColumn";
			// 
			// teamValueDataGridViewTextBoxColumn
			// 
			this.teamValueDataGridViewTextBoxColumn.DataPropertyName = "TeamValue";
			this.teamValueDataGridViewTextBoxColumn.HeaderText = "TeamValue";
			this.teamValueDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.teamValueDataGridViewTextBoxColumn.Name = "teamValueDataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1350, 457);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myProject14DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private MyProject14DataSet myProject14DataSet;
		private System.Windows.Forms.BindingSource teamDetailsBindingSource;
		private MyProject14DataSetTableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamDetailIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamColorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn teamValueDataGridViewTextBoxColumn;
	}
}

