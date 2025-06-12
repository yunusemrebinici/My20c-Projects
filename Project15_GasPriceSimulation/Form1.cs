using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		double lpg, gasoline, diesel, gasAmount, dieselAmount, lpgAmount, totalPrice;

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtTotalGas.Clear();
			txtTotalPrice.Clear();
			progressBar1.Value = 0;
			timer1.Stop();


		}

		int count;
		int max;
		private async void Form1_Load(object sender, EventArgs e)
		{			

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://akaryakit-fiyatlari.p.rapidapi.com/fuel/istanbul"),
				Headers =
	{
		{ "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "akaryakit-fiyatlari.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json=JObject.Parse(body);
				var gasolineJsonValue = json["data"][16]["prices"][0]["benzin"].ToString().Replace("₺","").Replace(",",".");
				var lpgJsonValue = json["data"][16]["prices"][0]["lpg"].ToString().Replace("₺","").Replace(",", "."); ;
				var dieselJsonValue = json["data"][16]["prices"][0]["motorin"].ToString().Replace("₺","").Replace(",", "."); ;
				txtDiesel.Text = dieselJsonValue.ToString();
				diesel = Convert.ToDouble(dieselJsonValue.ToString());
				txtLpg.Text = lpgJsonValue.ToString();
				txtGasoline.Text = gasolineJsonValue.ToString();

			}




		}


		private void button1_Click(object sender, EventArgs e)
		{
			gasAmount = Convert.ToDouble(txtGasoline.Text);
			dieselAmount = Convert.ToDouble(txtDiesel.Text);
			lpgAmount = Convert.ToDouble(txtLpg.Text);
			max = int.Parse(txtTotalGas.Text);

			timer1.Start();
			timer1.Interval = 1000;


		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			progressBar1.Maximum = max;
			if (rdbGasoline.Checked == true)
			{
				count++;
				if (count <= max)
				{
					totalPrice += gasAmount;
					txtTotalPrice.Text = totalPrice.ToString();
					progressBar1.Value += 1;
				}

			}

			if (rdbDiesel.Checked == true)
			{
				count++;
				if (count <= max)
				{
					totalPrice += dieselAmount;
					txtTotalPrice.Text = totalPrice.ToString();
					progressBar1.Value += 1;
				}

			}

			if (rdbLPG.Checked == true)
			{
				count++;
				if (count <= max)
				{
					totalPrice += lpgAmount;
					txtTotalPrice.Text = totalPrice.ToString();
					progressBar1.Value += 1;
				}

			}
		}
	}
}
