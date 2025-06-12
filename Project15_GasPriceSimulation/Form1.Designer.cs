namespace Project15_GasPriceSimulation
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.txtTotalGas = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtGasoline = new System.Windows.Forms.TextBox();
			this.txtDiesel = new System.Windows.Forms.TextBox();
			this.txtLpg = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbGasoline = new System.Windows.Forms.RadioButton();
			this.rdbLPG = new System.Windows.Forms.RadioButton();
			this.rdbDiesel = new System.Windows.Forms.RadioButton();
			this.btnClear = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20.2F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(195, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(385, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gas Price Simulation";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(23, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Yakıt Miktarı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(23, 226);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Toplam Tutar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(15, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "Dolum Durumu:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(187, 271);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(507, 23);
			this.progressBar1.TabIndex = 2;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Location = new System.Drawing.Point(187, 224);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(179, 27);
			this.txtTotalPrice.TabIndex = 3;
			// 
			// txtTotalGas
			// 
			this.txtTotalGas.Location = new System.Drawing.Point(187, 177);
			this.txtTotalGas.Name = "txtTotalGas";
			this.txtTotalGas.Size = new System.Drawing.Size(179, 27);
			this.txtTotalGas.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLpg);
			this.groupBox1.Controls.Add(this.txtDiesel);
			this.groupBox1.Controls.Add(this.txtGasoline);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(388, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 188);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fiyatlar";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(47, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "Lpg:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(7, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 25);
			this.label6.TabIndex = 3;
			this.label6.Text = "Motorin:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(14, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 25);
			this.label7.TabIndex = 4;
			this.label7.Text = "Benzin:";
			// 
			// txtGasoline
			// 
			this.txtGasoline.Location = new System.Drawing.Point(111, 37);
			this.txtGasoline.Name = "txtGasoline";
			this.txtGasoline.ReadOnly = true;
			this.txtGasoline.Size = new System.Drawing.Size(163, 27);
			this.txtGasoline.TabIndex = 5;
			// 
			// txtDiesel
			// 
			this.txtDiesel.Location = new System.Drawing.Point(111, 74);
			this.txtDiesel.Name = "txtDiesel";
			this.txtDiesel.ReadOnly = true;
			this.txtDiesel.Size = new System.Drawing.Size(163, 27);
			this.txtDiesel.TabIndex = 5;
			// 
			// txtLpg
			// 
			this.txtLpg.Location = new System.Drawing.Point(111, 107);
			this.txtLpg.Name = "txtLpg";
			this.txtLpg.ReadOnly = true;
			this.txtLpg.Size = new System.Drawing.Size(163, 27);
			this.txtLpg.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "İşlemi Başlat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbLPG);
			this.groupBox2.Controls.Add(this.rdbDiesel);
			this.groupBox2.Controls.Add(this.rdbGasoline);
			this.groupBox2.Location = new System.Drawing.Point(28, 70);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(338, 101);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yakıt Türü";
			// 
			// rdbGasoline
			// 
			this.rdbGasoline.AutoSize = true;
			this.rdbGasoline.Location = new System.Drawing.Point(16, 31);
			this.rdbGasoline.Name = "rdbGasoline";
			this.rdbGasoline.Size = new System.Drawing.Size(88, 24);
			this.rdbGasoline.TabIndex = 0;
			this.rdbGasoline.TabStop = true;
			this.rdbGasoline.Text = "Benzin";
			this.rdbGasoline.UseVisualStyleBackColor = true;
			// 
			// rdbLPG
			// 
			this.rdbLPG.AutoSize = true;
			this.rdbLPG.Location = new System.Drawing.Point(223, 31);
			this.rdbLPG.Name = "rdbLPG";
			this.rdbLPG.Size = new System.Drawing.Size(67, 24);
			this.rdbLPG.TabIndex = 0;
			this.rdbLPG.TabStop = true;
			this.rdbLPG.Text = "LPG";
			this.rdbLPG.UseVisualStyleBackColor = true;
			// 
			// rdbDiesel
			// 
			this.rdbDiesel.AutoSize = true;
			this.rdbDiesel.Location = new System.Drawing.Point(110, 31);
			this.rdbDiesel.Name = "rdbDiesel";
			this.rdbDiesel.Size = new System.Drawing.Size(93, 24);
			this.rdbDiesel.TabIndex = 0;
			this.rdbDiesel.TabStop = true;
			this.rdbDiesel.Text = "Motorin";
			this.rdbDiesel.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(407, 315);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(173, 38);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Temizle";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(727, 563);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtTotalGas);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.TextBox txtTotalGas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtLpg;
		private System.Windows.Forms.TextBox txtDiesel;
		private System.Windows.Forms.TextBox txtGasoline;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdbLPG;
		private System.Windows.Forms.RadioButton rdbDiesel;
		private System.Windows.Forms.RadioButton rdbGasoline;
		private System.Windows.Forms.Button btnClear;
	}
}

